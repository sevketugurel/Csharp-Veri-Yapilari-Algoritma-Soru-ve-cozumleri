using System;

class Program
{
    

    static void Main()
    {
        string st4 = "fgdfgdg() (())";
        int hata = 0;

        string p = "{[(";
        string k = "}])";

        for (int i = 0; i < st4.Length; i++)
        {
            //acilmalar için
            int indis = p.IndexOf(st4[i]);
            if (indis != -1)
            {
                push(st4[i]);
            }

            // kapanmalar için

            indis = k.IndexOf(st4[i]);
            if (indis != -1)
            {
                if (stackPointer == -1 || p[indis] != pop())
                {
                    hata = 1;
                }
            }
        }

        Console.WriteLine(hata);
    }

    static char[] stack = new char[100];
    static int stackPointer = -1;

    static void push(char data)
    {
        stackPointer++;
        stack[stackPointer] = data;
    }

    static char pop()
    {
        char data = stack[stackPointer];
        stackPointer--;
        return data;
    }
}
