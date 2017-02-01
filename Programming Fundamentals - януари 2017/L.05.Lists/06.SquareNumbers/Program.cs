namespace _06.SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = ReadListOfInt();

            List<int> squares = GetSquaresFromList(numbers);

            squares.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", squares));
        }

        public static List<int> GetSquaresFromList(List<int> numbers)
        {
            var squares = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNum = numbers[i];

                if (Math.Sqrt(currentNum) % 1 == 0)
                {
                    squares.Add(currentNum);
                }
            }

            return squares;
        }

        public static List<int> ReadListOfInt()
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            return numbers;
        }
    }
}
