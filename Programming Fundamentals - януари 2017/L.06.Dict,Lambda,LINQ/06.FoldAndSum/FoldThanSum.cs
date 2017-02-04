namespace _06.FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FoldThanSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int k = numbers.Count / 4;

            var firstRowLeft = numbers
                .Take(k)
                .Reverse()
                .ToList();

            var firstRowRight = numbers
                .Skip(k * 3)
                .Take(k)
                .Reverse()
                .ToList();

            var secondRow = numbers
               .Skip(k)
               .Take(k * 2)
               .ToList();

            var firstRow = firstRowLeft
                .Concat(firstRowRight);

            var sum = firstRow
                .Select((x, index) => x + secondRow[index])
                .ToList();

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
