
namespace _01.MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var sequence = ReadListOfInt();

            int bestStart = 0;
            int start = 0;
            int length = 1;
            int bestLength = 1;

            for (int i = 1; i < sequence.Count; ++i)
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

            PrintListFromWithLength(bestStart,bestLength, sequence);
        }

        public static List<int> ReadListOfInt()
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            return numbers;
        }

        public static void PrintListFromWithLength(int start, int length, List<int> sequence)
        {
            for (int i = start; i < start + length; i++)
            {
                Console.Write(sequence[i] + " ");
            }

            Console.WriteLine();
        }

    }
}
