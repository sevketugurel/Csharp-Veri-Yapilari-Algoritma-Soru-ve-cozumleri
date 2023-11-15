using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_boyutlu_matrisde_en_çok_1_içeren_bölgeyi_bulan_algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { { 1, 0, 0, 0, 0, 0, 1, 0, 0, 1 },
                                         { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0 },
                                         { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0 },
                                         { 0, 0, 0, 0, 0, 0, 1, 0, 0, 1 },
                                         { 1, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                                         { 0, 1, 0, 1, 0, 1, 0, 0, 0, 0 },
                                         { 0, 1, 1, 0, 0, 0, 1, 0, 0, 0 },
                                         { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                                         { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                                         { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
            int maxCount = 0;
            int count = 0;
            int row = 0;
            int col = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        count = 1;
                        Stack<(int, int)> stack = new Stack<(int, int)>();
                        stack.Push((i, j));
                        while (stack.Count > 0)
                        {
                            (int x, int y) = stack.Pop();
                            matrix[x, y] = 2;
                            for (int k = x - 1; k <= x + 1; k++)
                            {
                                for (int l = y - 1; l <= y + 1; l++)
                                {
                                    if (k >= 0 && k < matrix.GetLength(0) && l >= 0 && l < matrix.GetLength(1) && matrix[k, l] == 1)
                                    {
                                        count++;
                                        stack.Push((k, l));
                                        matrix[k, l] = 2;
                                    }
                                }
                            }
                        }
                        if (count > maxCount)
                        {
                            maxCount = count;
                            row = i;
                            col = j;
                        }
                    }
                }
            }
            Console.WriteLine("En çok 1 içeren bölge ({0}, {1}) konumunda ve {2} adet 1 içerir.", row, col, maxCount);

        }
    }
}
