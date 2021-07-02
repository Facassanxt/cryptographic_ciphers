using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Elgamal
    {
        readonly Random rnd = new Random();
        const string defaultAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        readonly string letters;
        public Elgamal(string alphabet = null)
        {
            letters = string.IsNullOrEmpty(alphabet) ? defaultAlphabet : alphabet;
        }
        private string CodeEncode(string text, int P, int G, int X, bool flag)
        {
            string Result = "";
            BigInteger Y = BigInteger.Pow(G, X) % P;
            List<int> K = new List<int> { 3, 7, 13 };
            if (flag)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    int A = (int)(BigInteger.Pow(G, K[i % 3]) % P);
                    int B = (int)(BigInteger.Pow(Y, K[i % 3]) * (letters.IndexOf(text[i]) + 1) % P);
                    if (P >= 10 & B < 10)
                    {
                        Result += $"{A}0{B},";
                    }
                    else if (P >= 100 & B < 10)
                    {
                        Result += $"{A}00{B},";
                    }
                    else
                    {
                        Result += $"{A}{B},";
                    }
                }
                Result = Result.Remove(Result.Length - 1);
            }
            else 
            {
                string[] values = text.Split(',');
                int sc = 1;
                if (P >= 10)
                    sc = 2;
                else if (P >= 100)
                    sc = 3;
                for (int i = 0; i < values.Length; i++)
                {
                    int temp_1 = Int32.Parse(values[i].Substring(0, sc));
                    int temp_2 = Int32.Parse(values[i].Substring(sc, sc));
                    int M = (int)((temp_2 * BigInteger.Pow(temp_1, P - 1 - X)) % P);
                    Result += $"{letters[M - 1]}";
                }
            }
            return Result;
        }
        public string Encrypt(string text, int P, int G, int X) => CodeEncode(text, P, G, X, true);
        public string Decrypt(string text, int P, int G, int X) => CodeEncode(text, P, G, X, false);
    }
}
