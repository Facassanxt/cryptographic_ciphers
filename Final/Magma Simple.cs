using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Magma_Simple
    {
        private const int BLOCK_SIZE = 8;
        private const int KEY_LENGTH = 32;

        public int BlockSize
        {
            get
            {
                return BLOCK_SIZE;
            }
        }

        public void SetKey(byte[] key)
        {
            _subKeys = GetSubKeys(key);
        }

        public int KeyLength
        {
            get
            {
                return KEY_LENGTH;
            }
        }

        private readonly byte[][] _sBox =
        {
            //            0     1     2     3     4     5     6     7     8     9     A     B     C     D     E     F
            new byte[] { 0x0C, 0x04, 0x06, 0x02, 0x0A, 0x05, 0x0B, 0x09, 0x0E, 0x08, 0x0D, 0x07, 0x00, 0x03, 0x0F, 0x01 },
            new byte[] { 0x06, 0x08, 0x02, 0x03, 0x09, 0x0A, 0x05, 0x0C, 0x01, 0x0E, 0x04, 0x07, 0x0B, 0x0D, 0x00, 0x0F },
            new byte[] { 0x0B, 0x03, 0x05, 0x08, 0x02, 0x0F, 0x0A, 0x0D, 0x0E, 0x01, 0x07, 0x04, 0x0C, 0x09, 0x06, 0x00 },
            new byte[] { 0x0C, 0x08, 0x02, 0x01, 0x0D, 0x04, 0x0F, 0x06, 0x07, 0x00, 0x0A, 0x05, 0x03, 0x0E, 0x09, 0x0B },
            new byte[] { 0x07, 0x0F, 0x05, 0x0A, 0x08, 0x01, 0x06, 0x0D, 0x00, 0x09, 0x03, 0x0E, 0x0B, 0x04, 0x02, 0x0C },
            new byte[] { 0x05, 0x0D, 0x0F, 0x06, 0x09, 0x02, 0x0C, 0x0A, 0x0B, 0x07, 0x08, 0x01, 0x04, 0x03, 0x0E, 0x00 },
            new byte[] { 0x08, 0x0E, 0x02, 0x05, 0x06, 0x09, 0x01, 0x0C, 0x0F, 0x04, 0x0B, 0x00, 0x0D, 0x0A, 0x03, 0x07 },
            new byte[] { 0x01, 0x07, 0x0E, 0x0D, 0x00, 0x05, 0x08, 0x03, 0x04, 0x0F, 0x0A, 0x06, 0x09, 0x0C, 0x0B, 0x02 }
        };

        private uint[] _subKeys;
        private byte[] s;
        private bool flagD = false;

        public string Decrypt(byte[] data, byte[] key, byte[] synhro, string mode)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(Encoding.Unicode.GetString(data));
            Console.WriteLine();
            Console.WriteLine();
            if (mode == "simple")
            {
                var Final_text = "";
                flagD = true;
                int len = data.Length;
                for (int i = 0; i < (len / 4) / 2; i++)
                {
                    byte[] bytes = new byte[8];
                    Array.Copy(data, i * 8, bytes, 0, bytes.Length);
                    Final_text += Encoding.Unicode.GetString(SimpleCipher(bytes, key));
                }
                Console.WriteLine();
                Console.WriteLine("Расшифрование - " + Final_text);
                return Final_text;
            }
            else if (mode == "gamma")
            {
                var Final_text = "";
                flagD = true;
                int len = data.Length;
                for (int i = 0; i < (len / 8); i++)
                {
                    byte[] bytes = new byte[8];
                    Array.Copy(data, i * 8, bytes, 0, bytes.Length);
                    Final_text += Encoding.Unicode.GetString(GammaCipher(bytes, key, synhro));
                }
                Console.WriteLine();
                Console.WriteLine("Расшифрование - " + Final_text);
                return Final_text;
            }
            return "";
        }

        public byte[] Encrypt(string data, byte[] key, byte[] synhro, string mode)
        {
            if (mode == "simple")
            {
                var Final_text = "";
                if (data.Length % 4 != 0)
                {
                    string temp = new string(' ', 4 - data.Length % 4);
                    data = data + temp;
                }
                int len = data.Length;
                byte[] rv = { };
                for (int i = 0; i < (len / 4); i++)
                {
                    byte[] ba = Encoding.Unicode.GetBytes(data.Substring(0, 4));
                    var r = SimpleCipher(ba, key);
                    rv = Combine(rv, r);
                    Final_text += Encoding.Unicode.GetString(r);
                    data = data.Substring(4, data.Length - 4);
                }
                Console.WriteLine();
                Console.WriteLine("Зашифроване - " + Final_text);
                return rv;
            }
            else if (mode == "gamma")
            {
                var Final_text = "";
                if (data.Length % 4 != 0)
                {
                    string temp = new string(' ', 4 - data.Length % 4);
                    data = data + temp;
                }
                int len = data.Length;
                byte[] rv = { };
                for (int i = 0; i < (len / 4); i++)
                {
                    byte[] ba = Encoding.Unicode.GetBytes(data.Substring(0, 4));
                    var r = GammaCipher(ba, key, synhro);
                    rv = Combine(rv, r);
                    Final_text += Encoding.Unicode.GetString(r);
                    data = data.Substring(4, data.Length - 4);
                }
                Console.WriteLine();
                Console.WriteLine("Зашифроване - " + Final_text);
                return rv;
            }
            return new byte[0];
        }
        private byte[] GammaCipher(byte[] data, byte[] key, byte[] synhro)
        {
            Console.WriteLine("data:" + BitConverter.ToString(data));
            s = synhro;
            Console.WriteLine("synhro:" + BitConverter.ToString(s));
            CalculateSubKeys(key);
            byte[] gamma = SimpleCipher(s, key);
            Console.WriteLine("gamma:" + BitConverter.ToString(gamma));
            IncGamma();
            var rez = XOR(gamma, data);
            Console.WriteLine("rez:" + BitConverter.ToString(rez));
            return rez;
        }
        private static byte[] Split(string plaintext)
        {
            string[] rez = new string[plaintext.Length / 2];
            int j = 0;
            for (int i = 0; i < plaintext.Length; i += 2)
                rez[j++] = plaintext.Substring(i, 2);

            return rez.Select(i => Convert.ToByte(i, 16)).ToArray();
        }
        private void IncGamma()
        {
            ulong t = BitConverter.ToUInt64(s, 0);
            t += 1;
            s = BitConverter.GetBytes(t);
        }
        private byte[] XOR(byte[] block, byte[] data)
        {
            byte[] res = new byte[8];
            for (int i = 0; i < 8; i++)
                res[i] = (byte)(block[i] ^ data[i]);

            return res;
        }
        private void CalculateSubKeys(byte[] key)
        {
            byte[] keyR = new byte[key.Length];
            uint[] subKeys = new uint[8];
            Array.Copy(key, keyR, key.Length);
            Array.Reverse(keyR);
            for (int i = 0; i < 8; i++)
            {
                subKeys[i] = BitConverter.ToUInt32(keyR, i * 4);
            }
            Array.Reverse(subKeys);
            _subKeys = subKeys;
        }

        private static byte[] Combine(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }
        private byte[] SimpleCipher(byte[] data, byte[] key)
        {
            SetKey(key);
            byte[] dataR = new byte[data.Length];
            Array.Copy(data, dataR, data.Length);
            Array.Reverse(dataR);
            uint a0 = BitConverter.ToUInt32(dataR, 0);
            uint a1 = BitConverter.ToUInt32(dataR, 4);
            //if (!flagD)
            //    Console.WriteLine($"(a1,a0) = ({Convert.ToString(a1, 16)},{Convert.ToString(a0, 16)})");
            //else
            //    Console.WriteLine($"(b1,b0) = ({Convert.ToString(a1, 16)},{Convert.ToString(a0, 16)})");

            byte[] result = new byte[8];

            for (int i = 0; i < 31; i++)
            {
                int keyIndex = 0;
                if (flagD == false) keyIndex = (i < 24) ? i % 8 : 7 - (i % 8);
                if (flagD == true) keyIndex = (i < 8) ? i % 8 : 7 - (i % 8);
                uint round = a1 ^ funcG(a0, _subKeys[keyIndex]);
                a1 = a0;
                a0 = round;
                //if (!flagD)
                //    if (i + 1 == 1)
                //        Console.WriteLine($"G[K{i + 1}](a1,a0) = ({Convert.ToString(a1, 16)},{Convert.ToString(a0, 16)})");
                //    else if (i + 1 == 2)
                //        Console.WriteLine($"G[K{i + 1}]G[K{i}](a1,a0) = ({Convert.ToString(a1, 16)},{Convert.ToString(a0, 16)})");
                //    else
                //        Console.WriteLine($"G[K{i + 1}]...G[K1](a1,a0) = ({Convert.ToString(a1, 16)},{Convert.ToString(a0, 16)})");
                //else
                //    if (31 + 1 - i == 32)
                //    Console.WriteLine($"G[K{31 + 1 - i}](b1,b0) = ({Convert.ToString(a1, 16)},{Convert.ToString(a0, 16)})");
                //else if (31 + 1 - i == 31)
                //    Console.WriteLine($"G[K{31 + 1 - i}]G[K32](b1,b0) = ({Convert.ToString(a1, 16)},{Convert.ToString(a0, 16)})");
                //else
                //    Console.WriteLine($"G[K{31 + 1 - i}]...G[K32](b1,b0) = ({Convert.ToString(a1, 16)},{Convert.ToString(a0, 16)})");
            }

            a1 ^= funcG(a0, _subKeys[0]);

            Array.Copy(BitConverter.GetBytes(a0), 0, result, 0, 4);
            Array.Copy(BitConverter.GetBytes(a1), 0, result, 4, 4);

            Array.Reverse(result);
            return result;
        }

        private uint funcG(uint a, uint k)
        {
            uint c = a + k;
            uint tmp = funcT(c);
            return (tmp << 11) | (tmp >> 21);
        }

        private uint funcT(uint a)
        {
            uint res = 0;

            for (int i = 0; i < 8; i++)
            {
                res ^= (uint)(_sBox[i][a >> (4 * i) & 0b_1111] << (4 * i));
            }

            return res;
        }

        private uint[] GetSubKeys(byte[] key)
        {
            byte[] keyR = new byte[key.Length];
            uint[] subKeys = new uint[8];
            Array.Copy(key, keyR, key.Length);
            Array.Reverse(keyR);
            for (int i = 0; i < 8; i++)
            {
                subKeys[i] = BitConverter.ToUInt32(keyR, i * 4);
            }
            Array.Reverse(subKeys);
            return subKeys;
        }
    }
}
