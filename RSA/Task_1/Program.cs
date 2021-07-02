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
        class RSAKeyGenerator 
        {
            public RSAKeyGenerator(BigInteger p, BigInteger q)
            {
                n = BigInteger.Multiply(p, q);
                //n = 85;
                eulerF = BigInteger.Multiply(BigInteger.Subtract(p, 1), BigInteger.Subtract(q, 1));
                d = BigInteger.ModPow(e, n - 2, eulerF);
                //d = 55;
            }

            public BigInteger n { get; }
            public BigInteger eulerF { get; }
            public BigInteger d { get; }

            public BigInteger e 
            { 
                get 
                {
                    //return 7;
                    BigInteger i = 2;
                    while (BigInteger.Compare(i, eulerF) == -1)
                    {
                        if (BigInteger.Compare(BigInteger.GreatestCommonDivisor(i, eulerF), 1) == 0)
                        {
                            return i;
                        }
                        i = BigInteger.Add(i, 1);
                    }
                    return 0;
                } 
            }
            public BigInteger r
            {
                get
                {
                    BigInteger i = 2;
                    while (BigInteger.Compare(i, eulerF) == -1)
                    {
                        if (BigInteger.Compare(BigInteger.GreatestCommonDivisor(i, n), 1) == 0)
                        {
                            return i;
                        }
                        i = BigInteger.Add(i, 1);
                    }
                    return 0;
                }
            }
        }
        class RSA_DS
        {
            const string defaultAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            readonly string letters;
            public RSA_DS(string alphabet = null)
            {
                letters = string.IsNullOrEmpty(alphabet) ? defaultAlphabet : alphabet;
            }
            public void digitalSignature(string text, BigInteger p, BigInteger q)
            {
                if (!isValidate(p, q)) return;
                var keyGen = new RSAKeyGenerator(p, q);
                Console.WriteLine($"Открытый ключ: ({keyGen.n},{keyGen.n})");
                Console.WriteLine($"Закрытый ключ: ({keyGen.d},{keyGen.n})");
                var hash = text.getHash(letters);

                var s = BigInteger.Pow(hash, (int)keyGen.d) % keyGen.n;
                Console.WriteLine($"n = {keyGen.n}, d = {keyGen.d}, q = {q}, p = {p}, s = {s}, hash = {hash}");
                isSuccessRSADS(keyGen.e, s, keyGen.n, hash);
            }
            private bool isSuccessRSADS(BigInteger e, BigInteger s, BigInteger p, BigInteger hash)
            {
                var h = BigInteger.Pow(s, (int)e) % p;
                if (h == hash)
                {
                    Console.WriteLine($"Подпись: {s}");
                    Console.WriteLine($"Проверка подписи: УСПЕШНО");
                    return true;
                }
                else 
                {
                    Console.WriteLine($"Проверка подписи: НЕУДАЧА");
                    return false;
                }
            }

            private bool isValidate(BigInteger a, BigInteger b)
            {
                if (!a.IsSimple()) return false;
                if (!b.IsSimple()) return false;
                return true;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("ЭЦП RSA на С#");
            Console.WriteLine("Стебло А.С 181-352");
            string alfabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            RSA_DS _RSA_DS = new RSA_DS(alfabet);
            var text = "чтозптможетбытьзптвысшаядоблестьвжизнитиреименноуметьдержатьсебявкулакетчкименноумениевладетьсобойестьпризнакнедюжиннойзптувереннойвсебенатурытчкверавздравыйсмыслколлективаиответственностьзасудьбылюдейтиревотчтостоитсегоднязаспокойствиемюриявикентьевичатчкхотягдетиретопросебяонзптконечнозптволнуетсяипереживаеттчконпереживаетзптконечнотчквитькаразмышлялиобэтомнаспехираздерганнозптмыслиегопришливсмятениезптголосюриявикентьевичадоходилдосознанияужзаторможеннозптприглушеннозптсквозилавнемдружескаядоверительностьтчкдавайтетакзптбудтовамтридцатьшестьзптамневосемнадцатьтчкнетзптдавайтелучшеотойдемотвозраставообщеипосмотримнавещиоднимиглазамизптсоднимитемжезптобразноговорязптфокуснымрасстояниемтчктаквоттчкстаниславобладаетзавиднымипознаниямитиреправдазптонихпочемутиретонеуспелвжизнипристроитькделузптноэторазговордругойтчкониопытнейнаспростотиренапростотчкжизнеспособнейтчкнаконецзптчистосердечнопосчитайтезптсколькостаниславсделалнамхорошеготчктчктчкптзогч";
            text = text.ToUpper().Replace(" ", "");
            _RSA_DS.digitalSignature(text, 13, 19);
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
                h = BigInteger.Pow(h + index, 2) % 13;
            }
            return h;
        }
    }
}
