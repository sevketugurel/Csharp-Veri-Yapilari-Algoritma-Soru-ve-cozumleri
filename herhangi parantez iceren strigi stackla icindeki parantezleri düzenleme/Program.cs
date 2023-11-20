using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postfix_prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string infix = "a+b-c*d";// ab+cd*-
            string ops = "#(*/+-)";
            int[] val = { 0, 5, 4, 4, 3, 3 };
            Stack<int> st = new Stack<int>();
            st.Push(0);
            string postfix = "";
            for (int i = 0; i < infix.Length; i++)
            {
                if (ops.IndexOf(infix[i]) == -1)
                { postfix = postfix + infix[i]; continue; }
                if (infix[i] == ')')
                {
                    while (st.Peek() != 1)
                    {
                        int dt = st.Pop();
                        postfix = postfix + ops[dt];
                    }
                    st.Pop();
                    continue;
                }
                if (infix[i] == '(')
                { st.Push(ops.IndexOf('(')); continue; }

                int op1 = val[st.Peek()];
                int op2 = val[ops.IndexOf(infix[i])];

                if (op1 < op2) { st.Push(ops.IndexOf(infix[i])); }
                else
                {
                    postfix += ops[st.Pop()];
                    st.Push(ops.IndexOf(infix[i]));
                }
            }
            while (st.Count > 1)
            {

                postfix = postfix + ops[st.Pop()];
            }
            Console.WriteLine(postfix);

        }

        
    }
}
