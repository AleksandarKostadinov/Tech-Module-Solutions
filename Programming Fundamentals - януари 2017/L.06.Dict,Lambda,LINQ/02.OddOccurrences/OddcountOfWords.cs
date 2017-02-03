namespace _02.OddOccurrences
{
    using System;
    using System.Collections.Generic; 
    using System.Linq;

    public class OddCountOfWords
    {
        public static void Main()
        {
            var strs = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToList();

            var oddCount = new Dictionary<string, int>();

            foreach (var s in strs)
            {
                if (!oddCount.ContainsKey(s))
                {
                    oddCount[s] = 0;
                }

                oddCount[s]++;
            }

            var result = new List<string>();

            foreach (var item in oddCount)
            {
                if (item.Value % 2 == 1)
                {
                    result.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
