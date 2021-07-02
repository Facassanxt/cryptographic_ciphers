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
using System.Drawing;
using System.Text.RegularExpressions;

namespace Task_1
{
    class ECC_MAIN
    {
        class ElectricalCurve
        {
            static Point doublePoint(Point G, BigInteger a, BigInteger p)
            {
                var alf = ((3 * BigInteger.Pow(G.X, 2) + a) * BigInteger.ModPow((2 * G.Y), p - 2, p)).mod(p);
                if (alf < 0) alf += p;
                var x3 = (BigInteger.Pow(alf, 2) - 2 * G.X).mod(p);
                var y3 = ((alf * (G.X - x3)) - G.Y).mod(p);

                if (x3 < 0) x3 += p;
                if (y3 < 0) y3 += p;
                return new Point((int)x3, (int)y3);
            }
            public static Point addPoint(Point alfa, Point G, BigInteger a, BigInteger p)
            {
                if (alfa == G) return doublePoint(alfa, a, p);
                else if (alfa == new Point(0, 0)) return G;
                else if (G == new Point(0, 0)) return alfa;

                var x2 = alfa.X;
                var y2 = alfa.Y;
                var x1 = G.X;
                var y1 = G.Y;

                var alf = ((y2 - y1) * BigInteger.ModPow(x2 - x1, p - 2, p)).mod(p);
                if (alf < 0) alf += p;
                var x3 = (BigInteger.ModPow(alf, 2, p) - x1 - x2).mod(p);
                var y3 = (alf * (x1 - x3) - y1).mod(p);
                if (x3 < 0) x3 += p;
                if (y3 < 0) y3 += p;
                return new Point((int)x3, (int)y3);
            }
            public static Point scalMult(Point G, BigInteger b, BigInteger a, BigInteger p)
            {
                var m = new Point(0, 0);
                var bin = Convert.ToString((int)b, 2);
                bin = bin.Substring(1, bin.Length - 1);
                if (bin.Length <= 0) return G;
                int i = 0;
                foreach (var c in bin)
                {
                    switch (c)
                    {
                        case '1':
                            m = (i == 0) ? addPoint(doublePoint(G, a, p), G, a, p) : addPoint(doublePoint(m, a, p), G, a, p);
                            break;
                        case '0':
                            m = (i == 0) ? doublePoint(G, a, p) : doublePoint(m, a, p);
                            break;
                        default:
                            Console.WriteLine("Default case");
                            break;
                    }
                    i++;
                }
                return m;
            }
        }
        class ECC
        {
            const string defaultAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            readonly string letters;
            BigInteger p,a,b,cb,q;
            Random rnd = new Random();
            Point G;

            public ECC(Point G, BigInteger p, BigInteger a, BigInteger b, BigInteger cb, BigInteger q, string alphabet = null)
            {
                letters = string.IsNullOrEmpty(alphabet) ? defaultAlphabet : alphabet;
                this.G = G;
                this.p = p;
                this.a = a;
                this.b = b;
                this.cb = cb;
                this.q = q;
            }
            public BigInteger genK() => rnd.Next(1, (int)q - 1);
            public Point calcDb(Point G) => ElectricalCurve.scalMult(G,cb,a,p);
            public Point calcR(Point G, BigInteger k) => ElectricalCurve.scalMult(G, k, a, p);
            public Point calcP(Point G, BigInteger k) => ElectricalCurve.scalMult(G, k, a, p);
            public Point calcQ(Point G) => ElectricalCurve.scalMult(G, cb, a, p);
            public BigInteger encrypt(BigInteger m, BigInteger x) => (m * x).mod(p);
            public String encrypt(String text)
            {
                if (!p.IsSimple()) return "Параметры не прошли проверку!";
                var result = "";
                var db = calcDb(G);
                foreach (var s in text)
                {
                    var k = genK();
                    var r = calcR(G,k);
                    var p = calcR(db,k);
                    var e = encrypt((BigInteger)letters.IndexOf(s),p.X);
                    result += $"({r.X},{r.Y}),{e}";
                }
                return result;
            }

            public BigInteger decrypt(BigInteger e, BigInteger x) => (e * BigInteger.ModPow(x, p - 2, p)).mod(p);
            public String decrypt(String text)
            {
                Regex regex = new Regex("\\d+");
                MatchCollection matches = regex.Matches(text);
                var decrypt = "";
                if (matches.Count > 0)
                {

                    for (int i = 0; i < matches.Count; i+=3)
                    {
                        var Q = calcQ(new Point(Convert.ToInt32(matches[i].Value), Convert.ToInt32(matches[i+1].Value)));
                        var d = letters[(int)(new BigInteger(Convert.ToInt32(matches[i + 2].Value)) * (BigInteger.ModPow(Q.X, p - 2, p))).mod(p)];
                        decrypt += d;
                    }
                }
                else
                {
                    Console.WriteLine("Совпадений не найдено");
                }
                return decrypt;
            }
        }

        static void Main(string[] args)
        {
            string alfabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ123456";
            var text = "Не бойся собаки брехливой, а бойся молчаливой.";
            text = text.Replace("-", "тире").Replace(".", "тчк").Replace(",","зпт").Replace(" ", "").ToUpper();
            Point G = new Point(10, 5);
            ECC _ecc = new ECC(G,37,2,6,6,7,alfabet);
            var a = _ecc.encrypt(text);
            Console.WriteLine(a);
            var b = _ecc.decrypt(a);
            Console.WriteLine(b);
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

        public static BigInteger mod(this BigInteger x, BigInteger m)
        {
            BigInteger r = x % m;
            return r < 0 ? r + m : r;
        }
    }
}
