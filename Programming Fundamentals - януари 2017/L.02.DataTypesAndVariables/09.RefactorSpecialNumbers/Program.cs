using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int currentNumber = 1; currentNumber <= range; currentNumber++)
            {
                int sum = 0;
                int numberForCalc = currentNumber;
                while (numberForCalc > 0)
                {
                    int digit = numberForCalc % 10;
                    sum += digit;
                    numberForCalc /= 10;
                }
                bool special = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{currentNumber} -> {special}");
            }
        }
    }
}
