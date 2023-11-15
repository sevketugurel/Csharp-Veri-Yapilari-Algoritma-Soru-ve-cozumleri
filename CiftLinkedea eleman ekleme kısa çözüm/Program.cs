using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftLinkedea_eleman_ekleme_kısa_çözüm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi = 7524;

            //int birler;
            //birler = sayi % 10;
            //sayi /= 10;

            //CiftLinked tail = new CiftLinked();

            //CiftLinked head = new CiftLinked();
            //head.data = birler;
            //head.next = tail;
            //tail.next = head;

            //while (sayi > 0)
            //{

            //    birler = sayi % 10;
            //    CiftLinked cl = new CiftLinked();
            //    tail.data = birler;
            //    tail.next = cl;
            //    cl.prev = tail;
            //    tail = cl;

            //    sayi /= 10;

            //}
            //while (head.next != null)
            //{
            //    Console.WriteLine(head.data);
            //    head = head.next;
            //}


            ikinciCozum();

            Console.ReadLine();
            
        }
        class CiftLinked
        {
            public int data;
            public CiftLinked next;
            public CiftLinked prev;

        }
        public static void ikinciCozum()
        {
            int sayi = 714356452;
            int birler;

            CiftLinked head = new CiftLinked();
            CiftLinked temp = head;


            while (sayi > 0)
            {
                temp.next = new CiftLinked();
                
                birler = sayi % 10;

                temp.data = birler;
                temp.next.prev = temp;
                temp = temp.next;

                sayi /=10;
            }
            while (head.next != null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }
            Console.ReadLine();
        }
    }
}
