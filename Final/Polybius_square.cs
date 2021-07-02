using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Polybius_square
    {
        Dictionary<int, char> alfdic = new Dictionary<int, char>(30);
        char[,] alfrus = {  {'А', 'Б', 'В', 'Г', 'Д', 'Е'},
                                {'Ж', 'З', 'И', 'К', 'Л', 'М'},
                                {'Н', 'О', 'П', 'Р', 'С', 'Т'},
                                {'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш'},
                                {'Щ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'}
                             };
        public Polybius_square()
        {
            for (int j = 0; j < alfrus.GetLength(0); j++)
                for (int k = 0; k < alfrus.GetLength(1); k++)
                    alfdic.Add(int.Parse((Convert.ToString(j + 1) + Convert.ToString(k + 1))), alfrus[j, k]);
        }
        public string EncryptText(string message)
        {
            string new_message = "";
            string temp = "";
            for (int i = 0; i < message.Length; i++)
            {
                foreach (KeyValuePair<int, char> keyValue in alfdic)
                    if (keyValue.Value == message[i])
                        temp = keyValue.Key.ToString();
                if (temp == "") new_message += message[i];
                else new_message += temp;
                temp = "";
            }
            return new_message;
        }
        public string DecryptText(string encryptedText)
        {
            string new_message = "";
            for(int i = 0; i < encryptedText.Length; i++)
            {
                try
                {
                    var j = encryptedText[i].ToString(); 
                    var k = encryptedText[i+1].ToString();
                    new_message += alfdic[int.Parse(j+k)];
                    i++;
                }
                catch (Exception)
                {
                    new_message += encryptedText[i];
                }
            }
            return new_message;
        }
    }
}
