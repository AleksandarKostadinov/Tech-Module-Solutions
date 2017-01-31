using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = ReadNumbersFromLine();

            int[] firstRow = GetFirstRow(sequence);
            int[] secondRow = GetSecondRow(sequence);

            int[] sum = GetSumOfArrays(firstRow, secondRow);

            Console.WriteLine(string.Join(" ", sum));
        }

        public static int[] GetSecondRow(int[] sequence)
        {
            int[] secondRow = new int[sequence.Length / 2];

            for (int i = sequence.Length / 4, j = 0; i < sequence.Length - sequence.Length / 4; i++, j++)
            {
                secondRow[j] = sequence[i];
            }

            return secondRow;
        }

        public static int[] GetFirstRow(int[] sequence)
        {
            int[] firstRow = new int[sequence.Length / 2];

            for (int i = 0; i < firstRow.Length / 2; i++)
            {
                firstRow[i] = sequence[sequence.Length / 4 - 1 - i];
                firstRow[firstRow.Length - 1 - i] = sequence[(sequence.Length / 4) * 3 + i];
            }

            return firstRow;
        }

        public static int[] ReadNumbersFromLine()
        {
            int[] nums = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            return nums;
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
    }
}
