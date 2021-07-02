using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class AES_128
    {
        private int Nb = 4;
        private int Nk = 4;
        private int Nr;

        private readonly int BLOCK_SIZE = 16;

        private static byte[] Sbox, InvSbox;
        private static byte[][] Rcon;
        byte[][] w;
        byte[] Key;
        private bool flagD = false;
        private byte[] encrypt;

        /*
            Функция проверки ключа и настройки параметров.
            Проверяем длину ключа на соответствие 128,192,256 бит.
            В зависимости от длины выставляем параметр Nk
        */
        public byte[] CheckKey(byte[] key)
        {
            int len = key.Length;
            if (len == 16) Nk = 4;
            else if (len == 24) Nk = 6;
            else if (len == 32) Nk = 8;
            Nr = Nk + 6;
            return key;
        }
        /*
            Функция расшифрования.
            Аналогична функции шифрования за исключением
            процесса расшифрования блока.
        */
        public byte[] Decrypt(byte[] cipherText, byte[] Key)
        {
            flagD = true;
            byte[] _key = CheckKey(Key);

            byte[] text = cipherText;
            byte[] key = _key;

            Sbox = AES_Sbox;
            InvSbox = AES_InvSbox;
            Rcon = AES_Rcon;

            byte[][] keys = GenerateSubKeys(key);
            w = GenerateWordKeys(keys);

            byte[] plainText = new byte[text.Length];
            Parallel.For(0, text.Length / BLOCK_SIZE, i =>
            {
                byte[] block = new byte[BLOCK_SIZE];
                Array.Copy(text, i * BLOCK_SIZE, block, 0, BLOCK_SIZE);
                Array.Copy(DecryptBlock(block), 0, plainText, i * block.Length, block.Length);
            });
            return plainText;
        }
        /*
            Фукнция расшифрования блока.    
        */
        private byte[] DecryptBlock(byte[] inp)
        {
            byte[] temp = new byte[inp.Length];

            byte[][] state = new byte[4][];
            for (int i = 0; i < 4; i++)
            {
                state[i] = new byte[4];
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    state[j][i] = inp[4 * i + j];
                }
            }
            //Console.Write($"round[0].input: ");
            //PrintState(state);

            state = AddRoundKey(state, w, Nr);
            //Console.Write($"round[0].k_sch: ");
            //PrintState(state);

            for (int i = Nr - 1; i >= 1; i--)
            {
                state = InvShiftRows(state);
                //Console.Write($"round[{i}].s_row: ");
                //PrintState(state);

                state = InvSubBytes(state);
                //Console.Write($"round[{i}].s_box: ");
                //PrintState(state);

                state = AddRoundKey(state, w, i);
                //Console.Write($"round[{i}].add: ");
                //PrintState(state);

                state = InvMixColumns(state);
                //Console.Write($"round[{i}].Mix: ");
                //PrintState(state);
            }
            state = InvSubBytes(state);
            //Console.Write($"round[10].s_box: ");
            //PrintState(state);

            state = InvShiftRows(state);
            //Console.Write($"round[10].s_row: ");
            //PrintState(state);

            state = AddRoundKey(state, w, 0);
            //Console.Write($"round[10].add: ");
            //PrintState(state);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    temp[i * 4 + j] = state[j][i];
                }
            }
            return temp;
        }
        public byte[] Encrypt(byte[] plainText, byte[] Key)
        {
            var t = Encoding.Unicode.GetString(plainText);
            if (t.Length % 8 != 0)
            {
                string temp = new string(' ', t.Length % 8);
                t += temp;
            }

            byte[] _key = CheckKey(Key);
            byte[] key = _key;
            byte[] text = Encoding.Unicode.GetBytes(t);

            //byte[] text = plainText;
            Sbox = AES_Sbox;
            InvSbox = AES_InvSbox;
            Rcon = AES_Rcon;

            byte[][] keys = GenerateSubKeys(key);
            w = GenerateWordKeys(keys);

            byte[] cipherText = new byte[text.Length];
            Parallel.For(0, text.Length / BLOCK_SIZE, i =>
            {
                byte[] block = new byte[BLOCK_SIZE];
                Array.Copy(text, i * BLOCK_SIZE, block, 0, BLOCK_SIZE);
                Array.Copy(EncryptBlock(block), 0, cipherText, i * block.Length, block.Length);
            });
            flagD = false;
            encrypt = cipherText;
            return encrypt;
        }

        private byte[] EncryptBlock(byte[] inp)
        {
            byte[] temp = new byte[inp.Length];

            byte[][] state = new byte[4][];
            for (int i = 0; i < 4; i++)
                state[i] = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    state[j][i] = inp[4 * i + j];
                }
            }
            //Console.Write($"round[0].input: ");
            //PrintState(state);

            state = AddRoundKey(state, w, 0);
            //Console.Write($"round[0].k_sch: ");
            //PrintState(state);

            for (int i = 1; i < Nr; i++)
            {
                state = SubBytes(state);
                //Console.Write($"round[{i}].subBytes: ");
                //PrintState(state);

                state = ShiftRows(state);
                //Console.Write($"round[{i}].ShiftRows: ");
                //PrintState(state);

                state = MixColumns(state);
                //Console.Write($"round[{i}].MixColumns: ");
                //PrintState(state);

                state = AddRoundKey(state, w, i);
                //Console.Write($"round[{i}].AddRoundKey: ");
                //PrintState(state);
            }
            //Console.Write("round[10].SubBytes: ");
            state = SubBytes(state);
            //PrintState(state);

            //Console.Write("round[10].ShiftRows: ");
            state = ShiftRows(state);
            //PrintState(state);

            //Console.Write("round[10].AddRoundKey: ");
            state = AddRoundKey(state, w, Nr);
            //PrintState(state);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    temp[i * 4 + j] = state[j][i];
                }
            }

            return temp;
        }

        private static void PrintKeys(byte[] keys)
        {
            Console.WriteLine(BitConverter.ToString(keys));
        }

        private void PrintState(byte[][] state)
        {
            byte[] temp = new byte[state.Length * 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    temp[4 * i + j] = state[j][i];

            Console.WriteLine(BitConverter.ToString(temp));
        }

        private byte[] SubWord(byte[] state)
        {
            return state.Select(i => Sbox[i]).ToArray();
        }

        private byte[][] SubBytes(byte[][] state)
        {
            byte[][] temp = new byte[4][];
            for (int row = 0; row < 4; row++)
            {
                temp[row] = new byte[Nb];
                for (int col = 0; col < Nb; col++)
                    temp[row][col] = Sbox[state[row][col]];
            }

            return temp;
        }

        private byte[][] InvSubBytes(byte[][] state)
        {
            byte[][] temp = new byte[4][];
            for (int row = 0; row < 4; row++)
            {
                temp[row] = new byte[Nb];
                for (int col = 0; col < Nb; col++)
                    temp[row][col] = InvSbox[state[row][col]];
            }

            return temp;
        }

        private byte[][] ShiftRows(byte[][] state)
        {

            byte[][] t = new byte[4][];

            for (int r = 0; r < 4; r++)
            {
                byte[] row = state[r];
                row = row.Skip(r).Concat(row.Take(r)).ToArray();
                t[r] = row;
            }
            return t;
        }

        private byte[][] InvShiftRows(byte[][] state)
        {
            byte[][] t = new byte[4][];

            for (int r = 0; r < 4; r++)
            {
                byte[] row = state[r];
                row = row.Skip(4 - r).Concat(row.Take(r + 4)).ToArray();
                t[r] = row;
            }
            return t;
        }

        private byte[][] MulKef = new byte[][]
        {
            new byte[] {0x_02,0x_03,0x_01,0x_01},
            new byte[] {0x_01,0x_02,0x_03,0x_01},
            new byte[] {0x_01,0x_01,0x_02,0x_03},
            new byte[] {0x_03,0x_01,0x_01,0x_02}
        };

        private byte[][] InvMixColumns(byte[][] s)
        {
            int[] sp = new int[4];
            byte b02 = (byte)0x0e, b03 = (byte)0x0b, b04 = (byte)0x0d, b05 = (byte)0x09;
            for (int c = 0; c < 4; c++)
            {
                sp[0] = FFMul(b02, s[0][c]) ^ FFMul(b03, s[1][c]) ^ FFMul(b04, s[2][c]) ^ FFMul(b05, s[3][c]);
                sp[1] = FFMul(b05, s[0][c]) ^ FFMul(b02, s[1][c]) ^ FFMul(b03, s[2][c]) ^ FFMul(b04, s[3][c]);
                sp[2] = FFMul(b04, s[0][c]) ^ FFMul(b05, s[1][c]) ^ FFMul(b02, s[2][c]) ^ FFMul(b03, s[3][c]);
                sp[3] = FFMul(b03, s[0][c]) ^ FFMul(b04, s[1][c]) ^ FFMul(b05, s[2][c]) ^ FFMul(b02, s[3][c]);
                for (int i = 0; i < 4; i++)
                    s[i][c] = (byte)(sp[i]);
            }
            return s;
        }

        private byte[][] MixColumns(byte[][] s)
        {
            byte[][] res = new byte[4][];
            byte[] sp = new byte[4];
            for (int c = 0; c < 4; c++)
            {
                sp[0] = (byte)(FFMul(MulKef[0][0], s[0][c]) ^ FFMul(MulKef[0][1], s[1][c]) ^ FFMul(MulKef[0][2], s[2][c]) ^ FFMul(MulKef[0][3], s[3][c]));
                sp[1] = (byte)(FFMul(MulKef[1][0], s[0][c]) ^ FFMul(MulKef[1][1], s[1][c]) ^ FFMul(MulKef[1][2], s[2][c]) ^ FFMul(MulKef[1][3], s[3][c]));
                sp[2] = (byte)(FFMul(MulKef[2][0], s[0][c]) ^ FFMul(MulKef[2][1], s[1][c]) ^ FFMul(MulKef[2][2], s[2][c]) ^ FFMul(MulKef[2][3], s[3][c]));
                sp[3] = (byte)(FFMul(MulKef[3][0], s[0][c]) ^ FFMul(MulKef[3][1], s[1][c]) ^ FFMul(MulKef[3][2], s[2][c]) ^ FFMul(MulKef[3][3], s[3][c]));
                for (int i = 0; i < 4; i++)
                    s[i][c] = sp[i];
            }
            return s;
        }

        public byte FFMul(byte a, byte b)
        {
            byte aa = a, bb = b, r = 0, t;
            while (aa != 0)
            {
                if ((aa & 1) != 0)
                    r = (byte)(r ^ bb);
                t = (byte)(bb & 0x80);
                bb = (byte)(bb << 1);
                if (t != 0)
                    bb = (byte)(bb ^ 0x1b);
                aa = (byte)((aa & 0xff) >> 1);
            }
            return r;
        }

        private byte[][] GenerateWordKeys(byte[][] keys)
        {
            byte[][] w = new byte[44][];
            for (int i = 0; i < 4; i++)
            {
                byte[] temp = new byte[4];
                for (int j = 0; j < 4; j++)
                {
                    temp[j] = keys[j][i];
                }
                w[i] = temp;
            }

            for (int i = 4; i < 44; i++)
            {
                byte[] temp = new byte[4];
                if (i % 4 == 0)
                {

                    w[i] = XOR(SubWord(RotWord(w[i - 1])), Rcon[i / 4]);
                    w[i] = XOR(w[i], w[i - 4]);
                }
                else
                {
                    w[i] = XOR(w[i - 4], w[i - 1]);
                }
            }
            return w;
        }

        private byte[] XOR(byte[] vs1, byte[] vs2)
        {
            byte[] res = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                res[i] = (byte)(vs1[i] ^ vs2[i]);
            }
            return res;
        }

        private static byte[] RotWord(byte[] input)
        {
            //PrintKeys(input.Skip(1).Concat(input.Take(1)).ToArray());
            return input.Skip(1).Concat(input.Take(1)).ToArray();
        }

        private byte[][] GenerateSubKeys(byte[] key)
        {
            byte[][] rez = new byte[4][];
            for (int i = 0; i < 4; i++)
                rez[i] = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    rez[j][i] = key[4 * i + j];
                }
            }
            return rez;
        }

        private byte[][] AddRoundKey(byte[][] state, byte[][] w, int round)
        {
            byte[][] tmp = new byte[4][];
            for (int i = 0; i < Nb; i++)
                tmp[i] = new byte[4];

            for (int c = 0; c < Nb; c++)
            {
                for (int l = 0; l < 4; l++)
                    tmp[l][c] = (byte)(state[l][c] ^ w[round * Nb + c][l]);
            }

            return tmp;
        }

        public string GenerateKey()
        {
            throw new NotImplementedException();
        }

        public string KeyView()
        {
            BitArray arr = new BitArray(Key);
            StringBuilder rez = new StringBuilder();
            foreach (bool b in arr)
            {
                int bit = b ? 1 : 0;
                rez.Append(bit);
            }
            return rez.ToString();
        }

        public static byte[] AES_Sbox = {
            0x63, 0x7c, 0x77, 0x7b, 0xf2, 0x6b, 0x6f, 0xc5, 0x30, 0x01, 0x67, 0x2b, 0xfe, 0xd7, 0xab, 0x76,
            0xca, 0x82, 0xc9, 0x7d, 0xfa, 0x59, 0x47, 0xf0, 0xad, 0xd4, 0xa2, 0xaf, 0x9c, 0xa4, 0x72, 0xc0,
            0xb7, 0xfd, 0x93, 0x26, 0x36, 0x3f, 0xf7, 0xcc, 0x34, 0xa5, 0xe5, 0xf1, 0x71, 0xd8, 0x31, 0x15,
            0x04, 0xc7, 0x23, 0xc3, 0x18, 0x96, 0x05, 0x9a, 0x07, 0x12, 0x80, 0xe2, 0xeb, 0x27, 0xb2, 0x75,
            0x09, 0x83, 0x2c, 0x1a, 0x1b, 0x6e, 0x5a, 0xa0, 0x52, 0x3b, 0xd6, 0xb3, 0x29, 0xe3, 0x2f, 0x84,
            0x53, 0xd1, 0x00, 0xed, 0x20, 0xfc, 0xb1, 0x5b, 0x6a, 0xcb, 0xbe, 0x39, 0x4a, 0x4c, 0x58, 0xcf,
            0xd0, 0xef, 0xaa, 0xfb, 0x43, 0x4d, 0x33, 0x85, 0x45, 0xf9, 0x02, 0x7f, 0x50, 0x3c, 0x9f, 0xa8,
            0x51, 0xa3, 0x40, 0x8f, 0x92, 0x9d, 0x38, 0xf5, 0xbc, 0xb6, 0xda, 0x21, 0x10, 0xff, 0xf3, 0xd2,
            0xcd, 0x0c, 0x13, 0xec, 0x5f, 0x97, 0x44, 0x17, 0xc4, 0xa7, 0x7e, 0x3d, 0x64, 0x5d, 0x19, 0x73,
            0x60, 0x81, 0x4f, 0xdc, 0x22, 0x2a, 0x90, 0x88, 0x46, 0xee, 0xb8, 0x14, 0xde, 0x5e, 0x0b, 0xdb,
            0xe0, 0x32, 0x3a, 0x0a, 0x49, 0x06, 0x24, 0x5c, 0xc2, 0xd3, 0xac, 0x62, 0x91, 0x95, 0xe4, 0x79,
            0xe7, 0xc8, 0x37, 0x6d, 0x8d, 0xd5, 0x4e, 0xa9, 0x6c, 0x56, 0xf4, 0xea, 0x65, 0x7a, 0xae, 0x08,
            0xba, 0x78, 0x25, 0x2e, 0x1c, 0xa6, 0xb4, 0xc6, 0xe8, 0xdd, 0x74, 0x1f, 0x4b, 0xbd, 0x8b, 0x8a,
            0x70, 0x3e, 0xb5, 0x66, 0x48, 0x03, 0xf6, 0x0e, 0x61, 0x35, 0x57, 0xb9, 0x86, 0xc1, 0x1d, 0x9e,
            0xe1, 0xf8, 0x98, 0x11, 0x69, 0xd9, 0x8e, 0x94, 0x9b, 0x1e, 0x87, 0xe9, 0xce, 0x55, 0x28, 0xdf,
            0x8c, 0xa1, 0x89, 0x0d, 0xbf, 0xe6, 0x42, 0x68, 0x41, 0x99, 0x2d, 0x0f, 0xb0, 0x54, 0xbb, 0x16
            };

        public static byte[] AES_InvSbox = {
            0x52, 0x09, 0x6a, 0xd5, 0x30, 0x36, 0xa5, 0x38, 0xbf, 0x40, 0xa3, 0x9e, 0x81, 0xf3, 0xd7, 0xfb,
            0x7c, 0xe3, 0x39, 0x82, 0x9b, 0x2f, 0xff, 0x87, 0x34, 0x8e, 0x43, 0x44, 0xc4, 0xde, 0xe9, 0xcb,
            0x54, 0x7b, 0x94, 0x32, 0xa6, 0xc2, 0x23, 0x3d, 0xee, 0x4c, 0x95, 0x0b, 0x42, 0xfa, 0xc3, 0x4e,
            0x08, 0x2e, 0xa1, 0x66, 0x28, 0xd9, 0x24, 0xb2, 0x76, 0x5b, 0xa2, 0x49, 0x6d, 0x8b, 0xd1, 0x25,
            0x72, 0xf8, 0xf6, 0x64, 0x86, 0x68, 0x98, 0x16, 0xd4, 0xa4, 0x5c, 0xcc, 0x5d, 0x65, 0xb6, 0x92,
            0x6c, 0x70, 0x48, 0x50, 0xfd, 0xed, 0xb9, 0xda, 0x5e, 0x15, 0x46, 0x57, 0xa7, 0x8d, 0x9d, 0x84,
            0x90, 0xd8, 0xab, 0x00, 0x8c, 0xbc, 0xd3, 0x0a, 0xf7, 0xe4, 0x58, 0x05, 0xb8, 0xb3, 0x45, 0x06,
            0xd0, 0x2c, 0x1e, 0x8f, 0xca, 0x3f, 0x0f, 0x02, 0xc1, 0xaf, 0xbd, 0x03, 0x01, 0x13, 0x8a, 0x6b,
            0x3a, 0x91, 0x11, 0x41, 0x4f, 0x67, 0xdc, 0xea, 0x97, 0xf2, 0xcf, 0xce, 0xf0, 0xb4, 0xe6, 0x73,
            0x96, 0xac, 0x74, 0x22, 0xe7, 0xad, 0x35, 0x85, 0xe2, 0xf9, 0x37, 0xe8, 0x1c, 0x75, 0xdf, 0x6e,
            0x47, 0xf1, 0x1a, 0x71, 0x1d, 0x29, 0xc5, 0x89, 0x6f, 0xb7, 0x62, 0x0e, 0xaa, 0x18, 0xbe, 0x1b,
            0xfc, 0x56, 0x3e, 0x4b, 0xc6, 0xd2, 0x79, 0x20, 0x9a, 0xdb, 0xc0, 0xfe, 0x78, 0xcd, 0x5a, 0xf4,
            0x1f, 0xdd, 0xa8, 0x33, 0x88, 0x07, 0xc7, 0x31, 0xb1, 0x12, 0x10, 0x59, 0x27, 0x80, 0xec, 0x5f,
            0x60, 0x51, 0x7f, 0xa9, 0x19, 0xb5, 0x4a, 0x0d, 0x2d, 0xe5, 0x7a, 0x9f, 0x93, 0xc9, 0x9c, 0xef,
            0xa0, 0xe0, 0x3b, 0x4d, 0xae, 0x2a, 0xf5, 0xb0, 0xc8, 0xeb, 0xbb, 0x3c, 0x83, 0x53, 0x99, 0x61,
            0x17, 0x2b, 0x04, 0x7e, 0xba, 0x77, 0xd6, 0x26, 0xe1, 0x69, 0x14, 0x63, 0x55, 0x21, 0x0c, 0x7d
            };

        public static byte[][] AES_Rcon = {
            new byte[] {0x00, 0x00, 0x00, 0x00},
            new byte[] {0x01, 0x00, 0x00, 0x00},
            new byte[] {0x02, 0x00, 0x00, 0x00},
            new byte[] {0x04, 0x00, 0x00, 0x00},
            new byte[] {0x08, 0x00, 0x00, 0x00},
            new byte[] {0x10, 0x00, 0x00, 0x00},
            new byte[] {0x20, 0x00, 0x00, 0x00},
            new byte[] {0x40, 0x00, 0x00, 0x00},
            new byte[] {0x80, 0x00, 0x00, 0x00},
            new byte[] {0x1b, 0x00, 0x00, 0x00},
            new byte[] {0x36, 0x00, 0x00, 0x00}
            };
    }
}
