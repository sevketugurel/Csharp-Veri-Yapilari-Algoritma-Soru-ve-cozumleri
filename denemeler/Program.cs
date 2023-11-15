using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemeler
{
    internal class Program
    {
        static int EnBuyukBesinciDeger(int[] dizi)
        {
            if (dizi.Length < 5)
            {
                Console.WriteLine("Dizi yeterince uzun değil.");
                return -1;
            }

            int enKucuk = int.MaxValue;

            foreach (int sayi in dizi)
            {
                if (sayi > enKucuk)
                {
                    enKucuk = sayi;

                    foreach (int eleman in dizi)
                    {
                        if (eleman < enKucuk && eleman > enKucuk)
                        {
                            enKucuk = eleman;
                        }
                    }
                }
            }

            return enKucuk;
        }

        static void Main()
        {
            int[] ornekDizi = { 10, 4, 7, 15, 20, 3, 25, 18, 30, 11 };
            int sonuc = EnBuyukBesinciDeger(ornekDizi);

            Console.WriteLine("En büyük 5. değer: " + sonuc);
            Console.ReadLine();
        }

    }
}
