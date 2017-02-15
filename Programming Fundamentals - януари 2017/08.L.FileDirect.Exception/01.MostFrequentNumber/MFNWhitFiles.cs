namespace _01.MostFrequentNumber
{
    using System.IO;
    using System.Linq;
    using System;

    class MFNWhitFiles
    {
        static void Main(string[] args)
        {
            int[] sequence = ReadNumbersFromFile();

            int count = 1;
            int mostFrequentNum = sequence[0];

            for (int i = 0; i < sequence.Length; i++)
            {
                int currentCount = GetFrequencyOfNumInArr(sequence, sequence[i]);

                if (currentCount > count)
                {
                    count = currentCount;
                    mostFrequentNum = sequence[i];
                }
            }

            File.WriteAllText("Ouput.txt", mostFrequentNum.ToString());
        }

        public static int GetFrequencyOfNumInArr(int[] sequence, int number)
        {
            int count = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == number)
                {
                    count++;
                }
            }

            return count;
        }

        public static int[] ReadNumbersFromFile()
        {
            int[] nums = File.ReadAllText("Input.txt")
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            return nums;
        }
    }
}
