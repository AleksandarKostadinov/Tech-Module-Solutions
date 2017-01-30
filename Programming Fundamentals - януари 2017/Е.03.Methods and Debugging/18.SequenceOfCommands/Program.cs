using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] numbers = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();


        while (true)
        {

            string line = Console.ReadLine().Trim();
            int[] args = new int[2];
            

            string[] stringParams = line.Split(ArgumentsDelimiter);
            string command = stringParams[0];
            if (command.Equals("add") ||
                command.Equals("subtract") ||
                command.Equals("multiply"))
            {
                args[0] = int.Parse(stringParams[1]);
                args[1] = int.Parse(stringParams[2]);

            }

            if (command == "stop")
            {
                break;
            }
                        
            PerformAction(numbers, command, args);

            PrintArray(numbers);
           }
    }

    static void PerformAction(long[] numbers, string action, int[] args)
    {
        
        int position = args[0] - 1;
        int value = args[1];

        switch (action)
        {
            case "multiply":
                numbers[position] *= value;
                break;
            case "add":
                numbers[position] += value;
                break;
            case "subtract":
                numbers[position] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(numbers);
                break;
            case "rshift":
                ArrayShiftRight(numbers);
                break;
        }
    }

    public static void ArrayShiftRight(long[] array)
    {
        long temp = array[array.Length - 1];

        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }

        array[0] = temp;
    }

    public static void ArrayShiftLeft(long[] array)
    {
        long temp = array[0];

        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[array.Length - 1] = temp;
    }

    public static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }
}
