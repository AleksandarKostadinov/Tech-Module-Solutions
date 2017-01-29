using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLineLength = GetDistanceToCanter(x2 - x1, y2 - y1);
            double secondLineLength = GetDistanceToCanter(x4 - x3, y4 - y3);

            if (firstLineLength >= secondLineLength)
            {
                PrintClosest(x1, y1, x2, y2);
            }
            else
            {
                PrintClosest(x3, y3, x4, y4);
            }
        }

        private static void PrintClosest(double x1, double y1, double x2, double y2)
        {
            if (GetDistanceToCanter(x1, y1) <= GetDistanceToCanter(x2, y2))
            {
                PrintCoordinates(x1, y1);
                PrintCoordinates(x2, y2);
            }
            else
            {
                PrintCoordinates(x2, y2);
                PrintCoordinates(x1, y1);
            }

            Console.WriteLine();
        }

        public static double GetDistanceToCanter(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }

        public static void PrintCoordinates(double x, double y)
        {
            Console.Write($"({x}, {y})");
        }
    }
}
