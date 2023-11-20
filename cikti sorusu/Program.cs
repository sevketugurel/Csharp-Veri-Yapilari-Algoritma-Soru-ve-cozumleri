using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cikti_sorusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Surpriz(5); // stackoverflow hatası verir
        }
        static void Surpriz(int deger)
        {
            if (0 < deger && deger < 10)
            {
                Surpriz(deger - 1);
                Surpriz(deger + 1);
                Console.WriteLine(deger);
            }
        }
    }
}
