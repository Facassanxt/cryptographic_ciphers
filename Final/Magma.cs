using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final
{
    class Magma
    {
        static string[,] sBlocks = new string[8,16] 
            {
                {"12","4","6","2","10","5","11","9","14","8","13","7","0","3","15","1"},
                {"6","8","2","3","9","10","5","12","1","14","4","7","11","13","0","15"},
                {"11","3","5","8","2","15","10","13","14","1","7","4","12","9","6","0"},
                {"12","8","2","1","13","4","15","6","7","0","10","5","3","14","9","11"},
                {"7","15","5","10","8","1","6","13","0","9","3","14","11","4","2","12"},
                {"5","13","15","6","9","2","12","10","11","7","8","1","4","3","14","0"},
                {"8","14","2","5","6","9","1","12","15","4","11","0","13","10","3","7"},
                {"1","7","14","13","0","5","8","3","4","15","10","6","9","12","11","2"}
            };
        public Magma()
        {

        }

        private string block32shl11(string bin)
        {
            string reversBin = "";
            var collection = bin.prettyString(32, " ").Split(' ');
            foreach (var item in collection)
                reversBin += item.shlString(11);
            return reversBin;
        }
        private string getResult(string bin)
        {
            string result = "";
            var collection = bin.prettyString(16, " ").Split(' ');
            foreach (var item in collection)
                result += Convert.ToChar(Convert.ToInt32(item, 2)).ToString();
            return result;
        }

        public string decryptText(string text)
        {
            var bin = text.binaryUnicodeToString();
            var block32 = bin.prettyString(32, " ").Split(' ');
            var resultBin = "";
            foreach (var item in block32)
            {
                var block4 = item.shrString(11).prettyString(4, " ").Split(' ');
                for (int i = 0; i < block4.Length; i++)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        if (Convert.ToInt32(sBlocks[i, j]) == Convert.ToInt32(block4[i], 2))
                        {
                            var rep = 4 - Convert.ToString(j, 2).Length;
                            resultBin += string.Concat(Enumerable.Repeat("0", rep)) + Convert.ToString(j, 2);
                            break;
                        }
                    }
                }
            }
            return getResult(resultBin);
        }

        public string encryptText(string text)
        {
            var bin = text.binaryUnicodeToString();
            var block32 = bin.prettyString(32, " ").Split(' ');
            var resultBin = "";
            foreach (var item in block32)
            {
                var block4 = item.prettyString(4, " ").Split(' ');
                for (int i = 0; i < block4.Length; i++)
                {
                    var tmp = Convert.ToString(Convert.ToInt32(sBlocks[i, Convert.ToInt32(block4[i], 2)]),2);
                    var rep = 4 - tmp.Length;
                    resultBin += string.Concat(Enumerable.Repeat("0", rep)) + tmp;
                }
            }
            return getResult(block32shl11(resultBin));
        }
    }
}

public static class StringExtension
{
    public static string prettyString(this string str, int blockSize, string separator)
    {
        int index = 0;
        string result = "";
        while (index < str.Length)
        {
            try
            {
                result += str.Substring(index, blockSize) + " ";
                index += blockSize;
            }
            catch (Exception)
            {
                result += str.Substring(index, str.Length - index) + " ";
                index += blockSize;
            }
        }
        return result.Remove(result.Length-1);
    }
    public static string binaryUnicodeToString(this string str)
    {
        string bin = "";
        foreach (var item in str)
        {
            var c = Convert.ToString(Convert.ToInt32(item), 2);
            var rep = 16 - c.Length;
            bin += string.Concat(Enumerable.Repeat("0", rep)) + c;
        }
        return bin;
    }
    public static string shlString(this string str, int num)
    {
        return str.Substring(num, str.Length - num) + str.Substring(0, num);
    }
    public static string shrString(this string str, int num)
    {
        return str.Substring(str.Length - num, num) + str.Substring(0, str.Length - num);
    }
}
