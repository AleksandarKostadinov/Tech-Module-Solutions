namespace _03.BigFactorial
{
    using System;
    using System.Numerics;

    public class AnotherFactorial
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factoriel = 1;
            while (n > 1)
            {
                factoriel *= n;
                n--;
            }
            Console.WriteLine( factoriel);
        }
    }
}
