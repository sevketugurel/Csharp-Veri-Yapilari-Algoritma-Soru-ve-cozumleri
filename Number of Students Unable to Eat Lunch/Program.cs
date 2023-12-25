using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_Students_Unable_to_Eat_Lunch
{         // Leetcode sorusu
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi =  { 1, 1, 0, 0 };
            int[] dizi2 =  { 0, 1, 0, 1 };
            int count = CountStudents(dizi,dizi2);
        }
        public static int CountStudents(int[] students, int[] sandwiches)
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
            int counter = 0;
            while ( studentQueue.Count > 0)
            {
                int student = studentQueue.Dequeue();
                int sandwich = sandwichStack.Peek();
                if (sandwich == student)
                {
                    sandwichStack.Pop();
                    counter = 0 ;
                }
                else
                {
                    studentQueue.Enqueue(student);
                    counter++;
                }
                if (counter == sandwichStack.Count) break;
            }

            return studentQueue.Count;
        }
    }
}
