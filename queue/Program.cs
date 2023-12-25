using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool count = CountStudents()
        }
        public bool CountStudents([1,1,0,0], [0,1,0,1])
        {
            Stack<int> sandwichStack = new Stack<int>();
            Queue<int> studentQueue = new Queue<int>();

            for (int i = sandwiches.Length - 1; i >= 0; i--)
            {
                sandwichStack.Push(sandwiches[i]);
            }

            for (int i = 0; i < students.Length; i++)
            {
                studentQueue.Enqueue(students[i]);
            }

            while (sandwichStack.Count > 0 && studentQueue.Count > 0)
            {
                int student = studentQueue.Dequeue();
                int sandwich = sandwichStack.Peek();
                if (sandwich == student)
                {
                    sandwichStack.Pop();
                }
                else
                {
                    studentQueue.Enqueue(student);
                }
            }

            return studentQueue.Count;
        }
    }
}
