using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = ReadListFrom();

            sequence.Reverse();

            int writeCount = 0;

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] >= 0)
                {
                    Console.WriteLine(sequence[i]);
                    writeCount++;
                }
            }
            if (writeCount == 0)
            {
                Console.WriteLine("empty");
            }
        }

        private static List<int> ReadListFrom()
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            return numbers;
        }
    }
}
