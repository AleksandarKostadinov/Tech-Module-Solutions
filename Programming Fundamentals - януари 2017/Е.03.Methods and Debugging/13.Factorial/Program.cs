using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorielNum = FactorialNumber(n);

            Console.WriteLine(factorielNum);
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
