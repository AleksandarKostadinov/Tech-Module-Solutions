using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Circle_Area__Precision_12_
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double aria = r * r * Math.PI;
            Console.WriteLine("{0:f12}",aria);
        }
    }
}
