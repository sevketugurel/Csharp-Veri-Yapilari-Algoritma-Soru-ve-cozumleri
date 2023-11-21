using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziyi_siralayip_linkeda_eklemek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] dizi = {12,3,55, 90 };
            dizi = BubbleSort(dizi);

            linked head = new linked();
            linked x= arrayToLinked(dizi,head,0);

            while(x.next != null)
            {
                Console.WriteLine(x.data);
                x= x.next;
            }
        }

        // ilk önce diziyi sıraladım diğer algoritmalarlada da sıralanabilirdi aklıma bu geldi
        public static int[] BubbleSort(int[] nums)
        {
            int temp;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length-i-1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            return nums;
        }
        public class linked
        {
            public int data;
            public linked next;
        }
        //linkeda sondan eklemeye başladım burada
        public static linked arrayToLinked(int[] nums,linked head,int i)
        {
            if (i > nums.Length-1) return head;

            linked temp = new linked();
            temp.data = nums[nums.Length-1-i];
            temp.next = head;

            return arrayToLinked(nums, temp, i+1);
             
        }
    }
}
