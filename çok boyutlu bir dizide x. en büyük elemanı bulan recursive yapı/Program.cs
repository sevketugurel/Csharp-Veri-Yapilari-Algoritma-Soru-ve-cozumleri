using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çok_boyutlu_bir_dizide_x.en_büyük_elemanı_bulan_recursive_yapı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int columns = 4;

            Stack<int> stack = new Stack<int>();

            // Create a 2D array
            int[,] dizi = new int[rows, columns];
            int l = 0;
            // Populate the 2D array with some data
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Assign values to the elements of the array
                    dizi[i, j] = l;
                    l++;
                }
            }

            XinciEnBüyük(dizi, stack, dizi[0, 0], 0);


            Console.WriteLine("kaçıncı en büyük elemanı bulmak istiyorsun?");
            int sıra = int.Parse(Console.ReadLine());

            int stackcount = stack.Count;
            int istenenSıraDegeri = stackcount - sıra;
            int deger = 0;

            if(dizi.GetLength(0)*dizi.GetLength(1) > sıra)
            {
                while (stack.Count > istenenSıraDegeri)
                {
                    deger = stack.Pop();
                }

                Console.WriteLine("İstedğiniz en büyük x. eleman: " + deger);
            }
            else Console.WriteLine("sıran dizin sınırları dışında!!!");


        }
        static Stack<int> XinciEnBüyük(int[,] dizi, Stack<int> stack, int enBüyük, int indis)
        {
            int a, b;

            // boyutlara böldük
            a = indis / dizi.GetLength(1);
            b = indis % dizi.GetLength(1);

            if (a >= dizi.GetLength(0)) return stack;

            if (dizi[a, b] > enBüyük)
            {
                enBüyük = dizi[a, b];
                stack.Push(enBüyük);
            }

            indis++;
            return XinciEnBüyük(dizi, stack, enBüyük, indis);
        }
    }
}
