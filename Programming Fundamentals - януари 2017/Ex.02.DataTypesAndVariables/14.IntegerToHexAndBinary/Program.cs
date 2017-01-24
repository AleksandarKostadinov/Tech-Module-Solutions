using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNum = int.Parse(Console.ReadLine());

            var hexNum = Convert.ToString(decimalNum, 16).ToUpper();
            Console.WriteLine(hexNum);
            var binaryNum = Convert.ToString(decimalNum, 2);
            Console.WriteLine(binaryNum);
        }
    }
}
