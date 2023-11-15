using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tek_döngüde_5_boyutlu_dizi_gezmek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,,,] x = new int[3,4,5,6,7];
            

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    for (int k = 0; k < x.GetLength(2); k++)
                    {
                        for (int l = 0; l < x.GetLength(3); l++)
                        {
                            for (int m = 0; m < x.GetLength(4); m++)
                            {
                                x[i, j, k, l, m] = i + j + k + l + m; // Örnek olarak elemanlara toplam değeri atıyorum
                            }
                        }
                    }
                }
            }

            x[3, 4, 5, 6, 7] = 1111111111;

            int a, b, c, d, e;
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            e = 0;

            int enBüyük = x[0, 0, 0, 0, 0];

            //int[,,,,] x = new int[3,4,5,6,7];
            

            while (a < 2)
            {
                e++;
                if (e >= 7 )
                {
                    e = 0;
                    d++;
                    if(d >= 6)
                    {
                        d=0;
                        c++;
                        if(c >= 5)
                        {
                            c=0;
                            b++;
                            if(b >= 4)
                            {
                                b=0;
                                a++;
                                


                            }
                        }
                    }
                                        
                }
                
                if (x[a,b,c,d,e] > enBüyük) enBüyük = x[a, b, c, d, e]; 
            }
            Console.WriteLine(enBüyük);
            Console.ReadKey();
        }
    }
}
