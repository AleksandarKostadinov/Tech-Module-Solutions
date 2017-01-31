using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool[] primes = GetBoolArrOf(n + 1, true );

            PrintSieveOfEratosthenes(primes);
        }

        public static void PrintSieveOfEratosthenes(bool[] primes)
        {
            primes[0] = false;
            primes[1] = false;

            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    Console.Write(i + " ");
                    for (int p = 2; p * i < primes.Length; p++)
                    {
                        primes[i * p] = false;
                    }
                }
            }
        }

        public static bool[] GetBoolArrOf(int length, bool value)
        {
            bool[] arrOfbools = new bool[length];

            for (int i = 0; i < length; i++)
            {
                arrOfbools[i] = value;
            }

            return arrOfbools;
        }
    }
}
