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
                        x[i, j, k] = l;
                        l++;
                    }
                }
            }
            x[3, 4, 5] = 111111111;
            int deger = EnBüyükElemanıBulmak(x);
            Console.WriteLine(deger);
            Console.ReadKey();

        }

        public static int EnBüyükElemanıBulmak(int[,,] dizi, int a = 0, int b = 0, int c = 0)
        {
            int enbüyük = dizi[a, b, c];

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

            if (enbüyük < dizi[a, b, c])
            {
                enbüyük = dizi[a, b, c];
            }

            c++; // Move inside the if statement
            return EnBüyükElemanıBulmak(dizi, a, b, c); // Pass updated values to the recursive call
        }


    }
}
