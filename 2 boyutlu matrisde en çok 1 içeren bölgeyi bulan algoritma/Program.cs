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
            // 2 boyutlu bir matris oluşturuluyor.
            int[,] matrix = new int[,] { { 1, 0, 0, 0, 0, 0, 1, 0, 0, 1 },
                                         { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0 },
                                         { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0 },
                                         { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                                         { 1, 0, 0, 0, 1, 1, 0, 0, 0, 0 },
                                         { 0, 1, 0, 1, 0, 1, 0, 0, 0, 0 },
                                         { 0, 1, 1, 0, 0, 0, 1, 0, 0, 0 },
                                         { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                                         { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                                         { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };

            // En büyük bölge sayısını saklamak için değişkenler tanımlanıyor.
            int maxCount = 0;
            int count = 1;
            int row = 0;
            int col = 0;
            Stack<(int, int)> stack = new Stack<(int, int)>();


            // Matrisin her elemanını kontrol etmek için iki döngü başlatılıyor.
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // Eğer matris elemanı 1 ise işleme başlanıyor.
                    if (matrix[i, j] == 1)
                    {
                        // Bölgenin eleman sayısını saklamak için bir sayaç başlatılıyor.
                        count = 1;

                        // Derinlik öncelikli bir döngü için kullanılacak bir Stack oluşturuluyor.
                        stack.Push((i, j));

                        // Derinlik öncelikli arama başlatılıyor.
                        while (stack.Count > 0)
                        {
                            // Stack'ten bir eleman çekiliyor.
                            (int x, int y) = stack.Pop();

                            // Ziyaret edilen eleman 2 olarak işaretleniyor.
                            matrix[x, y] = 2;

                            // Elemanın çevresindeki diğer 1'leri kontrol etmek için iki iç içe döngü başlatılıyor.
                            // Nasıl geziyoruz ??
                            for (int k = x - 1; k <= x + 1; k++)
                            {
                                for (int l = y - 1; l <= y + 1; l++)
                                {
                                    // Geçerli eleman matris sınırları içinde ve değeri 1 ise işleme devam ediliyor.
                                    if (k >= 0 && k < matrix.GetLength(0) && l >= 0 && l < matrix.GetLength(1) && matrix[k, l] == 1)
                                    {
                                        // Sayaç artırılıyor, bulunan 1 Stack'e ekleniyor ve eleman 2 olarak işaretleniyor.
                                        count++;
                                        stack.Push((k, l));
                                        matrix[k, l] = 2;
                                    }
                                }
                            }
                        }

                        // Eğer bulunan bölge, şu ana kadar bulunan en büyük bölgeden daha büyükse, güncelleniyor.
                        if (count > maxCount)
                        {
                            maxCount = count;
                            row = i;
                            col = j;
                        }
                    }
                }
            }

            // En büyük bölge bilgileri ekrana yazdırılıyor.
            Console.WriteLine("En çok 1 içeren bölge ({0}, {1}) konumunda ve {2} adet 1 içerir.", row, col, maxCount);

        }
    }
}
