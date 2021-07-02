using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Vertical_permutation
    {
        const string defaultAlphabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        readonly string letters;
        private int[] key = null;
        readonly Random rnd = new Random();
        public Vertical_permutation(string alphabet = null)
        {
            letters = string.IsNullOrEmpty(alphabet) ? defaultAlphabet : alphabet.ToUpper();
        }

        public void SetKey(string[] _key)
        {
            key = new int[_key.Length];
            if (_key.Length == 1)
            {
                List<int> vList = new List<int>();
                var temp = _key[0].ToUpper();
                var temp_2 = "";
                for (int i = 0; i < temp.Length; i++)
                    vList.Add(letters.IndexOf(temp[i]));
                vList.Sort();
                for (int i = 0; i < temp.Length; i++)
                    for (int j = 0; j < vList.Count; j++)
                        if (vList[j] == letters.IndexOf(temp[i]))
                        {
                            temp_2 += (j + 1).ToString() + " ";
                            break;
                        }
                temp_2 = temp_2.Remove(temp_2.Length - 1);
                Console.WriteLine(temp);
                Console.WriteLine(temp_2);
                SetKey(temp_2);
            }
            else
                for (int i = 0; i < _key.Length; i++)
                    key[i] = Convert.ToInt32(_key[i]);
        }

        public void SetKey(string _key)
        {
            SetKey(_key.Split(' '));
        }

        private string Snake(string text)
        {
            Console.WriteLine("===============");
            string final = "";
            int count = 0;
            for (int i = 0; i < text.Length; i++)
                if (((double)count / (double)key.Length) % 2 == 1)
                {
                    Console.WriteLine();
                    for (int j = key.Length - 1; j >= 0; j--)
                    {
                        try
                        {
                            final += text[i + j].ToString();
                            Console.Write(text[i + j].ToString());
                        }
                        catch (Exception)
                        {
                            Console.Write(" ");
                        }
                    }
                    count = 0;
                    i += key.Length - 1;
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(text[i].ToString());
                    final += text[i];
                    count++;
                }
            Console.WriteLine();
            Console.WriteLine("===============");
            return final;
        }

        public string Encrypt(string input)
        {
            for (int i = 0; i < input.Length % key.Length; i++)
                input += " ";
            input = Snake(input);
            string result = "";
            Console.WriteLine();
            Console.WriteLine("+++ Encrypt +++");
            for (int i = 0; i < input.Length; i += key.Length)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    var temp = input[i + key[j] - 1];
                    result += temp;
                    if (temp != ' ')
                        Console.Write(temp);
                }
                Console.WriteLine();
            }
            Console.WriteLine(result.Replace(" ", ""));
            input = "";
            int rr = result.Length / key.Length;
            for (int i = 0; i < key.Length; i++)
                for (int j = 0; j < rr; j++)
                    input += result[j * key.Length + i];
            input = input.Replace(" ", "");
            Console.WriteLine($"Зашифрованное сообщение -  {input}");
            return input;
        }

        public string Decrypt(string input)
        {
            Console.WriteLine();
            Console.WriteLine("+++ Decrypt +++");
            Console.WriteLine($"Сообщение для расшифровки - {input}");
            Console.WriteLine($"Поиск пустых ячеек...");
            Console.Write("Добавляем пустые в - ");
            string temp = "";
            int rr = input.Length / key.Length;
            int ss = input.Length % key.Length;
            if (rr % 2 == 0)
            {
                int t = 0;
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] < key.Min() + ss)
                    {
                        temp += input.Substring(t, rr + 1);
                        t += rr + 1;
                    }
                    else
                    {
                        temp += input.Substring(t, rr);
                        t += rr;
                        temp += " ";
                        Console.Write($"{key[i]} ");
                    }
                }
            }
            else
            {
                int t = 0;
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] > key.Max() - ss)
                    {
                        temp += input.Substring(t, rr + 1);
                        t += rr + 1;
                    }
                    else
                    {
                        temp += input.Substring(t, rr);
                        t += rr;
                        temp += " ";
                        Console.Write($"{key[i]} ");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Сообщение с добавленными пробелами - {temp}");
            input = temp;
            temp = "";
            rr = input.Length / key.Length;
            for (int i = 0; i < rr; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    temp += input[j * rr + i];
                    Console.Write(input[j * rr + i]);
                }
                Console.WriteLine();
            }
            input = temp;
            string result = "";
            for (int i = 0; i < input.Length; i += key.Length)
            {
                char[] transposition = new char[key.Length];

                for (int j = 0; j < key.Length; j++)
                    transposition[key[j] - 1] = input[i + j];

                for (int j = 0; j < key.Length; j++)
                    result += transposition[j];
            }
            result = Snake(result);
            Console.WriteLine($"Расшифрованное сообщение - {result}");
            return result;
        }
    }
}
