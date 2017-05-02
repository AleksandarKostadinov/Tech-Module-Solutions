namespace _02.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SimpleArrActions
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var line = Console.ReadLine();
            while (line != "end")
            {
                var actionInfo = line.Split();
                var action = actionInfo[0];

                if (action == "exchange")
                {
                    var index = int.Parse(actionInfo[1]);
                    if (index >= 0 && index < arr.Length)
                    {
                        ExchangeFromIndex(arr, index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (action == "max")
                {
                    var evenOrOdd = actionInfo[1];
                    PrintMaxElIndexEvenOdd(arr, evenOrOdd);
                }
                else if (action == "min")
                {
                    var evenOrOdd = actionInfo[1];
                    PrintMinElIndexEvenOdd(arr, evenOrOdd);
                }
                else if (action == "first")
                {
                    var count = int.Parse(actionInfo[1]);
                    if (count >= 0 && count <= arr.Length)
                    {
                        var evenOrOdd = actionInfo[2];
                        PrintFirstEvenOdd(arr, evenOrOdd, count);
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                }
                else if (action == "last")
                {
                    var count = int.Parse(actionInfo[1]);
                    if (count >= 0 && count <= arr.Length)
                    {
                        var evenOrOdd = actionInfo[2];
                        PrintLastEvenOdd(arr, evenOrOdd, count);
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }

        private static void PrintLastEvenOdd(int[] arr, string evenOrOdd, int count)
        {
            var last = new List<int>();
            var currentCount = 0;

            for (int i = arr.Length - 1; i >= 0 && currentCount < count; i--)
            {
                if (evenOrOdd == "even" ? IsEven(arr[i]) : IsOdd(arr[i]))
                {
                    last.Add(arr[i]);
                    currentCount++;
                }
            }

            last.Reverse();

            Console.WriteLine("[" + string.Join(", ", last) + "]");
        }

        private static void PrintFirstEvenOdd(int[] arr, string evenOrOdd, int count)
        {
            var first = new List<int>();
            var currentCount = 0;

            for (int i = 0; i < arr.Length && currentCount < count; i++)
            {
                if (evenOrOdd == "even" ? IsEven(arr[i]) : IsOdd(arr[i]))
                {
                    first.Add(arr[i]);
                    currentCount++;
                }
            }

            Console.WriteLine("[" + string.Join(", ", first) + "]");
        }

        private static void PrintMinElIndexEvenOdd(int[] arr, string evenOrOdd)
        {
            var smalles = int.MaxValue;
            var indexfounded = -1;
            bool isFound = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (evenOrOdd == "even" ? IsEven(arr[i]) : IsOdd(arr[i]))
                {
                    if (smalles >= arr[i])
                    {
                        smalles = arr[i];
                        indexfounded = i;
                        isFound = true;
                    }
                }
            }

            if (isFound)
            {
                Console.WriteLine(indexfounded);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void PrintMaxElIndexEvenOdd(int[] arr, string evenOrOdd)
        {
            var greatest = int.MinValue;
            var indexfounded = -1;
            bool isFound = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (evenOrOdd == "even" ? IsEven(arr[i]) : IsOdd(arr[i]))
                {
                    if (greatest <= arr[i])
                    {
                        greatest = arr[i];
                        indexfounded = i;
                        isFound = true;
                    }
                }
            }

            if (isFound)
            {
                Console.WriteLine(indexfounded);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static bool IsOdd(int number)
        {
            if (number % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ExchangeFromIndex(int[] arr, int index)
        {
            for (int i = 0; i < arr.Length - 1 - index; i++)
            {
                ArrayShiftRight(arr);
            }
        }

        public static void ArrayShiftRight(int[] array)
        {
            int temp = array[array.Length - 1];

            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = temp;
        }
    }
}
