using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = ReadNumbersFromLine();
            int difference = int.Parse(Console.ReadLine());

            int countOfDifferences = GetCountOfPairsWithDifference(difference, numbers);

            Console.WriteLine(countOfDifferences);
        }

        public static int GetCountOfPairsWithDifference(int difference, int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j] + difference)
                    {
                        count++;
                    }
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
