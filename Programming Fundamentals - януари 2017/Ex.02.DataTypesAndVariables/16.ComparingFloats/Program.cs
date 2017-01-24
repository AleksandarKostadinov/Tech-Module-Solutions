using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double flo1 = double.Parse(Console.ReadLine());
            double flo2 = double.Parse(Console.ReadLine());

            double epsilon = 0.000001;
            bool floatsAreEqual = Math.Abs(flo1 - flo2) < epsilon; 
            Console.WriteLine(floatsAreEqual);
        }
    }
}
