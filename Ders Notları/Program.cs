using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_Notları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[,] {
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8}
            };

            Yaz(x, 0);

            Console.ReadLine();
        }

        public static int Yaz(int[,] x, int indis)
        {
            if (indis >= 9) { return 0; }

            int a = indis / 3;
            int b = indis - a*3;
            int max = 0;
            int deger = x[a,b] + Yaz(x, indis+1);
            //Yaz(x, indis + 1);
            //if (max < x[a, b]) { 
            //    max = x[a,b];
            //}
            
            Console.Write(x[a, b]);

            if (indis % 3 != 0)
            {
                return deger;
            }
            Console.WriteLine();
            Console.WriteLine(deger);
            return 0;
            

            
        }
    }

}
