using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazaret_sınav_sorusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = toArray(71452345);
            arrayToCiftLinked(dizi);

            Console.ReadLine();
        }
        static int adet = 1;
        static int basamakAdedi(int sayi)
        {
            if (sayi / 10 == 0) return 0;
            adet++;
            basamakAdedi(sayi / 10);
            return adet;
        }
        static int[] sayıDizisi = new int[basamakAdedi(71452345)]; // Diziyi sınıf düzeyinde tanımladım sürekli oluşturmamak için

        private static int[] toArray(int sayı, int i = 0)
        {
            if (sayı == 0)
            {
                return sayıDizisi;
            }

            int kalan = sayı % 10;
            sayıDizisi[i] = kalan;
            toArray(sayı / 10, i + 1);
            return sayıDizisi;
        }
        class ciftLinked
        {
            public int data;
            public ciftLinked next;
            public ciftLinked prev;
        }

        public static void arrayToCiftLinked(int[] arr)
        {
            ciftLinked head = new ciftLinked();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                ciftLinked cl = new ciftLinked();
                cl.data = arr[i];
                cl.next = head;
                head.prev = cl;

                head = cl;

            }

            while (head.next != null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }
        }
    }
}
