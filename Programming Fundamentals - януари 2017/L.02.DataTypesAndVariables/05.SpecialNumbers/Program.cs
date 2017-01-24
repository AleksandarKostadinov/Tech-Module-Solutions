using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int paremeter = int.Parse(Console.ReadLine());
            for (int i = 1; i <= paremeter; i++)
            {
                int sum = 0;
                int num = i;
                while (num > 0)
                {
                    int digit = num % 10;
                    sum += digit;
                    num /= 10;
                }
                bool special = sum  == 7 || sum  == 5 || sum == 11;
                Console.WriteLine("{0} -> {1}", i , special);
            }
        }
    }
}
