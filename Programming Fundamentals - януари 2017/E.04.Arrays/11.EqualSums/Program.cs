using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = ReadNumbersFromLine();

            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = GetLeftSum(i, numbers);
                int rightSum = GetRightSum(i + 1 , numbers);

                if (leftSum == rightSum)
                {
                    index = i;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        private static int GetRightSum(int start, int[] numbers)
        {
            int rightSum = 0;

            for (int i = start; i < numbers.Length; i++)
            {
                rightSum += numbers[i];
            }

            return rightSum;
        }

        public static int GetLeftSum(int end, int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < end; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static int[] ReadNumbersFromLine()
        {
            int[] nums = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            return nums;
        }
    }
}
