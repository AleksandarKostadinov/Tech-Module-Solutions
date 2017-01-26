using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetTriangleAria(height , width);
            Console.WriteLine(area);
        }

        static double GetTriangleAria(double height, double width)
        {
            return height * width / 2;
        }
    }
}
