namespace _04.Largest3Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class KLargestNums
    {
        static void Main()
        {
            int k = 3;
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var result = numbers
                .OrderBy(x => x)
                .Reverse()
                .Take(k)
                .ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
