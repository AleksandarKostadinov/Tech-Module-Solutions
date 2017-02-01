using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> realNumbers = ReadListFrom();
            
            GetSumedAdjecantEqualNums(realNumbers);

            Console.WriteLine(string.Join(" ", realNumbers));
        }

        public static void GetSumedAdjecantEqualNums(List<decimal> realNumbers)
        {
            for (int i = 0; i < realNumbers.Count -1 ; i++)
            {
                if (realNumbers[i] == realNumbers[i + 1])
                {
                    realNumbers[i] += realNumbers[i + 1];
                    realNumbers.RemoveAt(i + 1);
                    if (i != 0)
                    {
                        i -= 2;
                    }
                    else 
                    {
                        i--;
                    }
                }
            }
        }

        public static List<decimal> ReadListFrom()
        {
            List<decimal> numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

            return numbers;
        }
    }
}
