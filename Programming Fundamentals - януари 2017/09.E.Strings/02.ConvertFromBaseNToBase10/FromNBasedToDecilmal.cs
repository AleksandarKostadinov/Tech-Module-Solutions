namespace _02.ConvertFromBaseNToBase10
{
    using System;
    using System.Numerics;

    public class FromNBasedToDecilmal
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            BigInteger number =BigInteger.Parse(input[1]);
            var ofBase = int.Parse(input[0]);

            BigInteger decimalNum = GetDecimalNumberFromNBased(number, ofBase);

            Console.WriteLine(decimalNum);
        }

        public static BigInteger GetDecimalNumberFromNBased(BigInteger number, int ofBase)
        {
            var decimalNumber = new BigInteger(0);

            var strNum = number.ToString();

            for (int i = 0; i < strNum.Length; i++)
            {
                var index = strNum.Length - 1 - i;
                var currentDigit = int.Parse(strNum[index].ToString());
                decimalNumber += currentDigit * BigInteger.Pow(ofBase, i);
            }

            return decimalNumber;
        }
    }
}
