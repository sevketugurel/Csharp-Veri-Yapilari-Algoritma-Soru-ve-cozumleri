using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace birbiri_içinde_2_adet_veri_içeren_linked_list_sorgulaması
{
    internal class Program
    {
        // iki çift linked içindeki yalnıza 2 defa içeren ve ortak olan eleman adetini veren algortitma
        static void Main(string[] args)
        {

            // 1.
            Node n1 = new Node();
            Node n2 = new Node();
            Node n3 = new Node();
            Node n4 = new Node();
            Node n5 = new Node();
            Node n6 = new Node();

            n1.data = 10;
            n2.data = 5;
            n3.data = 10;
            n4.data = 20;
            n5.data = 20;
            n6.data = 5;

            n1.next = n2;
            n2.prev = n1;

            n2.next = n3;
            n3.prev = n2;

            n3.next = n4;
            n4.prev = n3;

            n4.next = n5;
            n5.prev = n4;

            n5.next = n6;
            n6.prev = n5;

            // 2. 
            Node t1 = new Node();
            Node t2 = new Node();
            Node t3 = new Node();
            Node t4 = new Node();
            Node t5 = new Node();
            Node t6 = new Node();
            Node t7 = new Node();

            t1.data = 5;
            t2.data = 20;
            t3.data = 5;
            t4.data = 10;
            t5.data = 20;
            t6.data = 10;
            t7.data = 250;

            t1.next = t2;
            t2.prev = t1;

            t2.next = t3;
            t3.prev = t2;

            t3.next = t4;
            t4.prev = t3;

            t4.next = t5;
            t5.prev = t4;

            t5.next = t6;
            t6.prev = t5;

            t6.next = t7;
            t7.prev = t6;

            Node head = t1;
            Node first = n1;

            int uyanSayıAdedi = UyanSayıAdedi(head , first);
            Console.WriteLine("Uyan sayı adedi: "+uyanSayıAdedi);
            Console.ReadLine();
        }
        public class Node
        {
            public int data;
            public Node next;
            public Node prev;

        }

        public static int UyanSayıAdedi(Node node1, Node node2)
        {
            Node A = node1;
            Node B = node2;

            bool AIkiDefaMı = false;
            bool BIkiDefaMı = false;

            int uyanSayıAdedi = 0;


            while (A != null)
            {
                B=node2; // üstteki yani A her bir arttığında B pointi baştan tekrar okuyacak
                while(B != null)
                {
                    if(A.data == B.data)
                    {
                        AIkiDefaMı = ikiDefaİceriyorMu(node1,A.data);
                        BIkiDefaMı = ikiDefaİceriyorMu(node2,B.data);

                        if (AIkiDefaMı && BIkiDefaMı)
                        {

                            uyanSayıAdedi++;
                            break;
                        }
                    }
                    B = B.next;
                }
                A = A.next;
            }

            return uyanSayıAdedi/2; // ikişer tane içerdiğinden birisni iki defa saymış olcak yarıya indirmemeiz gerekir.
        }

        public static bool ikiDefaİceriyorMu(Node nd, int istenenSayı)
        {
            Node point = nd;
            int icermeAdedi = 0;

            while (point != null)
            {
                if (point.data == istenenSayı)
                {
                    icermeAdedi++;
                }

                point = point.next;
            }

            return icermeAdedi == 2;
        }


    }
}
