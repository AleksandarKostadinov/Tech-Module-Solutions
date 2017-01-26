using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs( int.Parse(Console.ReadLine()));

            int result = GetMultipleOfEvenAndOdds(number);

            Console.WriteLine(result);
        }

        public static int GetMultipleOfEvenAndOdds(int number)
        {
            int result = GetSumOfDigitsWithDevisor(number, 1) * GetSumOfDigitsWithDevisor(number, 0);
            return result;
        }

        private static int GetSumOfDigitsWithDevisor(int number, int divisor)
        {
            int result = 0;

            foreach (var digit in number.ToString())
            {
                int currentDigit = digit - '0';

                if (currentDigit % 2 == divisor)
                {
                    result += currentDigit;
                }
            }

            return result;
        }
    }
}
