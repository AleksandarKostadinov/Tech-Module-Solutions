namespace _04.DistanceBetweenPoints
{
    using System;
    using System.Linq;

    public class EuclideanDistance
    {
        public static void Main()
        {
            Point firstPoint = ReadPoint();
            Point secondPoint = ReadPoint();

            double distance = CalDistance(firstPoint, secondPoint);

            Console.WriteLine($"{distance:f3}");
        }

        public static double CalDistance(Point p1, Point p2)
        {
            double distance =  Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            
            return distance;
        }

        public static Point ReadPoint()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var point = new Point();

            point.X = input[0];
            point.Y = input[1];

            return point;
        }
    }
}
