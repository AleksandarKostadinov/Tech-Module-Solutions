using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _14.FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorielNum = FactorialNumber(n);

            int zeros = GetFactorieZeros(factorielNum.ToString());

            Console.WriteLine(zeros);
        }

        public static int GetFactorieZeros(string factorielStr)
        {
            int zeros = 0;

            for (int currentDigit = factorielStr.Length - 1; currentDigit > 1; currentDigit--)
            {
                if (factorielStr[currentDigit] == '0')
                {
                    zeros++;
                }
                else
                {
                    break;
                }
            }

            return zeros;
        }

        public static BigInteger FactorialNumber(int n)
        {
            BigInteger factoriel = 1;
            while (n > 1)
            {
                factoriel *= n;
                n--;
            }

            return factoriel;
        }
    }
}
