using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("This program checks if the numbers \r\nfrom 2 to N are prime.");
            //Console.Write("Enter N:");
            int n = int.Parse(Console.ReadLine());

            for (int currentNum = 2; currentNum <= n; currentNum++)
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
                Console.WriteLine($"{currentNum} -> {isPrime}");
            }
        }
    }
}
