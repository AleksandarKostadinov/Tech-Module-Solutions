using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double triangleArea = Math.Round(GetTriangleAria(side, height), 2);

                Console.WriteLine("{0:f2}", triangleArea);
            }
            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());

                double squareAria = Math.Round(GetSquareAria(side), 2);

                Console.WriteLine("{0:f2}", squareAria);
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double rectangleArea = Math.Round(GetRectangleAria(width, height), 2);

                Console.WriteLine("{0:f2}", rectangleArea);
            }
            else if (figure == "circle")
            {
                double rarius = double.Parse(Console.ReadLine());

                double circleArea = Math.Round(GetCircleAria(rarius), 2);

                Console.WriteLine("{0:f2}", circleArea);
            }
        }

        public static double GetCircleAria(double rarius)
        {
            return rarius * rarius * Math.PI;
        }

        public static double GetRectangleAria(double width, double height)
        {
            return width * height;
        }

        public static double GetSquareAria(double side)
        {
            return GetRectangleAria(side, side);
        }

        public static double GetTriangleAria(double side, double height)
        {
            return GetRectangleAria(side, height) / 2;
        }
    }
}
