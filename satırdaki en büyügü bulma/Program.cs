using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satırdaki_en_büyügü_bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[3,3] {
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8}
            };

            Yaz(x, 0,0);

            Console.ReadLine();
        }
        public static int Yaz(int[,] x, int indis,int eb)
        {
            if (indis >= 9) return 0;
            int a, b;
            a = indis / 3;
            b = indis - a * 3;
            int deger = 0;
            deger = Yaz(x, indis + 1, eb);
            Console.Write(x[a, b]);
            if (x[a, b] > deger) deger = x[a, b];

            if (indis % 3 != 0)
            {
                if (eb > deger) deger = eb;
                else eb = deger;
                return deger;
            }
            Console.WriteLine();
            Console.WriteLine(deger);
            return 0;
        }
    }
}
