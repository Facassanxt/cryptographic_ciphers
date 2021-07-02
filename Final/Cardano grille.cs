using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Cardano_grille
    {
        readonly int[,] grid = new int[6, 10]
            {
                {0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                {1, 0, 0, 0, 1, 0, 1, 1, 0, 0},
                {0, 1, 0, 0, 0, 1, 0, 0, 0, 1},
                {0, 0, 0, 1, 0, 0, 0, 1, 0, 0},
                {0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 1, 0, 0, 1, 1, 0, 0, 1}
            };
        readonly string[,] buf = new string[6, 10];
        readonly Random rnd = new Random();
        static readonly string alph = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public string EN_De_crypt(string text, bool encrypt)
        {
            int count = 0;
            string rez = "";
            while (text.Length % (grid.GetLength(0) * grid.GetLength(1)) != 0)
                text += alph[rnd.Next(0, alph.Length)];
            for (int k = 0; k < text.Length / (grid.GetLength(0) * grid.GetLength(1)); k++)
            {
                if (!encrypt)
                    for (int i = 0; i < buf.GetLength(0); i++)
                        for (int j = 0; j < buf.GetLength(1); j++, ++count)
                            buf[i, j] = text[count].ToString();
                for (int i = 0; i < grid.GetLength(0); i++)
                    for (int j = 0; j < grid.GetLength(1); j++)
                        if (grid[i, j] == 1)
                            if (encrypt)
                            {
                                buf[i, j] = text[count].ToString();
                                count++;
                            }
                            else
                            {
                                rez += buf[i, j];
                                Console.Write(buf[i, j]);
                            }
                Console.WriteLine();
                for (int i = 0; i < grid.GetLength(0); i++)
                    for (int j = 0; j < grid.GetLength(1); j++)
                        if (grid[grid.GetLength(0) - i - 1, grid.GetLength(1) - j - 1] == 1)
                            if (encrypt)
                            {
                                buf[i, j] = text[count].ToString();
                                count++;
                            }
                            else
                            {
                                rez += buf[i, j];
                                Console.Write(buf[i, j]);
                            }
                Console.WriteLine();
                for (int i = 0; i < grid.GetLength(0); i++)
                    for (int j = 0; j < grid.GetLength(1); j++)
                        if (grid[grid.GetLength(0) - i - 1, j] == 1)
                            if (encrypt)
                            {
                                buf[i, j] = text[count].ToString();
                                count++;
                            }
                            else
                            {
                                rez += buf[i, j];
                                Console.Write(buf[i, j]);
                            }
                Console.WriteLine();
                for (int i = 0; i < grid.GetLength(0); i++)
                    for (int j = 0; j < grid.GetLength(1); j++)
                        if (grid[i, grid.GetLength(1) - j - 1] == 1)
                            if (encrypt)
                            {
                                buf[i, j] = text[count].ToString();
                                count++;
                            }
                            else
                            {
                                rez += buf[i, j];
                                Console.Write(buf[i, j]);
                            }
                Console.WriteLine();
                if (encrypt)
                    for (int i = 0; i < grid.GetLength(0); i++)
                    {
                        for (int j = 0; j < grid.GetLength(1); j++)
                        {
                            rez += buf[i, j];
                            Console.Write(buf[i, j]);
                        }
                        Console.WriteLine();
                    }
                Console.WriteLine("<=============>");
            }
            if (encrypt)
                Console.WriteLine("Зашифрованная фраза: " + rez);
            else
                Console.WriteLine("Расшифрованная фраза: " + rez);
            Console.WriteLine("<-=-=-=-=-=-=->");
            return rez;
        }
    }
}
