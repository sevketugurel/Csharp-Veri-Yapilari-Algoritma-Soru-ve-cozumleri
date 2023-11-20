using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3d_dizide_en_büyük_elemanı_bulan_recursive_yapı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] x = new int[5, 10, 20];
            int l = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 20; k++)
                    {
                        x[i, j, k] = 1;
                        l++;
                    }
                }
            }

            x[3, 4, 5] = 1123123;
            int enBuyukDeger = EnBüyükElemanıBulmak(x,0,0,0,x[0,0,0]);
            Console.WriteLine(enBuyukDeger);
            Console.ReadKey();

        }

        public static int EnBüyükElemanıBulmak(int[,,] array, int a, int b, int c, int enbüyük)
        {
            if (c >= 20)
            {
                c = 0;
                b++;

                if (b >= 10)
                {
                    b = 0;
                    a++;

                    if (a >= 5) return enbüyük;
                }
            }

            if (enbüyük < array[a, b, c])
            {
                enbüyük = array[a, b, c];
            }
            c++;
            return EnBüyükElemanıBulmak(array, a, b, c, enbüyük);
        }



    }
}
