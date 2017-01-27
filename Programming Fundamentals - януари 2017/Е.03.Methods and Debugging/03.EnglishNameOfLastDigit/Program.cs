using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            int digit = number[number.Length - 1] - '0';

            string nameOfDigit = GetEngNameOfDigit(digit);

            Console.WriteLine(nameOfDigit);
        }

        public static string GetEngNameOfDigit(int digit)
        {
            string nameOfDigit = string.Empty;
            if (digit == 1)
            {
                nameOfDigit = "one";
            }
            else if (digit == 2)
            {
                nameOfDigit = "two";
            }
            else if (digit == 3)
            {
                nameOfDigit = "three";
            }
            else if (digit == 4)
            {
                nameOfDigit = "four";
            }
            else if (digit == 5)
            {
                nameOfDigit = "five";
            }
            else if (digit == 6)
            {
                nameOfDigit = "six";
            }
            else if (digit == 7)
            {
                nameOfDigit = "seven";
            }
            else if (digit == 8)
            {
                nameOfDigit = "eight";
            }
            else if (digit == 9)
            {
                nameOfDigit = "nine";
            }
            else if (digit == 0)
            {
                nameOfDigit = "zero";
            }
            return nameOfDigit;
        }
    }
}
