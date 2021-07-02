using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Shannon
    {
        const string defaultAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        readonly string letters;
        int a;
        int c;
        int x;
        public Shannon(string secretKey, string alphabet = null)
        {
            letters = string.IsNullOrEmpty(alphabet) ? defaultAlphabet : alphabet;
            string[] words = secretKey.Split(',');
            a = Int32.Parse(words[0]);
            c = Int32.Parse(words[1]);
            x = Int32.Parse(words[2]);
            Console.WriteLine($"a = {a}, c = {c}, x = {x}");
        }
        private int lkm()
        {
            x = (a * x + c) % letters.Length;
            return x;
        }

        private List<int> buildGamma(int textLength)
        {
            List<int> gamma = new List<int>();
            for (int i = 0; i < textLength; i++)
                gamma.Add(lkm());
            return gamma;
        }

        private string Shannon_chip(string text, bool encrypting)
        {
            var xMin = x;
            var result = "";
            int k;
            var gamma = buildGamma(text.Length);
            for (int i = 0; i < text.Length; i++)
            {
                var indexSymbol = letters.IndexOf(text[i]);
                k = (encrypting) ? (indexSymbol - gamma[i]) % letters.Length : (indexSymbol + gamma[i]) % letters.Length;
                if (k < 0)
                    k += letters.Length;
                result += letters[k];
            }

            x = xMin;
            Console.WriteLine(result);
            return result;
        }
        public string Encrypt(string encryptedMessage)
            => Shannon_chip(encryptedMessage, false);

        public string Decrypt(string decryptMessage)
            => Shannon_chip(decryptMessage, true);
    }
}
