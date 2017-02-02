using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var justList = ReadNumbersFromLine();

            do
            {
                string[] input = Console.ReadLine().Split(' ');

                if (input[0] == "print")
                {
                    PrintList(justList);
                    break;
                }
                else if (input[0] == "add")
                {
                    int index = int.Parse(input[1]);
                    int value = int.Parse(input[2]);
                    justList.Insert(index, value);
                }
                else if (input[0] == "addMany")
                {
                    int index = int.Parse(input[1]);
                    List<int> valuesToAdd = new List<int>();

                    for (int i = 2; i < input.Length; i++)
                    {
                        valuesToAdd.Add(int.Parse(input[i]));
                    }

                    justList.InsertRange(index, valuesToAdd);
                }
                else if (input[0] == "contains")
                {
                    int value = int.Parse(input[1]);
                    Console.WriteLine(justList.IndexOf(value));
                }
                else if (input[0] == "sumPairs")
                {
                    SumPairInList(justList);
                }
                else if (input[0] == "shift")
                {
                    int index = int.Parse(input[1]);
                    LeftShiftOnList(index, justList);
                }
                else if (input[0] == "remove")
                {
                    int index = int.Parse(input[1]);
                    justList.RemoveAt(index);
                }
            } while (true);
        }

        public static void LeftShiftOnList(int index, List<int> justList)
        {
            for (int i = 0; i < index; i++)
            {
                LeftShiftOnce(justList);
            }
        }

        public static void LeftShiftOnce(List<int> justList)
        {
            int temp = justList[0];

            for (int i = 0; i < justList.Count - 1; i++)
            {
                justList[i] = justList[i + 1];
            }

            justList[justList.Count - 1] = temp;
        }

        public static void SumPairInList(List<int> justList)
        {
            for (int i = 0; i < justList.Count; i++)
            {
                if (i + 1 < justList.Count)
                {
                    justList[i] += justList[i + 1];
                    justList.RemoveAt(i + 1);
                }
            }
        }

        public static void PrintList(List<int> anyList)
        {
            Console.WriteLine("[" + string.Join(", ", anyList) + "]");
        }

        public static List<int> ReadNumbersFromLine()
        {
            var nums = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            return nums;
        }
    }
}
