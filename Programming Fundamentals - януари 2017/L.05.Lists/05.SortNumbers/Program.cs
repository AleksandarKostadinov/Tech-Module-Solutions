using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var realNumbers = ReadList();

            realNumbers.Sort();

            Console.WriteLine(string.Join(" <= ", realNumbers));
        }

        public static List<decimal> ReadList()
        {
            List<decimal> numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

            return numbers;
        }
    }
}
