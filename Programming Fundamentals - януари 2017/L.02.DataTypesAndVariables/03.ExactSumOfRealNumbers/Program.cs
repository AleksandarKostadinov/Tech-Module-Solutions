using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int parameter = int.Parse(Console.ReadLine());
            decimal sum = 0m ;
            for (int i = 0; i < parameter; i++)
            {
                decimal currentNum = decimal.Parse(Console.ReadLine());
                sum += currentNum;
            }
            Console.WriteLine( sum);
        }
    }
}
