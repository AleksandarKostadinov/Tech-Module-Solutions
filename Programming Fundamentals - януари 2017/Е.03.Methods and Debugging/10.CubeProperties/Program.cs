using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string property = Console.ReadLine();

            if (property == "face")
            {
                double faceDiagonal = Math.Round(GetFaceDiagonal(side), 2);
                Console.WriteLine("{0:f2}",faceDiagonal);
            }
            else if (property == "space")
            {
                double spaceDiagonal = Math.Round(GetSpaceDiagonal(side) , 2);
                Console.WriteLine("{0:f2}", spaceDiagonal);
            }
            else if (property == "volume")
            {
                double volume = Math.Round(GetCubeVolume(side), 2);

                Console.WriteLine("{0:f2}", volume);
            }
            else if (property == "area")
            {
                double area = Math.Round(GetCubeArea(side) , 2);

                Console.WriteLine("{0:f2}",area);
            }
        }

        public static double GetCubeArea(double side)
        {
            return side * side * 6;
        }

        public static double GetCubeVolume(double side)
        {
            return side * side * side;
        }

        public static double GetSpaceDiagonal(double side)
        {
            return Math.Sqrt(side * side + side * side + side * side);
        }

        public static double GetFaceDiagonal(double side)
        {
            return Math.Sqrt(side * side + side * side);
        }
    }
}
