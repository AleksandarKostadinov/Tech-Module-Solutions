using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastKNumbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] sequence = new long[n];
            if (n != 0)
            {
                sequence[0] = 1;
                Console.Write(sequence[0] + " ");

            }

            for (int i = 1; i < n; i++)
            {
                long startOfSuming = 0;
                if (i > k && !(k > n))
                {
                    startOfSuming = i - k ;
                }

                sequence[i] = SumOfArrInRange(startOfSuming, i, sequence);

                Console.Write(sequence[i] + " ");
            }
        }

        public static long SumOfArrInRange(long start, long end, long[] arr)
        {
            long sum = 0;
            for (long i = start; i < end; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
    }
}
