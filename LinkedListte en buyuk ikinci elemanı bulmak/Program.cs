using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListte_en_buyuk_ikinci_elemanı_bulmak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the original linked list
            Node t1 = new Node();
            Node t2 = new Node();
            Node t3 = new Node();
            Node t4 = new Node();
            Node t5 = new Node();
            Node t6 = new Node();
            Node t7 = new Node();

            t1.data = 10;
            t2.data = 5;
            t3.data = 20;
            t4.data = 15;
            t5.data = 25;
            t6.data = 25;
            t7.data = 250;

            t1.next = t2;
            t2.next = t3;
            t3.next = t4;
            t4.next = t5;
            t5.next = t6;
            t6.next = t7;

            // the second largest
            //Console.WriteLine(enBüyükİkinci(t1));

            // Test the clone method
            Node clonedList = clone(t1);

            // Print the original list
            Console.WriteLine("Original List:");
            PrintList(t1);

            // Print the cloned list
            Console.WriteLine("\nCloned List:");
            PrintList(clonedList);
        }

        public static void PrintList(Node head)
        {
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.next;
            }
        }
    
        public class Node
        {
            public int data;
            public Node next;
        }

        public static int enBüyükİkinci(Node head)
        {
            int enBüyük = head.data;
            int enBüyük2 = head.data;

            while (head != null)
            {
                if (head.data > enBüyük)
                {
                    enBüyük2 = enBüyük;
                    enBüyük = head.data;
                }

                if (head.data > enBüyük2 && head.data < enBüyük)
                {
                    enBüyük2 = head.data;
                }
                head = head.next;
            }
            return enBüyük2;
        }

        public static Node clone(Node head)
        {
            Node temp =null;
            Node last = null;
            
            while (head != null)
            {
                Node nd = new Node();
                nd.data = head.data;

                if(temp == null)
                {
                    temp = nd; last = temp;
                }
                else
                {
                    last.next = nd;
                    last = nd;
                }
                head =head.next;
            }

            return temp;
        }
    }
}
