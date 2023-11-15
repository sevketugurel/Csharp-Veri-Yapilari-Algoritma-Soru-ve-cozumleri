using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendi_Çalışmam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode ln1 = new ListNode(1);
            ln1.next = new ListNode(2);
            ln1.next.next = new ListNode(3);
            ln1.next.next.next = new ListNode(45);
            ln1.next.next.next.next = new ListNode(75);

            ListNode ln2 = new ListNode(1);
            ln2.next = new ListNode(2);
            ln2.next.next = new ListNode(3);
            ln2.next.next.next = new ListNode(45);
            

            Console.WriteLine(IcerirMi(ln1, ln2));
            Console.ReadKey();
        }
        public class ListNode
        {
            public int data;
            public ListNode next;
            public ListNode(int data)
            {
                this.data = data;
            }

        }
        public static bool IcerirMi(ListNode bt1, ListNode bt2)
        {
            int pieces = 0;
            var current = bt1;

            while (current != null)
            {
                pieces++;
                current = current.next;
            }

            int[] arr = new int[pieces];
            int i = 0;
            current = bt1;

            while (current != null)
            {
                arr[i] = current.data;
                i++;
                current = current.next;
            }

            int pieces2 = 0;
            current = bt2;

            while (current != null)
            {
                pieces2++;
                current = current.next;
            }

            int[] arr2 = new int[pieces2];
            int j = 0;
            current = bt2;

            while (current != null)
            {
                arr2[j] = current.data;
                j++;
                current = current.next;
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
