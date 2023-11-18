using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iki_diziyi_indisler_yardımıyla_bagli_listeye_cevirme
{
    class Program
    {
        static void Main()
        {
            /*
             * Data ve Link 100 er elemanlı int tipinde  2 dizidir . 
             * Data dizisinde sayılar vardır.Link dizisinde data dizisinin indisleri mevcuttur.
             * Bu sayede link dizisi ile data dizisi arasında bağlı liste yapısı oluşturulmuştur. 
             * bağlı listenin ilk elemanı data dizisinin 70. elemanıdır. bu listenin tüm elemanlarını sırasıyla 
             * ekrana recursive olarak ekrana yazdırın. 70 ten sonra gelecek eleman link[70] il alınacak ve bu şekilde devam edecektir.
             * */

            int[] data = new int[100]; // Veri dizisi
            int[] link = new int[100]; // Bağlantı dizisi

            // Veri dizisine örnek veriler ekleyelim
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i + 1; // Örnek veri olarak dizinin indisini ekliyoruz
            }

            // Bağlantı dizisine örnek bağlantıları ekleyelim
            for (int i = 0; i < link.Length; i++)
            {
                link[i] = (i + 1) % data.Length; // Örnek bağlantı: bir sonraki indis
            }

            int startIndex = 70; // Bağlı listenin başlangıç indisini belirle

            // Bağlı listeyi recursive olarak ekrana yazdır
            bool[] visitedNodes = new bool[data.Length]; // Keep track of visited nodes
            PrintLinkedList(data, link, startIndex, visitedNodes);

            Console.ReadLine();
        }

        static void PrintLinkedList(int[] data, int[] link, int currentIndex, bool[] visitedNodes)
        {
            // Başlangıç indisinden itibaren bağlı listeyi ekrana yazdır
            if (currentIndex != -1 && !visitedNodes[currentIndex])
            {
                Console.WriteLine(data[currentIndex]);

                // Mark the current index as visited
                visitedNodes[currentIndex] = true;

                // Recursive olarak bir sonraki elemanı yazdırmak için fonksiyonu tekrar çağır
                PrintLinkedList(data, link, link[currentIndex], visitedNodes);
            }
        }
    }


}
