using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziden_Linked_liste_sıralı_geçirmek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 12, 3, 55, 90, 2, 1 };
            int i = 0;
            Blockt head = new Blockt();
            head = null;
            Blockt last =null;
            Blockt temp = head;
            while(dizi.Length < i)
            {
                Blockt bt = new Blockt();
                if (head == null) {
                    head = dizi[i];
                    last = bt;
                }
                else
                {
                    if (dizi[i])a
                }



                i++;
            }
        }
        static Blockt LinkedaGecis(Blockt bt, int deger)
        {
            if (deger < 0) return bt;
            Blockt t = new Blockt();
            t.data = deger;
            t.next = bt;
            return LinkedaGecis(t, deger);
        }
        class Blockt
        {
            public int data;
            public Blockt next=null;
        }
    }
}
