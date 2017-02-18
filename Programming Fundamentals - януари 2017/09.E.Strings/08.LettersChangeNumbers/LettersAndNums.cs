namespace _08.LettersChangeNumbers
{
    using System;

    public class LettersAndNums
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            double sum = GetSumAfterActions(input);

            Console.WriteLine($"{sum:f2}");
        }

        public static double GetSumAfterActions(string[] input)
        {
            double sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var currenStr = input[i];

                var leftChar = currenStr[0];
                var rightChar = currenStr[currenStr.Length - 1];
                var number = double.Parse(currenStr.Substring(1, currenStr.Length - 2));

                if (leftChar >=65 && leftChar <= 90)
                {
                    int numToDevide = leftChar - 'A' + 1;
                    number /= numToDevide;
                }
                else if (leftChar >= 97 && leftChar <= 122)
                {
                    int numToMultiply = leftChar - 'a' + 1;
                    number *= numToMultiply;
                }

                if (rightChar >= 65 && rightChar <= 90)
                {
                    int numToSubstract = rightChar - 'A' + 1;
                    number -= numToSubstract;
                }
                else if (rightChar >= 97 && rightChar <= 122)
                {
                    int numToAdd = rightChar - 'a' + 1;
                    number += numToAdd;
                }

                sum += number;
            }

            return sum;
        }
    }
}
