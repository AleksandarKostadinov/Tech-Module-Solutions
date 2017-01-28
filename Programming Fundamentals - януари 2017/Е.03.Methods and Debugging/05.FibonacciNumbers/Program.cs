using System;

namespace _05.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int result = GetFibunacci(n);

            Console.WriteLine(result);
        }

        public static int GetFibunacci(int n)
        {
            int f0 = 1;
            int f1 = 1;

            for (int currentFibonacciNumber = 2; currentFibonacciNumber <= n
                ; currentFibonacciNumber++)
            {
                int fibonacciNumber = f0 + f1;
                f0 = f1;
                f1 = fibonacciNumber;
            }

            return f1;
        }
    }
}
