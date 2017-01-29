using System;
using System.Collections.Generic;

public class BePositive_broken
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            string[] input = Console.ReadLine().Trim().Split(' ');
            List<int> numbers = new List<int>();

            for (int j = 0; j < input.Length; j++)
            {
                if (input[j] != string.Empty)
                {
                    numbers.Add(int.Parse(input[j]));
                }
            }

            bool found = false;

            for (int j = 0; j < numbers.Count; j++)
            {
                int currentNum = numbers[j];

                if (currentNum >= 0)
                {
                    Console.Write(currentNum + " ");

                    found = true;
                }
                else if (j < numbers.Count - 1)
                {
                    currentNum += numbers[j + 1];

                    if (currentNum >= 0)
                    {
                        Console.Write(currentNum + " ");

                        found = true;
                    }
                    j++;
                }
            }

            if (!found)
            {
                Console.WriteLine("(empty)");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}