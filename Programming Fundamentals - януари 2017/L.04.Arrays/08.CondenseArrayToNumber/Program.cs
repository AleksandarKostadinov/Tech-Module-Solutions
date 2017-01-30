using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = ReadNumbersFromLine();
            var condensed = new int[nums.Length - 1];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    condensed[j] = nums[j] + nums[j + 1];
                }
                if (condensed.Length > 0)
                {
                    nums = condensed;
                }
            }
            Console.WriteLine(nums[0]);
        }

        public static int[] ReadNumbersFromLine()
        {
            int[] nums = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            return nums;
        }
    }
}
