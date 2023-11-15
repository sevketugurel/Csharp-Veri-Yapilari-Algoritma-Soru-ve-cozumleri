using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en_büyük_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[3, 3] {
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8}
            };

            Yaz(x, 0);

            Console.ReadLine();
        }

        public static  int Yaz(int [,] x, int indis,)
        {
            if (indis >= 9) { return 0; }
            int a, b;
            

            a = indis / 3;
            b = indis -a* 3;
            Yaz(x, indis + 1);
            Console.Write(x[a,b]);
            

            if(indis % 3 != 0) {
                return 0;
            }
            Console.WriteLine();
            Console.WriteLine(0);
            return 0;
        }
    }
}
