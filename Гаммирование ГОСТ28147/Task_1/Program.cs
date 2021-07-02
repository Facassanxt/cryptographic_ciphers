using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Numerics;
using System.Drawing;

namespace Task_1
{
    class RSA
    {
        class GammaGost28147
        {
            readonly byte[][] table = new byte[8][] 
            {
                new byte[] {12, 4, 6, 2, 10, 5, 11, 9, 14, 8, 13, 7, 0, 3, 15, 1 },
                new byte[] {6, 8, 2, 3, 9, 10, 5, 12, 1, 14, 4, 7, 11, 13, 0, 15 },
                new byte[] {11, 3, 5, 8, 2, 15, 10, 13, 14, 1, 7, 4, 12, 9, 6, 0 },
                new byte[] {12, 8, 2, 1, 13, 4, 15, 6, 7, 0, 10, 5, 3, 14, 9, 11 },
                new byte[] {7, 15, 5, 10, 8, 1, 6, 13, 0, 9, 3, 14, 11, 4, 2, 12 },
                new byte[] {5, 13, 15, 6, 9, 2, 12, 10, 11, 7, 8, 1, 4, 3, 14, 0 },
                new byte[] {8, 14, 2, 5, 6, 9, 1, 12, 15, 4, 11, 0, 13, 10, 3, 7 },
                new byte[] {1, 7, 14, 13, 0, 5, 8, 3, 4, 15, 10, 6, 9, 12, 11, 2 } 
            };
            public byte[] EncryptBlocks { get; private set; }
            bool flagD = false;
            private readonly int BLOCK_SIZE = 8;
            private const uint C2 = 0x_1010101;
            private const uint C1 = 0x_1010104;
            private const uint s1 = 0x_1010104;
            private const uint s2 = 0x_1010104;
            private uint N1, N2, N3, N4;

            public string CheckKey(string key)
            {
                byte[] arr = Encoding.Unicode.GetBytes(key);
                if (arr.Length * 8 != 256)
                {
                    Console.WriteLine("Key * 8 != 256");
                }
                return key;
            }
            public string Decrypt(string cipherText, string DefaultKey)
            {
                flagD = true;
                string key = CheckKey(DefaultKey);
                byte[] text = Encoding.Unicode.GetBytes(cipherText);
                if (flagD == true && EncryptBlocks != null)
                {
                    text = EncryptBlocks;
                    EncryptBlocks = null;
                    flagD = false;
                }
                byte[][] allBlocks = GiveAllBlocks(text);
                uint[] keys = GenerateKeys(key);
                N1 = s1;
                N2 = s2;
                byte[] block = new byte[BLOCK_SIZE];
                byte[] plainBlocks = new byte[text.Length];
                int len = text.Length / 8;
                if (text.Length % 8 != 0) len++;
                for (int i = 0; i < len; i++)
                {
                    var syncro = GenerateSynhro(keys);
                    block = XOR(syncro, allBlocks[i]);
                    for (int j = 0; j < block.Length; j++)
                        plainBlocks[8 * i + j] = block[j];
                }
                flagD = false;
                return Encoding.Unicode.GetString(plainBlocks);
            }
            private byte[][] GiveAllBlocks(byte[] text)
            {
                int len = text.Length / 8 + 1;
                int j = 0, i = 0;
                byte[][] res = new byte[len][];
                for (; j < len; j++)
                {
                    if (j * 8 + 8 < text.Length)
                    {
                        res[j] = new byte[8];
                        for (; i < j * 8 + 8; i++)
                        {
                            res[j][i % 8] = text[i];
                        }
                    }
                    else
                    {
                        res[j] = new byte[text.Length - (j * 8)];
                        for (int l = 0; l < text.Length - (j * 8); l++)
                        {
                            res[j][l] = text[i++];
                        }
                    }
                }
                return res;
            }
            private byte[] XOR(byte[] syncro, byte[] block)
            {
                byte[] buffer = new byte[block.Length];
                for (int i = 0; i < block.Length; i++)
                {
                    buffer[i] = (byte)(syncro[i] ^ block[i]);
                }
                return buffer;
            }

