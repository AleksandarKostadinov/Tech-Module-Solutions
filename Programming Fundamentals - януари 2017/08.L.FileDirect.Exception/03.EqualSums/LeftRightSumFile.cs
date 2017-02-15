namespace _03.EqualSums
{
    using System;
    using System.IO;
    using System.Linq;

    class LeftRightSumFile
    {
        static void Main(string[] args)
        {
            int[] numbers = ReadNumbersFromFile();

            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = GetLeftSum(i, numbers);
                int rightSum = GetRightSum(i + 1, numbers);

                if (leftSum == rightSum)
                {
                    index = i;
                }
            }

            if (index == -1)
            {
                File.WriteAllText("Output.txt", "no");
            }
            else
            {
                File.WriteAllText("Output.txt", index.ToString());
            }
        }

        private static int GetRightSum(int start, int[] numbers)
        {
            int rightSum = 0;

            for (int i = start; i < numbers.Length; i++)
            {
                rightSum += numbers[i];
            }

            return rightSum;
        }

        public static int GetLeftSum(int end, int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < end; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static int[] ReadNumbersFromFile()
        {
            int[] nums = File.ReadAllText("Input.txt")
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            return nums;
        }
    }
}
