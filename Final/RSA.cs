using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class RSA
    {
        readonly Random rnd = new Random();
        const string defaultAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        readonly string letters;
        public RSA(string alphabet = null)
        {
            letters = string.IsNullOrEmpty(alphabet) ? defaultAlphabet : alphabet;
        }
        private string CodeEncode(string text, string key, bool flag) 
        {
            string[] values = key.Split(',');
            string Result = "";
            int key_1 = Int32.Parse(values[0]);
            int key_2 = Int32.Parse(values[1]);
            if (flag)
            {
                for (int i = 0; i < text.Length; i++)
                    Result += $"{(BigInteger.Pow(letters.IndexOf(text[i]) + 1, key_1) % key_2)},";
                Result = Result.Remove(Result.Length - 1);
            }
            else
            {
                string[] values_2 = text.Split(',');
                for (int i = 0; i < values_2.Length; i++)
                    Result += $"{letters[(int)(BigInteger.Pow(Int32.Parse(values_2[i]), key_1) % key_2) - 1]}";
            }
            return Result;
        }

        public string Encrypt(string plainMessage, string key)
            => CodeEncode(plainMessage, key, true);
        public string Decrypt(string encryptedMessage, string key)
            => CodeEncode(encryptedMessage, key, false);
    }
}
