using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            bool prime = IsPrime(number);

            Console.WriteLine(prime);
        }

        public static bool IsPrime(long number)
        {

            bool isPrime = true;
            for (int counter = 2; counter <= Math.Sqrt(number); counter++)
            {
                if (number % counter == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (number == 0 || number == 1)
            {
                isPrime = false;
            }

            return isPrime;
        }
    }
}

