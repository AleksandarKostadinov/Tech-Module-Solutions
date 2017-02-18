namespace _01.ConvertFromBase10ToBaseN
{
    using System;
    using System.Numerics;

    public class DecimalToNBased
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            BigInteger number = BigInteger.Parse(input[1]);
            var toBase = int.Parse(input[0]);

            string numberToBaseN = GetNBasedNumber(number, toBase);

            Console.WriteLine(numberToBaseN);
        }

        public static string GetNBasedNumber(BigInteger number, int toBase)
        {
            var result = string.Empty;

            while (number > 0)
            {
                var reminder = number % toBase;
                result = reminder + result;
                number /= toBase;
            }

            return result;
        }
    }
}
