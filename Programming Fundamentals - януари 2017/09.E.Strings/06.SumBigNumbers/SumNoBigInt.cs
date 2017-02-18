namespace _06.SumBigNumbers
{
    using System;
    using System.Collections.Generic;

    public class SumNoBigInt
    {
        public static void Main()
        {
            var firstNum = Console.ReadLine().TrimStart('0');
            var secondNum = Console.ReadLine().TrimStart('0');

            var greaterNum = string.Empty;
            var smallerNum = string.Empty;

            if (firstNum.Length > secondNum.Length)
            {
                greaterNum += firstNum;
                smallerNum += secondNum;
            }
            else
            {
                greaterNum += secondNum;
                smallerNum += firstNum;
            }

            string sum = GetSumNoBigInt(greaterNum, smallerNum);

            Console.WriteLine(sum);
        }

        public static string GetSumNoBigInt(string greaterNum, string smallerNum)
        {
            var sum = string.Empty;
            var carried = 0;

            for (int i = 0; i < smallerNum.Length; i++)
            {
                var currentDigitGreater = int.Parse(greaterNum[greaterNum.Length - 1 - i].ToString());
                var currentDigitSmaller = int.Parse(smallerNum[smallerNum.Length - 1 - i].ToString());

                var currentSum = currentDigitGreater + currentDigitSmaller + carried;

                var currentResultDigit = currentSum % 10;
                sum = currentResultDigit + sum;

                carried = currentSum / 10;
            }

            for (int i = smallerNum.Length; i < greaterNum.Length; i++)
            {
                var currentDigit = int.Parse(greaterNum[greaterNum.Length - 1 - i].ToString());
                var currentSum = currentDigit + carried;

                var currentResultDigit = currentSum % 10;

                sum = currentResultDigit + sum;

                carried = currentSum / 10;
            }

            if (carried > 0)
            {
                sum = carried + sum;
            }

            return sum;
        }
    }
}
