using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Trithemius
    {
        const string defaultAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        readonly string letters;
        public Trithemius(string alphabet = null)
        {
            letters = string.IsNullOrEmpty(alphabet) ? defaultAlphabet : alphabet;
        }
        private string Trithemius_chip(string text, bool encrypting = true)
        {
            var retValue = "";
            var q = letters.Length;
            for (int i = 0; i < text.Length; i++)
            {
                var letterIndex = letters.IndexOf(text[i]);
                if (letterIndex < 0)
                {
                    retValue += text[i].ToString();
                }
                else
                {
                    if (encrypting == false & letterIndex - i < 0)
                    {
                        int temp = letterIndex - i;
                        while (temp < 0)
                        {
                            temp += q;
                        }
                        retValue += letters[temp % q];
                    }
                    else 
                    {
                        retValue += letters[(letterIndex + (encrypting ? i : -i)) % q];
                    }
                }
            }
            return retValue;
        }
        public string Encrypt(string plainMessage)
            => Trithemius_chip(plainMessage);

        public string Decrypt(string encryptedMessage)
            => Trithemius_chip(encryptedMessage, false);
    }
}
