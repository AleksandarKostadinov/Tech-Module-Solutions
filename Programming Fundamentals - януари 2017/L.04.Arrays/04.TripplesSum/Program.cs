using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TripplesSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = ReadNumbersFromLine();
            bool findTriple = false;
            bool doNotOutputNo = true; ;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        findTriple = numbers[k] == numbers[i] + numbers[j];

                        if (findTriple)
                        {
                            Console.WriteLine($"{numbers[i]} + {numbers[j]} == {numbers[k]}");
                            doNotOutputNo = false;
                            break;
                        }
                    }
                }
            }

            if (doNotOutputNo)
            {
                Console.WriteLine("No");
            }
        }

        public static int[] ReadNumbersFromLine()
        {
            int[] nums = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            return nums;
        }
    }
}
