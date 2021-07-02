using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Dot
    {
        public Dot(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double x { get; }
        public double y { get; }
    }
    class ECC
    {
        public double p { get; }
        public double a { get; }
        public double b { get; }
        public double cb { get; }

        public ECC(double p, double a, double b, double cb)
        {
            this.p = p;
            this.a = a;
            this.b = b;
            this.cb = cb;
        }
        public Dot alfam(Dot G)
        {
            var alf = (3 * Math.Pow(G.x, 2) + a) * Math.Pow(2 * G.y, p - 2) % p;

            var x3 = (Math.Pow(alf, 2) - 2 * G.x) % p;
            var y3 = ((alf * (G.x - x3)) - G.y) % p;

            if (x3 < 0) x3 += p;
            if (y3 < 0) y3 += p;

            return new Dot(x3, y3);
        }
        // вычисление альфы по формуле сложения
        public Dot alfaP(Dot alfa, Dot G)
        {
            var x2 = alfa.x;
            var y2 = alfa.y;
            var x1 = G.x;
            var y1 = G.y;

            var alf = (y2 - y1) * Math.Pow(x2 - x1, p - 2) % p;

            var x3 = (Math.Pow(alf, 2) - x1 - x2) % p;
            var y3 = (alf * (x1 - x3) - y1) % p;
            if (x3 < 0) x3 += p;
            if (y3 < 0) y3 += p;

            return new Dot(x3, y3);
        }

        private Dot actionSequence(Dot G, double b)
        {
            var m = new Dot(0.0, 0.0);
            var bin = Convert.ToString(Convert.ToInt32(b), 2);
            bin = bin.Substring(1, bin.Length - 1);

            int i = 0;
            foreach (var c in bin)
            {
                switch (c)
                {
                    case '1':
                        m = (i == 0) ? alfaP(alfam(G), G) : alfaP(alfam(m), G);
                        break;
                    case '0':
                        m = (i == 0) ? alfam(G) : alfam(m);
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
                i++;
            }
            return m;
        }
        // Вычисляем открытый ключ Db
        public Dot calcDb(Dot G) => actionSequence(G, cb);
        // Вычисляем точку кривой R = [k]G
        public Dot calcR(Dot G, double k) => actionSequence(G, k);
        // Вычисляем точку кривой P = [k]Db
        public Dot calcP(Dot G, double k) => actionSequence(G, k);
        // Вычисляем точку Q = [Cb]R = (x,y)
        public Dot calcQ(Dot G) => actionSequence(G, cb);
        // Шифровка одной цифры
        public double encrypt(double m, double x) => m * x % p;

        // Расшифровка одной цифры
        public double decrypt(double e, double x) => (e * Math.Pow(x, p - 2)) % p;
    }
}
