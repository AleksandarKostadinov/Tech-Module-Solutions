using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            string revesed = GetReversedString(number);

            Console.WriteLine(revesed);
        }

        public static string GetReversedString(string number)
        {
            string reversedStr = string.Empty;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedStr += number[i];
            }

            return reversedStr;
        }
    }
}
