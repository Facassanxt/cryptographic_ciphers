using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Final
{
    class Diffie_Hellman
    {
        readonly Random rnd = new Random();
        BigInteger Ya, Yb, SKa, SKb;
        private string Check_Random_Diffie_Hellman(bool random, int? a = null, int? n = null, int? Ka = null, int? Kb = null)
        {
            if (random)
            {
                a = rnd.Next(2, 10000);
                n = rnd.Next((int)(a + 1), (int)(a * 2));
                Ka = rnd.Next(2, (int)(n - 1));
                Kb = rnd.Next(2, (int)(n - 1));
            }
            if (a == null & n == null & Ka == null & Kb == null)
            {
                throw new Exception("Введены не все ключи");
            }
            else
            {
                if (a < 2) throw new Exception("а не может быть меньше 2");
                if (n < a + 1) throw new Exception("n не может быть меньше a");
                if (Ka < 3 || Ka > (n - 1) || Kb < 3 || Kb > (n - 1)) throw new Exception("Ka и Kb случайные числа из интервала (2,..., n-1)");
                Console.WriteLine($"a = {a} n = {n} Ka = {Ka} Kb = {Kb} {Environment.NewLine}");
                Ya = (BigInteger)(BigInteger.Pow((BigInteger)a, (int)Ka) % n);
                Yb = (BigInteger)(BigInteger.Pow((BigInteger)a, (int)Kb) % n);
                SKa = (BigInteger)(BigInteger.Pow(Ya, (int)Kb) % n);
                SKb = (BigInteger)(BigInteger.Pow(Yb, (int)Ka) % n);
                if (SKa == SKb) Console.WriteLine("Успешно");
                Console.WriteLine($"Ya = {Ya} Yb = {Yb} SKa = {SKa} SKb = {SKb} {Environment.NewLine}");
            }
            return $"{a},{n},{Ka},{Kb},{Ya},{Yb},{SKa},{SKb}";
        }
        public string Check_Random(bool random, int ? a = null, int? n = null, int? Ka = null, int? Kb = null) => Check_Random_Diffie_Hellman(random, a, n, Ka, Kb);
    }
}
