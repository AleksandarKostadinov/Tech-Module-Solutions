using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence= ReadNumbersFromLine();

            int bestStart = 0;
            int start = 0;
            int length = 1;
            int bestLength = 1;

            for (int i = 1; i < sequence.Length; ++i)
            {
                if (sequence[i] == sequence[i - 1])
                {
                    length++;
                    if (length > bestLength)
                    {
                        bestStart = start;
                        bestLength = length;
                    }
                }
                else
                {
                    start = i;
                    length = 1;
                }
            }

            PrintArrFromWithLength(bestStart, bestLength, sequence);
        }

        public static void PrintArrFromWithLength(int start, int length, int[] sequence)
        {
            for (int i = start; i < start + length; i++)
            {
                Console.Write(sequence[i] + " ");
            }

            Console.WriteLine();
        }

        public static int[] ReadNumbersFromLine()
        {
            int[] nums = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            return nums;
        }
    }
}
