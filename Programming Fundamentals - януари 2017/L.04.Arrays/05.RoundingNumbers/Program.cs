using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] realNumbers = ReadDecimalsFromLile();

            for (int i = 0; i < realNumbers.Length; i++)
            {
                Console.WriteLine("{0} => {1}", realNumbers[i], Math.Round(realNumbers[i], MidpointRounding.AwayFromZero));
            }
        }

        public static decimal[] ReadDecimalsFromLile()
        {
            decimal[] nums = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(decimal.Parse).ToArray();

            return nums;
        }
    }
}
