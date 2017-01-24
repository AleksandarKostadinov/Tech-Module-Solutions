using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = (width + height) * 2;
            double aria = width * height;
            double diagonal = Math.Sqrt(width * width + height * height);

            Console.WriteLine(perimeter);
            Console.WriteLine(aria);
            Console.WriteLine(diagonal);
        }
    }
}
