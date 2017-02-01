using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = ReadListOfInt();

            numbers.Sort();
            int count = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];
                if (i != numbers.Count - 1)
                {
                    if (currentNum == numbers[i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine(currentNum + " -> " + count);
                        count = 1;
                    }
                }
                else
                {
                    Console.WriteLine(currentNum + " -> " + count);
                }

            }
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