            private byte[] GenerateSynhro(uint[] keys)
            {
                byte[] block = new byte[8];
                Array.Copy(BitConverter.GetBytes(N1), 0, block, 0, 4);
                Array.Copy(BitConverter.GetBytes(N2), 0, block, 4, 4);
                byte[] result = SimpleReplacement(block, keys);
                N3 = BitConverter.ToUInt32(result, 0);
                N4 = BitConverter.ToUInt32(result, 4);
                N3 = (uint)((N3 + C2) % Math.Pow(2, 32));
                N4 = (uint)((N4 + C1) % (Math.Pow(2, 32) - 1));
                N1 = N3;
                N2 = N4;
                Array.Copy(BitConverter.GetBytes(N1), 0, block, 0, 4);
                Array.Copy(BitConverter.GetBytes(N2), 0, block, 4, 4);
                return SimpleReplacement(block, keys);
            }
            public string Encrypt(string plainText, string DefaultKey)
            {
                string key = CheckKey(DefaultKey);
                byte[] text = Encoding.Unicode.GetBytes(plainText);
                byte[][] allBlocks = GiveAllBlocks(text);
                uint[] keys = GenerateKeys(key);
                N1 = s1;
                N2 = s2;
                byte[] block = new byte[BLOCK_SIZE];
                int len = text.Length / 8;
                if (text.Length % 8 != 0) len++;
                byte[] cipherBlocks = new byte[text.Length];
                for (int i = 0; i < len; i++)
                {
                    var syncro = GenerateSynhro(keys);
                    Console.WriteLine(System.Text.Encoding.UTF8.GetString(syncro));
                    block = XOR(syncro, allBlocks[i]);
                    for (int j = 0; j < block.Length; j++)
                        cipherBlocks[8 * i + j] = block[j];
                }
                EncryptBlocks = cipherBlocks;
                return Encoding.Unicode.GetString(cipherBlocks);
            }
            private byte[] SimpleReplacement(byte[] block, uint[] keys)
            {
                byte[] N1 = new byte[block.Length / 2];
                byte[] N2 = new byte[block.Length / 2];
                Array.Copy(block, 0, N1, 0, 4);
                Array.Copy(block, 4, N2, 0, 4);
                for (int i = 0; i < 32; i++)
                {
                    uint CM1 = (uint)((BitConverter.ToUInt32(N1, 0) + keys[i]) % Math.Pow(2, 32));
                    byte[] K = Replfacement(CM1);
                    uint R = BitConverter.ToUInt32(K, 0);
                    R = (R << 11) | (R >> 21);
                    uint CM2 = R ^ BitConverter.ToUInt32(N2, 0);
                    if (i < 31)
                    {
                        N2 = N1;
                        N1 = BitConverter.GetBytes(CM2);
                    }
                    else
                        N2 = BitConverter.GetBytes(CM2);
                }
                var output = new byte[8];
                for (int i = 0; i < 4; i++)
                {
                    output[i] = N1[i];
                    output[4 + i] = N2[i];
                }
                return output;
            }
            private byte[] Replfacement(uint cM1)
            {
                uint result = 0;
                for (int i = 0; i < 8; i++)
                {
                    var temp = (byte)((cM1 >> (4 * i)) & 0x0f);
                    temp = table[i][temp];
                    result |= (UInt32)temp << (4 * i);
                }
                return BitConverter.GetBytes(result);
            }
            private uint[] GenerateKeys(string key)
            {
                byte[] keys = Encoding.Unicode.GetBytes(key);
                uint[] result = new uint[keys.Length];
                for (int i = 0; i < 24; i++)
                {
                    int index = (i * 4) % 32;
                    result[i] = BitConverter.ToUInt32(keys, index);
                }

                for (int i = 24; i < 32; i++)
                {
                    result[i] = BitConverter.ToUInt32(keys, 28 - (i * 4) % 32);
                }

                return result;
            }

        }

        static void Main()
        {

            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("GammaGost28147 на С#");
            Console.WriteLine("Стебло А.С 181-352");
            var message = "НЕЛЬЗЯ ИЗ ЯИЧНИЦЫ СНОВА СДЕЛАТЬ ЯЙЦО ТЧК";
            string b = "1234567890ABCDEF";

            var DefaultKey = b;
            GammaGost28147 _GammaGost28147 = new GammaGost28147();
            var Encrypt = _GammaGost28147.Encrypt(message, DefaultKey);
            var Decrypt = _GammaGost28147.Decrypt(Encrypt, DefaultKey);
            Console.WriteLine(Encrypt);
            Console.WriteLine(Decrypt);
        }
    }
}