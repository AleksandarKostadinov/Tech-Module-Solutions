using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = ReadNumbersFromLine();
            int rotationsCount = int.Parse(Console.ReadLine());

            int[] result = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int r = 1; r <= rotationsCount; r++)
                {
                    int theBigFormulaForCurrentN = ((arr.Length - r % arr.Length) + i) % arr.Length;
                    int currentNumOfArr = arr[theBigFormulaForCurrentN];
                    result[i] += currentNumOfArr;
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }

        public static int[] ReadNumbersFromLine()
        {
            int[] nums = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            return nums;
        }
    }
}
