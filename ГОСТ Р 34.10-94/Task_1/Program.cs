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
        class DSGOST341094
        {
            public DSGOST341094(BigInteger r, BigInteger s)
            {
                this.R = r;
                this.S = s;
            }

            public BigInteger R { get; }
            public BigInteger S { get; }
        }
        class GOST341094
        {
            private readonly BigInteger p, q, a;
            BigInteger x, k;
            readonly Random rnd;
            public GOST341094(BigInteger p, BigInteger q, BigInteger a)
            {
                rnd = new Random();
                this.p = p;
                this.q = q;
                this.a = a;
            }
            private bool IsValidate() 
            {
                var pMinusOne = p - 1;
                if (!p.IsSimple()) return false;
                if (!q.IsSimple()) return false;
                if (TdFactors(pMinusOne).IndexOf(q) == -1) return false;
                if (a <= 1 || a >= pMinusOne || BigInteger.ModPow(a, q, p) != 1) return false;
                Console.WriteLine($"{a} > {1} - Верно");
                Console.WriteLine($"{a} < {pMinusOne} - Верно");
                Console.WriteLine($"{a}^{q} mod {p} = {1} - Верно");
                if (x >= q) return false;
                Console.WriteLine($"{x} < {q} - Верно");
                return true;
            }
            private BigInteger GenK() 
            {
                BigInteger result = rnd.Next(1, (int)q);
                return result;
            }
            public BigInteger GenY(BigInteger x) 
            {
                var result = BigInteger.ModPow(a, x, p) % p;
                return result;
            }
            public bool CheckSignature(DSGOST341094 sign, BigInteger hash, BigInteger y) 
            {
                Console.WriteLine();
                Console.WriteLine($"====> Проверка <====");
                BigInteger h = hash;
                if ((h % q).Equals(0))
                {
                    h = 0;
                }
                var v = BigInteger.ModPow(h, BigInteger.Subtract(q, 2), q);
                Console.WriteLine($"v = m^(q-2) mod q = {h}^({q}-{2}) mod {q} = {v}");
                var z1 = BigInteger.Multiply(sign.S, v) % q;
                Console.WriteLine($"z1 = s * v mod q = {sign.S} * {v} mod {q} = {z1}");
                var z2 = BigInteger.Multiply(BigInteger.Subtract(q, sign.R), v) % q;
                Console.WriteLine($"z2 = (q - r) * v mod q = ({q} - {sign.R}) * {v} mod {q} = {z2}");
                var u = BigInteger.Multiply(BigInteger.ModPow(a, z1, p), BigInteger.ModPow(y, z2, p)) % p % q;
                Console.WriteLine($"u = a^z1 * y^z2 mod p mod q = {a}^{z1} * {y}^{z2} mod {p} mod {q} = {u}");
                return u == sign.R;
            }
            public DSGOST341094 DigitalSignature(BigInteger hash, BigInteger x) 
            {
                this.x = x;
                BigInteger h = hash;
                if ((h % q).Equals(0)) 
                {
                    h = 0;
                }
                if (!IsValidate()) return null;
                BigInteger r;
                do
                {
                    k = GenK();
                    r = (BigInteger.ModPow(a, k, p) % p % q);
                } while (r == 0);

                if (r == 0) return null;
                var s = BigInteger.Add(BigInteger.Multiply(x, r), BigInteger.Multiply(k, h)) % q;
                Console.WriteLine($"p={p}; q={q}; a={a}; x={x}; k={k}; hash={h}");
                DSGOST341094 sign = new DSGOST341094(r,s);
                return sign;
            }
            private List<BigInteger> TdFactors(BigInteger N)
            {
                var n = N;
                BigInteger two = 2;
                List <BigInteger> fs = new List<BigInteger>();


                while ((n % two) == 0)
                {
                    fs.Add(two);
                    n = BigInteger.Divide(n,two);
                }
                if (BigInteger.Compare(n,1) > 0)
                {
                    BigInteger f = 3;
                    while (BigInteger.Compare(BigInteger.Multiply(f,f),n) <= 0)
                    {
                        if ((n % f) == 0)
                        {
                            fs.Add(f);
                            n = BigInteger.Divide(n, two);
                        }
                        else 
                        {
                            f += two;
                        }
                    }
                    fs.Add(n);
                }
                return fs;
            }
        }

        static void Main(string[] args)
        {
            BigInteger p = 863;
            BigInteger q = 431;
            BigInteger a = 3;
            BigInteger x = 378;
            Console.WriteLine("GOST341094 на С#");
            Console.WriteLine("Стебло А.С 181-352");
            string alfabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

            GOST341094 _GOST341094 = new GOST341094(p, q, a);
            var text = "";
            Console.WriteLine(text);
            text = text.ToUpper().Replace(" ", "").Replace(",", "зпт").Replace(".", "тчк");
            var hash = text.GetHash(alfabet);
            hash = 4;
            var sign = _GOST341094.DigitalSignature(hash, x);
            Console.WriteLine($"Подпись = ({sign.R},{sign.S})");
            Console.WriteLine($"Подпись - {_GOST341094.CheckSignature(sign, hash, _GOST341094.GenY(x))}");
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
            return num != 1;
        }

        public static BigInteger GetHash(this string alphabet, string letters)
        {
            BigInteger h = 0;
            foreach (var s in alphabet)
            {
                var index = letters.IndexOf(s) + 1;
                h = BigInteger.Pow(h + index, 2) % 11;
            }
            return h;
        }

        public static int Euler(this int n)
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
