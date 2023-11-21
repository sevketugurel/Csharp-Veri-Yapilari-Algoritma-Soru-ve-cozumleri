using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace döngüsüz_5_boyutlu_dizide_en_büyük_bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,,,] dizi = new int[3,4,5,6,7];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        for (int l = 0; l < 6; l++)
                        {
                            for (int m = 0; m < 7; m++)
                            {
                                dizi[i,j,k,l,m] = 1 ;
                            }
                        }
                    }
                }
            }
            dizi[2, 3, 2, 1, 1] = 1111;
            Console.WriteLine(FindMax(dizi, 0, dizi[0,0,0,0,0]));
            Console.ReadKey();  
        }
        public static int FindMax(int[,,,,] array, int indis, int max)
        {
            int a, b, c, d, e;
            a = indis / 840;
            b = (indis - a * 840) / 210;
            c = (indis - b * 210 - a * 840) / 42;
            d = (indis - c * 42 - b * 210 - a * 840) / 7;
            e = indis % 7;

            if (indis>=840*3) return max;

            if (array[a, b, c, d, e] > max)
            {
                max = array[a, b, c, d, e];
            }

            return FindMax(array, indis + 1, max);
        }

    }
}
