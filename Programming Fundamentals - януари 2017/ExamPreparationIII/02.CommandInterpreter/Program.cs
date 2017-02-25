using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Trim()
                .Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var line = Console.ReadLine();

            while (line != "end")
            {
                if (line.StartsWith("reverse"))
                {
                    var tokens = line.Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    var start = -1;
                    var count = -1;

                    try
                    {
                        start = int.Parse(tokens[2]);
                        count = int.Parse(tokens[4]);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        line = Console.ReadLine();
                        continue;
                    }

                    if (!(start >= 0 && count >= 0 && (start + count) <= arr.Length && start < arr.Length))
                    {
                        Console.WriteLine("Invalid input parameters.");
                        line = Console.ReadLine();
                        continue;
                    }

                    ReverseArrSubGroup(arr , start, count);
                }
                else if (line.StartsWith("sort"))
                {
                    var tokens = line.Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    var start = -1;
                    var count = -1;

                    try
                    {
                        start = int.Parse(tokens[2]);
                        count = int.Parse(tokens[4]);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        line = Console.ReadLine();
                        continue;
                    }

                    if (!(start >= 0 && count >= 0 && (start + count) <= arr.Length && start < arr.Length))
                    {
                        Console.WriteLine("Invalid input parameters.");
                        line = Console.ReadLine();
                        continue;
                    }

                    SortArrSubGroup(arr, start, count);
                }
                else if (line.StartsWith("rollLeft"))
                {
                    var tokens = line.Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    var count = -1;

                    try
                    {
                        count = int.Parse(tokens[1]);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        line = Console.ReadLine();
                        continue;
                    }

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        line = Console.ReadLine();
                        continue;
                    }

                    RollLeftCountTimes(arr, count);
                }
                else if (line.StartsWith("rollRight"))
                {
                    var tokens = line.Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    var count = -1;

                    try
                    {
                        count = int.Parse(tokens[1]);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        line = Console.ReadLine();
                        continue;
                    }

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        line = Console.ReadLine();
                        continue;
                    }

                    RollRightCountTimes(arr, count);
                }

                line = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }

        private static void RollRightCountTimes(string[] arr, int count)
        {
            for (int i = 0; i < count % arr.Length; i++)
            {
                ArrayShiftRight(arr);
            }
        }

        public static void RollLeftCountTimes(string[] arr, int count)
        {
            for (int i = 0; i < count % arr.Length; i++)
            {
                ArrayShiftLeft(arr);
            }
        }

        public static void SortArrSubGroup(string[] arr, int start, int count)
        {
            var sorted = new List<string>();

            for (int i = start ; i <start + count; i++)
            {
                sorted.Add(arr[i]);
            }
            sorted.Sort();

            for (int i = start; i <start + count; i++)
            {
                arr[i] = sorted[i - start]; 
            }
        }

        public static void ReverseArrSubGroup(string[] arr, int start, int count)
        {
            var reversed = new List<string>();

            for (int i = start; i <start + count; i++)
            {
                reversed.Add(arr[i]);
            }
            reversed.Reverse();

            for (int i = start; i <start + count; i++)
            {
                arr[i] = reversed[i - start];
            }
        }

        public static void ArrayShiftRight(string[] array)
        {
            string temp = array[array.Length - 1];

            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = temp;
        }

        public static void ArrayShiftLeft(string[] array)
        {
            string temp = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = temp;
        }
    }
}
