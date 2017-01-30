using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = ReadNumbersFromLine();

            if (numbers.Length == 1)
            {
                Console.WriteLine("{ " + numbers[0] + " }");
            }
            else if (numbers.Length % 2 == 0)
            {
                Console.WriteLine("{ " + numbers[numbers.Length / 2 - 1] + ", " + numbers[numbers.Length / 2] + " }");
            }
            else
            {
                Console.WriteLine("{ " + numbers[numbers.Length / 2 - 1] + ", " + numbers[numbers.Length / 2]
                    + ", " + numbers[numbers.Length / 2 + 1] + " }");
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
