namespace _01.CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = ReadListOfNumbers();

            var countOfNums = new SortedDictionary<decimal, int>();

            foreach (var item in numbers)
            {
                if (!countOfNums.ContainsKey(item))
                {
                    countOfNums[item] = 0;
                }
                countOfNums[item]++;
            }

            foreach (var number in countOfNums)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }  
        }

        public static List<decimal> ReadListOfNumbers()
        {
            List<decimal> numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

            return numbers;
        }
    }
}
