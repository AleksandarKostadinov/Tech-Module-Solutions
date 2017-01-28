using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            List<int> primes = GetPrimesInRange(start, end);

            PrintListElementWithCommas(primes);
        }

        private static void PrintListElementWithCommas(List<int> primes)
        {
            for (int currentElement = 0; currentElement < primes.Count; currentElement++)
            {
                Console.Write(primes[currentElement]);
                if (currentElement < primes.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            if (primes.Count == 0)
            {
                Console.Write("(empty list)");
            }

            Console.WriteLine();
        }

        public static List<int> GetPrimesInRange(int start, int end)
        {
            List<int> primeNumbers = new List<int>();

            for (int currentNum = start; currentNum <= end; currentNum++)
            {
                if (IsPrime(currentNum))
                {
                    primeNumbers.Add(currentNum);
                }
            }

            return primeNumbers;
        }

        public static bool IsPrime(int currentNum)
        {
            bool isPrime = true;
            for (int counter = 2; counter <= Math.Sqrt(currentNum); counter++)
            {
                if (currentNum % counter == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (currentNum == 0 || currentNum == 1)
            {
                isPrime = false;
            }

            return isPrime;
        }
    }
}
