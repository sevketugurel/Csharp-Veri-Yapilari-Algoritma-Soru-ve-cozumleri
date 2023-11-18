using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bir_dosya_dizininin_tüm_alt_dizinlerini_stack_ile_elde_etmek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            string s = @"\\Mac\Home\Documents\C#";
            stack.Push(s);

            while (stack.Count > 0)
            {
                s = stack.Pop();
                Console.WriteLine(s);
                DirectoryInfo di = new DirectoryInfo(s);
                DirectoryInfo[] dis = di.GetDirectories();
                foreach ( DirectoryInfo d in dis )
                {
                    stack.Push(d.FullName);
                }
            }

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.ReadLine();
        }
    }
}
