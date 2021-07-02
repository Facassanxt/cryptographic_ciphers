using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Numerics;

namespace Task_1
{
    class RSA
    {
        class ElGamal_DS
        {
            const string defaultAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            readonly string letters;
            public ElGamal_DS(string alphabet = null)
            {
                letters = string.IsNullOrEmpty(alphabet) ? defaultAlphabet : alphabet;
            }

            private BigInteger getY(BigInteger g, BigInteger p, BigInteger x) 
            {
                return BigInteger.Pow(g, (int)x) % p;
            }
            private bool isValidate(BigInteger m, BigInteger p, BigInteger g, BigInteger x) 
            {
                BigInteger one = 1;
                if (!p.IsSimple()) return false;
                if (g >= p) return false;
                Console.WriteLine($"Проверка на g < p, g = {g}, p = {p} (Успешно)");
                if (x > p - one || x <= one) return false;
                Console.WriteLine($"Проверка на x < p - 1 || x > 1, x = {x}, p = {p} (Успешно)");
                if (m <= one || m >= p - one) return false;
                Console.WriteLine($"Проверка на hash > 1 || hash < p - 1, hash = {m}, p = {p} (Успешно)");
                return true;
            }
            private BigInteger getK(BigInteger p) 
            {
                var pMinusOne = p - 1;
                BigInteger i = 2;
                while (BigInteger.Compare(i, pMinusOne) == -1)
                {
                    if (BigInteger.Compare(BigInteger.GreatestCommonDivisor(i, pMinusOne), 1) == 0)
                    {
                        return i;
                    }
                    i = BigInteger.Add(i, 1);
                }
                return 0;
            }
            private BigInteger getA(BigInteger g, BigInteger k, BigInteger p)
            {
                return BigInteger.Pow(g, (int)k) % p;
            }
            public void digitalSignature(string text, BigInteger p, BigInteger g, BigInteger x) 
            {
                //var m = text.getHash(letters);
                var m = 9;
                if (!isValidate(m, p, g, x)) return;
                var y = getY(g, p, x);
                BigInteger k = 0;
                while (k == 0)
                {
                    k = getK(p);
                }
                k = 7;
                var a = getA(g, k, p);
                BigInteger one = 1;
                BigInteger b = (m - a * x) * BigInteger.Pow(k, ((int)p - (int)one).euler()-1) % (p - one);
                if (b < 0) b = b + (p - one);
                Console.WriteLine($"p = {p}, g = {g}, y = {y}, x = {x}, hash = {m}");
                Console.WriteLine($"Подпись: ({text},{a},{b})");

                var a1 = BigInteger.Pow(y, (int)a) * (BigInteger.Pow(a, (int)b) % p);
                var a2 = BigInteger.Pow(g, (int)m) % p;
                if (a1 == a2) Console.WriteLine("Проверка подписи: УСПЕШНО;");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("ЭЦП Elgamal на С#");
            Console.WriteLine("Стебло А.С 181-352");
            string alfabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            ElGamal_DS _ElGamal_DS = new ElGamal_DS(alfabet);
            var text = "Не бойся собаки брехливой зпт а бойся молчаливой тчк";
            text = text.ToUpper().Replace(" ", "");
            _ElGamal_DS.digitalSignature(text, 47, 13, 20);
        }
    }
    public static class Extension
    {
        public static bool IsSimple(this BigInteger num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            Console.WriteLine($"Проверка на простоту - {num} (Простое)");
            return num == 1 ? false : true;
        }

        public static BigInteger getHash(this string alphabet, string letters)
        {
            BigInteger h = 0;
            foreach (var s in alphabet)
            {
                var index = letters.IndexOf(s) + 1;
                h = BigInteger.Pow(h + index, 2) % 11;
            }
            return h;
        }

        public static int euler(this int n)
        {
            Console.Write($"Функция Эйлера ({n})");
            int res = n, en = (int)Convert.ToUInt64(Math.Sqrt(n) + 1);
            for (int i = 2; i <= en; i++)
                if ((n % i) == 0)
                {
                    while ((n % i) == 0)
                        n /= i;
                    res -= (res / i);
                }
            if (n > 1) res -= (res / n);
            Console.WriteLine($" = {res}");
            return res;
        }
    }
}
