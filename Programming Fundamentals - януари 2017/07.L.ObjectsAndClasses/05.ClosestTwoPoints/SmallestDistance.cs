namespace _05.ClosestTwoPoints
{
    using System;
    using System.Linq;

    public class SmallestDistance
    {
        public static void Main()
        {
            Point[] points = ReadPoints();

            Point[] closestPoints = GetClosestPoints(points);

            double distance = CalcDistance(closestPoints[0], closestPoints[1]);

            Console.WriteLine($"{distance:f3}");
            PrintPoints(closestPoints);
        }

        public static void PrintPoints(Point[] points)
        {
            Console.WriteLine($"({points[0].X}, {points[0].Y})");
            Console.WriteLine($"({points[1].X}, {points[1].Y})");
        }

        public static Point[] GetClosestPoints(Point[] points)
        {
            Point[] closest = null;

            double closestDistance = double.MaxValue;

            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    var currentDistance = CalcDistance(points[i], points[j]);

                    if (currentDistance < closestDistance)
                    {
                        closestDistance = currentDistance;
                        closest = new Point[] {
                            points[i],
                            points[j]
                        };
                        
                    }
                }
            }

            return closest;
        }

        public static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }

            return points;
        }

        public static double CalcDistance(Point p1, Point p2)
        {
            double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));

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
