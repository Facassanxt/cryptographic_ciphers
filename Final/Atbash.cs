using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Atbash
    {
        private const string alphabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private string Reverse(string inputText)
        {
            var reversedText = string.Empty;
            foreach (var s in inputText)
            {
                reversedText = s + reversedText;
            }
            return reversedText;
        }
        private string EncryptDecrypt(string text, string symbols, string cipher)
        {
            var outputText = string.Empty;
            for (var i = 0; i < text.Length; i++)
            {
                var index = symbols.IndexOf(text[i]);
                if (index >= 0)
                {
                    outputText += cipher[index].ToString();
                }
                else
                {
                    outputText += text[i].ToString();
                }
            }
            return outputText;
        }
        public string EncryptText(string plainText)
        {
            return EncryptDecrypt(plainText, alphabet, Reverse(alphabet));
        }
        public string DecryptText(string encryptedText)
        {
            return EncryptDecrypt(encryptedText, Reverse(alphabet), alphabet);
        }
    }
}
