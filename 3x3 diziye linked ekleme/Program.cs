using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3x3_diziye_linked_ekleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Blockt head = null;
            Blockt tail = null;

            // Bağlı listeyi oluştur
            for (int i = 0; i < 27; i++)
            {
                Blockt temp = new Blockt();
                temp.data = i + 1;

                if (head == null)
                {
                    head = temp;
                }
                else
                {
                    tail.next = temp;
                }
                tail = temp;
            }

            // 3x3x3'lük bir dizi oluştur
            int[,,] x = new int[3, 3, 3];
            Blockt current = head;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (current != null)
                        {
                            x[i, j, k] = current.data;
                            current = current.next;
                        }
                        else
                        {
                            Console.WriteLine("Bağlı liste boyutu yetersiz.");
                            Console.ReadLine();
                            return;
                        }
                    }
                }
            }

            // Diziyi yazdır
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write(x[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        class Blockt
        {
            public int data;
            public Blockt next;
        }

    }
}
