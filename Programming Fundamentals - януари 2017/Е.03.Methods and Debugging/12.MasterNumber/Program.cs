using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int currentNumber = 232; currentNumber <= n; currentNumber++)
            {
                bool isPolindrome = IsPolindrome(currentNumber.ToString());

                if (isPolindrome)
                {
                    bool sumOfDigitsEqualToSeven = SumOfDigitsEqualTo(currentNumber, 7);
                    if (sumOfDigitsEqualToSeven)
                    {
                        bool hasEvenDigit = ContainsEvenDigit(currentNumber);
                        if (hasEvenDigit)
                        {
                            Console.WriteLine(currentNumber);
                        }
                    }
                }
            }
        }

        public static bool ContainsEvenDigit(int currentNumber)
        {
            foreach (var digit in currentNumber.ToString())
            {
                int currentDigit = digit - '0';

                if (currentDigit % 2 == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool SumOfDigitsEqualTo(int currentNumber, int divisor)
        {
            int sum = 0;
            foreach (var digit in currentNumber.ToString())
            {
                sum += digit - '0';
            }

            if (sum % divisor == 0)
            {
                return true;
            }

            return false;
        }

        public static bool IsPolindrome(string n)
        {
            int lenghtOfNumber = n.Length;
            for (int i = 0; i < lenghtOfNumber / 2; i++)
            {

                if (n[i] != n[lenghtOfNumber - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
