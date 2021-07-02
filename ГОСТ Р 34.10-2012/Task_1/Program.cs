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

namespace Task_1
{
    class RSA
    {
        class ElectricalCurve
        {
            static Point doublePoint(Point G, BigInteger a, BigInteger p) 
            {
                var alf = ((3 * BigInteger.Pow(G.X,2) + a) * BigInteger.ModPow((2 * G.Y),p - 2,p)).mod(p);
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
        class GOST34102012
        {
            public BigInteger p, a, q, b, xa, k;
            public GOST34102012(BigInteger p, BigInteger a, BigInteger b, BigInteger xa, string alphabet)
            {
                this.q = 7;
                this.p = p;
                this.a = a;
                this.b = b;
                this.xa = xa;

            }
            public Point calcYa(Point G) 
            {
                var result = ElectricalCurve.scalMult(G, xa, a, p);
                return result;
            }
            public Point calcP(Point G, BigInteger k)
            {
                var result = ElectricalCurve.scalMult(G, k, a, p);
                return result;
            }
            public BigInteger rCalculate(BigInteger x)
            {
                var result = x.mod(q);
                return result;
            }
            public BigInteger sCalculate(BigInteger h, BigInteger k, BigInteger r)
            {
                var result = (k * h + r * xa).mod(q);
                return result;
            }
            public void checkSignature(Point G, Point ya, BigInteger s, BigInteger h, BigInteger r) 
            {

                var hPowMinusOne = ((int)q).Euler() - 1;
                var v = BigInteger.ModPow(h, hPowMinusOne, q);
                var u1 = (s * v).mod(q);
                if (u1 < 0) u1 += q;
                var u2 = (-(r * v)).mod(q);
                if (u2 < 0) u2 += q;

                Console.WriteLine($"u1 = {u1}, u2 = {u2}");

                var p1 = ElectricalCurve.scalMult(G, u1, a, p);
                var p2 = ElectricalCurve.scalMult(ya, u2, a, p);
                var dot = ElectricalCurve.addPoint(p1, p2, a, p);

                Console.WriteLine($"Точка = {dot}");
                var check = ((BigInteger)dot.X).mod(q);
                Console.WriteLine($"Проверка подписи: X mod q = {dot.X} mod {q} = {check}");
                if (check == r) Console.WriteLine($"Проверка подписи: {check} = {r} УСПЕШНО;");
                else Console.WriteLine("Проверка подписи: {check} != {r} НЕУДАЧА;");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("GOST34102012 на С#");
            Console.WriteLine("Стебло А.С 181-352");
            string alfabet = "АБВГДЕЖЗИКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            var G = new Point(0,1);
            BigInteger k = 5;
            var text = "чтозптможетбытьзптвысшаядоблестьвжизнитиреименноуметьдержатьсебявкулакетчкименноумениевладетьсобойестьпризнакнедюжиннойзптувереннойвсебенатурытчкверавздравыйсмыслколлективаиответственностьзасудьбылюдейтиревотчтостоитсегоднязаспокойствиемюриявикентьевичатчкхотягдетиретопросебяонзптконечнозптволнуетсяипереживаеттчконпереживаетзптконечнотчквитькаразмышлялиобэтомнаспехираздерганнозптмыслиегопришливсмятениезптголосюриявикентьевичадоходилдосознанияужзаторможеннозптприглушеннозптсквозилавнемдружескаядоверительностьтчкдавайтетакзптбудтовамтридцатьшестьзптамневосемнадцатьтчкнетзптдавайтелучшеотойдемотвозраставообщеипосмотримнавещиоднимиглазамизптсоднимитемжезптобразноговорязптфокуснымрасстояниемтчктаквоттчкстаниславобладаетзавиднымипознаниямитиреправдазптонихпочемутиретонеуспелвжизнипристроитькделузптноэторазговордругойтчкониопытнейнаспростотиренапростотчкжизнеспособнейтчкнаконецзптчистосердечнопосчитайтезптсколькостаниславсделалнамхорошеготчктчктчкаылвбь";
            Console.WriteLine(text);
            text = text.ToUpper().Replace(" ", "").Replace(",", "зпт").Replace(".", "тчк");
            BigInteger h = 9;
            h = text.GetHash(text);
            GOST34102012 _GOST34102012 = new GOST34102012(37, 1, 1, 4, alfabet);
            Console.WriteLine($"p = {_GOST34102012.p}, a = {_GOST34102012.a}, b = {_GOST34102012.b}, xa = {_GOST34102012.xa}, k = {k}, h = {h}");
            var ya = _GOST34102012.calcYa(G);
            Console.WriteLine($"Открытый ключ Ya = [{_GOST34102012.xa}] G = ({G.X},{G.Y})");

            var p = _GOST34102012.calcP(G, k);
            Console.WriteLine($"Точка кривой P = [{k}] G = ({ya.X},{ya.Y})");

            var r = _GOST34102012.rCalculate(p.X);
            var s = _GOST34102012.sCalculate(h, k, r);
            if (s == 0) return;
            Console.WriteLine($"r = {r}; s = {s}");
            Console.WriteLine($"Подпись - ({r},{s})");

            _GOST34102012.checkSignature(G, ya, s, h, r);
        }
    }
    public static class Extension
    {
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
            int res = n, en = (int)Convert.ToUInt64(Math.Sqrt(n) + 1);
            for (int i = 2; i <= en; i++)
                if ((n % i) == 0)
                {
                    while ((n % i) == 0)
                        n /= i;
                    res -= (res / i);
                }
            if (n > 1) res -= (res / n);
            return res;
        }
        public static BigInteger mod(this BigInteger x, BigInteger m)
        {
            BigInteger r = x % m;
            return r < 0 ? r + m : r;
        }
    }
}
