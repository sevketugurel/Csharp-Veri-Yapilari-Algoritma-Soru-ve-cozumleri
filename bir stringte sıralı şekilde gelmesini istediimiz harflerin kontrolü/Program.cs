using System;
using System.Collections.Generic;

namespace bir_stringte_sıralı_şekilde_gelmesini_istediimiz_harflerin_kontrolü
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // EKSİK VAR TAM OALRAK YAPAMADIM ÇOK KARIŞTI
            



            // Bir string ifadede her 'a' dan sonra 2 adet 'b'; 2 adet 'c’den sonra 1 adet 'd' gelmelidir. a-2b, 3c-d şeklinde ???.
            // Karakterler birbirlerini hemen takip etmek zorunda değildir. Aralarda başka karakterler de olabilir.
            // Örneğin 1a 2 b kabul; cggghhhchhdaggbb kabul; 2c-1d ve 1a-2b mevcut. Kabul; accbbd kabul; 
            // Sonlandırma karakterleri (b,d) başlangıç Karakterleri (a,c) geldikten sonra gelecektir.

            string s = "accbbdaadgfhfgh2342342";
            Stack<char> stack = new Stack<char>();
            Stack<char> stack2 = new Stack<char>();
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];

                if (currentChar == 'a' || currentChar == 'b' || currentChar == 'c' || currentChar == 'd')
                {
                    stack.Push(currentChar);
                }
            }

            int charCountToCheck = stack.Count;

            while (stack.Count > 0)
            {
                char currentChar = stack.Pop();

                if (currentChar == 'd')
                {
                    while (stack.Count > 0)
                    {
                        char currentChar2 = stack.Pop();
                        if (currentChar2 == 'c')
                        {
                            count++;
                        }
                        else
                        {
                            stack2.Push(currentChar2);
                        }
                    }

                    if (count == 2)
                    {
                        while (stack2.Count > 0)
                        {
                            // Eğer stack2'de başka karakter varsa işlem yapılmalı (örneğin, Console.WriteLine(stack2.Pop()); gibi)
                            stack2.Pop();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Dizilim hatalı: 2 c den sonra 1 d gelmiyor.");
                        break;
                    }
                }
                else if (currentChar == 'b')
                {
                    int count2 = 0;

                    while (stack.Count > 0)
                    {
                        char currentChar2 = stack.Pop();
                        if (currentChar2 == 'b') count++;
                        else if (currentChar2 == 'a') count2++;
                        else stack2.Push(currentChar2);
                    }

                    if (count == 1 && count2 == 1) { continue; }
                    else { Console.WriteLine(" 1 a dan sonra 2 b gelmiyor "); }
                }
            }

            Console.WriteLine("Tüm durumlara uygun. Tebrikler...");
        }
    }
}
