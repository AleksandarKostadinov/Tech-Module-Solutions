using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double firstDistance = GetDistanceToCanter(x1, y1);
            double secondDistance = GetDistanceToCanter(x2, y2);

            if (firstDistance <= secondDistance)
            {
                PrintCoordinates(x1, y1);
            }
            else
            {
                PrintCoordinates(x2, y2);
            }
        }

        public static void PrintCoordinates(double x, double y)
        {
            Console.Write($"({x}, {y})");
        }

        public static double GetDistanceToCanter(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
