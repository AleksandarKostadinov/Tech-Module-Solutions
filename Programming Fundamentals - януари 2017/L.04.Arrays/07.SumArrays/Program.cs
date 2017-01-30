using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firtsArr = ReadNumbersFromLine();
            var secondArr = ReadNumbersFromLine();

            int[] result = new int[Math.Max(firtsArr.Length, secondArr.Length)];

            if (firtsArr.Length >= secondArr.Length)
            {
                result = GetSumOfArrays(firtsArr, secondArr);
            }
            else
            {
                result = GetSumOfArrays( secondArr, firtsArr);
            }

            Console.WriteLine(string.Join(" ", result));
        }

        public static int[] GetSumOfArrays(int[] longerArr, int[] shorterArr)
        {
            int[] sum = new int[longerArr.Length];

            for (int i = 0; i < longerArr.Length; i++)
            {
                sum[i] = longerArr[i] + shorterArr[i % shorterArr.Length];
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
