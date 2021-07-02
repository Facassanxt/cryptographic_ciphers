using System;
using System.Collections.Generic;
using System.Linq;

namespace Final
{
    class Playfer
    {
        string Alphabet { get; set; }
        string KeyWord { get; set; }
        public Playfer(string Alphabet, string KeyWord)
        {
            this.KeyWord = string.Join("",KeyWord.ToLower().Replace("й", "и").Replace("ё", "е").Replace("ъ", "ь").Replace(" ", "").Distinct());
            this.Alphabet = Alphabet.ToLower().Replace("й", "и").Replace("ё", "").Replace(" ", "").Replace("ъ", "ь");
        }
        public string Encrypt(string Message)
        {
            Func<string[,], int[], int[], string> getPair = GetPairForCrypt;
            return CryptOrUncrypt(Message, getPair);
        }
        public string Decrypt(string Message)
        {
            Func<string[,], int[], int[], string> getPair = GetPairForUncrypt;
            return CryptOrUncrypt(Message, getPair);
        }
        string CryptOrUncrypt(string Message, Func<string[,], int[], int[], string> GetPair)
        {
            var alphMatrix = CreateAlphMatrix();
            var bigrams = CreateBigrams(Message);
            var returnMessage = "";
            var fIndex = new int[] { 0, 0 };
            var sIndex = new int[] { 0, 0 };
            foreach (var bi in bigrams)
            {
                fIndex = GetIndex(alphMatrix, bi.FirstLetter);
                sIndex = GetIndex(alphMatrix, bi.SecondLetter);
                returnMessage += GetPair(alphMatrix, fIndex, sIndex);
            }
            return returnMessage;
        }
        string GetPairForUncrypt(string[,] AplhMatrix, int[] FirstLetterIndexs, int[] SecondLetterIndexs)
        {
            string pair = "";
            if (FirstLetterIndexs[0] == SecondLetterIndexs[0])
            {
                pair += AplhMatrix[FirstLetterIndexs[0],((FirstLetterIndexs[1] - 1 + AplhMatrix.GetLength(1)) % AplhMatrix.GetLength(1))];
                pair += AplhMatrix[SecondLetterIndexs[0],((SecondLetterIndexs[1] - 1 + AplhMatrix.GetLength(1)) % AplhMatrix.GetLength(1))];
            }
            else if (FirstLetterIndexs[1] == SecondLetterIndexs[1])
            {
                pair += AplhMatrix[((FirstLetterIndexs[0] - 1 + AplhMatrix.GetLength(0)) % AplhMatrix.GetLength(0)),FirstLetterIndexs[1]];
                pair += AplhMatrix[((SecondLetterIndexs[0] - 1 + AplhMatrix.GetLength(0)) % AplhMatrix.GetLength(0)),SecondLetterIndexs[1]];
            }
            else
            {
                pair += AplhMatrix[FirstLetterIndexs[0],SecondLetterIndexs[1]];
                pair += AplhMatrix[SecondLetterIndexs[0],FirstLetterIndexs[1]];
            }
            return pair;
        }
        string GetPairForCrypt(string[,] AplhMatrix, int[] FirstLetterIndexs, int[] SecondLetterIndexs)
        {
            string pair = "";
            if (FirstLetterIndexs[0] == SecondLetterIndexs[0])
            {
                pair += AplhMatrix[FirstLetterIndexs[0],((FirstLetterIndexs[1] + 1) % AplhMatrix.GetLength(1))];
                pair += AplhMatrix[SecondLetterIndexs[0],((SecondLetterIndexs[1] + 1) % AplhMatrix.GetLength(1))];
            }
            else if (FirstLetterIndexs[1] == SecondLetterIndexs[1])
            {
                pair += AplhMatrix[((FirstLetterIndexs[0] + 1) % AplhMatrix.GetLength(0)),FirstLetterIndexs[1]];
                pair += AplhMatrix[((SecondLetterIndexs[0] + 1) % AplhMatrix.GetLength(0)),SecondLetterIndexs[1]];
            }
            else
            {
                pair += AplhMatrix[FirstLetterIndexs[0],SecondLetterIndexs[1]];
                pair += AplhMatrix[SecondLetterIndexs[0],FirstLetterIndexs[1]];
            }
            return pair;
        }
        int[] GetIndex(string[,] matrix, string Letter)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] == Letter)
                        return new int[] { i, j };
            throw new Exception();
        }
        IEnumerable<Bigram> CreateBigrams(string normalMessage)
        {
            normalMessage = normalMessage.ToLower().Replace("й", "и").Replace("ё", "е").Replace("ь", "ь").Replace(" ", "");
            var temp = new List<Bigram>();
            for (int i = 0; i < normalMessage.Length; i += 2)
            {
                if (i == normalMessage.Length - 1)
                {
                    temp.Add(new Bigram()
                    {
                        FirstLetter = normalMessage[i].ToString(),
                        SecondLetter = "х"
                    });
                }
                else if (normalMessage[i] == normalMessage[i + 1])
                {
                    temp.Add(new Bigram()
                    {
                        FirstLetter = normalMessage[i].ToString(),
                        SecondLetter = "х"
                    });
                    i--;
                }
                else
                {
                    temp.Add(new Bigram()
                    {
                        FirstLetter = normalMessage[i].ToString(),
                        SecondLetter = normalMessage[i + 1].ToString()
                    });
                }
            }
            return temp;
        }
        string[,] CreateAlphMatrix()
        {
            var let = (KeyWord + Alphabet).Select(x => x.ToString()).Distinct().ToArray();
            var alphMatrix = new string[5, 6];
            var temp_index = 0;
            for (int i = 0; i < alphMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < alphMatrix.GetLength(1); j++)
                {
                    alphMatrix[i, j] = let[temp_index];
                    Console.Write(alphMatrix[i, j] + " ");
                    temp_index++;
                }
                Console.WriteLine("");
            }
            return alphMatrix;
        }
    }
    class Bigram
    {
        public string FirstLetter { get; set; }
        public string SecondLetter { get; set; }
        public override string ToString()
        {
            return FirstLetter + " " + SecondLetter;
        }
    }
}