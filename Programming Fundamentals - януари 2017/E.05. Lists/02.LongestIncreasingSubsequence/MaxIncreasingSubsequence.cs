namespace _02.LongestIncreasingSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxIncreasingSubsequence
    {
        public static void Main()
        {
            var numbers = ReadListOfInt();
            var length = new int[numbers.Count];
            var previous = new int[numbers.Count];
            previous[0] = -1;
            
           
            int lastIndex = -1;

            int maxLength = 0;

            for (int p = 0; p < numbers.Count; p++)
            {
                length[p] = 1;

                for (int l = 0; l < p; l++)
                {
                    if (numbers[l] < numbers[p] && length[l] >=length[p] )
                    {
                        length[p] = 1 + length[l];
                        previous[p] = l;
                    }
                }

                if (length[p] > maxLength)
                {
                    maxLength = length[p];
                    lastIndex = p;
                }
            }

            var result = new List<int>();

            for (int p = 0 ; p < maxLength; p++)
            {
                result.Add(numbers[lastIndex]);
                lastIndex = previous[lastIndex];
            }

            result.Reverse();

            Console.WriteLine(string.Join(" ", result));
        }

        public static List<int> ReadListOfInt()
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList(); return numbers;
        }
    }
}
