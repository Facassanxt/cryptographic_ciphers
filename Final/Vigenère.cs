using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Vigenère
    {
        const string defaultAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        readonly string letters;
        public Vigenère(string alphabet = null)
        {
            letters = string.IsNullOrEmpty(alphabet) ? defaultAlphabet : alphabet;
        }
        private string Vigenère_chip(string text, string key, bool encrypting = true)
        {
            var retValue = "";
            var ms = key + text;
            var q = letters.Length;
            var last = 0;
            for (int i = 0; i < text.Length; i++)
            {
                var letterIndex_1 = letters.IndexOf(text[i]);
                var letterIndex_2 = letters.IndexOf(ms[i]);

                if (letterIndex_1 < 0 || letterIndex_2 < 0)
                {
                    retValue += text[i].ToString();
                }
                else
                {
                    if (encrypting)
                    {
                        retValue += letters[(q + letterIndex_1 + letterIndex_2) % q];
                    }
                    else
                    {
                        var temp = (q + letterIndex_1 - (letterIndex_2 - last)) % q;
                        if (temp < 0) temp += q;
                        retValue += letters[temp];
                        last = letterIndex_2 - last;
                    }
                }
            }
            return retValue;
        }
        public string Encrypt(string plainMessage, string key)
            => Vigenère_chip(plainMessage, key);

        public string Decrypt(string encryptedMessage, string key)
            => Vigenère_chip(encryptedMessage, key, false);
    }
}
