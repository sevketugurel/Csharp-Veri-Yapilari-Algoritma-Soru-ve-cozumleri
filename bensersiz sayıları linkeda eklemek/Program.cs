using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bensersiz_sayıları_linkeda_eklemek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node t1 = new Node();
            Node t2 = new Node();
            Node t3 = new Node();
            Node t4 = new Node();
            Node t5 = new Node();
            Node t6 = new Node();
            Node t7 = new Node();

            t1.data = 1;
            t2.data = 2;
            t3.data = 5;
            t4.data = 4;   
            t5.data = 4;
            t6.data = 7;
            t7.data = 7;

            t1.next = t2;
            t2.next = t3;
            t3.next = t4;
            t4.next = t5;
            t5.next = t6;
            t6.next = t7;
            t7.prev = t6;

            Node head = t1;
            Node A = head;
            Node B;

            int degistirmeAdet = 0; // değiştirme adedi 0 dan fazlaysa poin1deki yani karşılaştırdığımız datayı da 1001 yapıcaz

            while (A != null )
            {
                
                B = A.next;
                while (B != null)
                {
                    if (B.data != 1001 && B.data == A.data )
                    {
                        B.data = 1001; // 1001 datası benzeri olduğu anlamına geliyor
                        degistirmeAdet++;
                    }
                    B = B.next;
                }
                if (degistirmeAdet > 0)
                {
                    A.data = 1001;
                }

                degistirmeAdet = 0;
                A = A.next;
            }

            // şimdi yukarıdaki benzersiz dataları kendi linkedımıza ekliyoruz
            Node head2 = null;

            
            

            while(head != null)
            {
                if(head.data != 1001)
                {
                    Node temp = new Node();
                    temp.data = head.data;
                    temp.next = head2;
                    head2 = temp;
                }
                

                head = head.next;

            }

            while (head2 != null)
            {
                Console.WriteLine(head2.data);
                head2 = head2.next;
            }
            Console.ReadLine();
        }
        public class Node
        {
            public int data;
            public Node next;
            public Node prev;
            
        }
    }
}
