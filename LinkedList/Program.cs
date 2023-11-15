using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Blockt t1 = new Blockt();
            t1.data = 37;


            Blockt t2 = new Blockt();
            t2.data = 71;

            Blockt t3 = new Blockt();
            t3.data = 48;

            Blockt t4 = new Blockt();
            t4.data = 45;

            t1.next = t2;
            t2.next = t3;
            t3.next = t4;
            t4.next = null;


            Blockt temp = t1;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            // ikinci farklı bir örnek
            Blockt head = null;
            Blockt last = null;
            for (int i = 0; i < 100; i++)
            {
                Blockt b1 = new Blockt();
                b1.data = i + 1;
                if (head == null)
                    head = b1;
                else
                    last.next = b1;

                last = b1;
            }
            linkedyaz(head);
            Console.WriteLine();


            // 3. elemanı bulmak için 3. örnek
            temp = head;
            for (int i = 0; i < 2; i++)
            {
                temp = temp.next;
            }
            Blockt bt = new Blockt();
            bt.data = 123;
            bt.next = temp.next;
            temp.next = bt;

            temp = head;
            linkedyaz(temp);
            Console.ReadKey();
        }
        public class Blockt
        {
            public int data;
            public Blockt next;
        }
        static void linkedyaz(Blockt bt)
        {
            if (bt == null) return;

            Console.WriteLine(bt.data);
            linkedyaz(bt.next);
        }
        public static bool linkedToArr(Blockt bt1,Blockt bt2)
        {
            int pieces = 0;
            while (bt1 != null)
            {
                pieces++;
                bt1 = bt1.next;
            }
            int[] arr = new int[pieces];

            int i = 0;
            while(bt1 != null)
            {
                arr[i] = bt1.data;
                i++;
            }
            //2. LinkedList
            int pieces2 = 0;
            while (bt2 != null)
            {
                pieces2++;
                bt2 = bt2.next;
            }
            int[] arr2 = new int[pieces2];

            int j = 0;
            while (bt2 != null)
            {
                arr2[j] = bt2.data;
                j++;
            }

            return DiziIceriyorMu(arr, arr2); 

        }
        public static bool DiziIceriyorMu(int[] anaDizi, int[] altDizi)
        {
            for (int i = 0; i <= anaDizi.Length - altDizi.Length; i++)
            {
                int j;
                for (j = 0; j < altDizi.Length; j++)
                {
                    if (anaDizi[i + j] != altDizi[j])
                        break;
                }
                if (j == altDizi.Length)
                    return true; // Alt dizi, ana dizinin içinde bulundu
            }
            return false; // Alt dizi, ana dizinin içinde bulunamadı
        }
    }
}
