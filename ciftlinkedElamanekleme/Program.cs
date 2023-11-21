using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çiftli_linked_list_çalışma
{
    class blockt
    {
        public int data;
        public blockt next;
        public blockt prev;
    }
    internal class Program
    {
        static blockt rec(blockt bt)
        {
            if (bt == null) return bt;

            
            if (bt.data == 7)
            {
                if (bt.next != null)
                {
                    blockt first = bt;
                    blockt bt2 = new blockt();
                    bt2.data = 1111;
                    bt2.next = first.next;
                    first.next.prev = bt2;
                    first.next = bt2;
                    bt2.prev = first; // Değiştirildi (bt2.prev = bt2; yerine).
                }
                else
                {
                    blockt first = bt;
                    blockt bt2 = new blockt();
                    bt2.data = 1111;
                    bt2.next = null;   //sadece null değeri atandı 
                    first.next = bt2;
                    bt2.prev = first;

                }

            }

            rec(bt.next); // Düzeltilen yer (bt = rec(bt.next); yerine).

            return bt; // Fonksiyonun geri dönüş değeri güncellendi.
        }

        static void Main(string[] args)
        {
            blockt head = null;
            blockt tail = null;

            

            for (int i = 0; i < 7; i++)
            {
                blockt bt = new blockt();
                bt.data = i + 1;
                if (head == null)
                {
                    head = bt;
                }
                else
                {
                    tail.next = bt;
                    bt.prev = tail;
                }
                tail = bt;
            }
           
            rec(head);

            blockt current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
                
            }

            Console.ReadLine();
        }

    }
}