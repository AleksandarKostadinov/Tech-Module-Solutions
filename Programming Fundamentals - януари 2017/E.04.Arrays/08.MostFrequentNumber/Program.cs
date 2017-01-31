using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = ReadNumbersFromLine();

            int count = 1;
            int mostFrequentNum = sequence[0];

            for (int i = 0; i < sequence.Length; i++)
            {
                int currentCount = GetFrequencyOfNumInArr(sequence, sequence[i]);

                if (currentCount > count)
                {
                    count = currentCount;
                    mostFrequentNum = sequence[i];
                }
            }

            Console.WriteLine(mostFrequentNum);
        }

        public static int GetFrequencyOfNumInArr(int[] sequence, int number)
        {
            int count = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == number)
                {
                    count++;
                }
            }

            return count;
        }

        public static int[] ReadNumbersFromLine()
        {
            int[] nums = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            return nums;
        }
    }
}
