namespace _04.MaxSeq.EqualElements
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = ReadNumbersFromFile();

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

            List<int> output =  AddToListFromArrWithLength(bestStart, bestLength, sequence);

            File.WriteAllText("Output.txt", string.Join(" ", output));
        }

        public static List<int> AddToListFromArrWithLength(int start, int length, int[] sequence)
        {
            var justList = new List<int>();

            for (int i = start; i < start + length; i++)
            {
                justList.Add(sequence[i]);
            }
            return justList;
        }

        public static int[] ReadNumbersFromFile()
        {
            int[] nums = File.ReadAllText("Input.txt")
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            return nums;
        }
    }
}
