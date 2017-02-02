namespace _04.SumReversedNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumOfReversed
    {
        public static void Main(string[] args)
        {
            string[] strs = Console.ReadLine().Split(' ');

            var reversedNumbers = new List<int>();

            for (int i = 0; i < strs.Length; i++)
            {
                int currentNumber = int.Parse(GetReversedString(strs[i]));
                reversedNumbers.Add(currentNumber);
            }

            int sum = GetSumListInt(reversedNumbers);

            Console.WriteLine(sum);
        }

        public static int GetSumListInt(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static string GetReversedString(string s)
        {
            string reversedStr = string.Empty;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                reversedStr += s[i];
            }

            return reversedStr;
        }
    }
}
