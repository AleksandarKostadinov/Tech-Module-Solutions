namespace _03.CirclesIntersection
{
    using System;
    using System.Linq;
    class CirclesWithCommonPionts
    {
        static void Main()
        {
            var firstCircleData = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var secondCircleData = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            Point firstCenter = new Point(firstCircleData[0], firstCircleData[1]);
            Circle firstCircle = new Circle(firstCenter, firstCircleData[2]);

            Point secondCenter = new Point(secondCircleData[0], secondCircleData[1]);
            Circle secondCircle = new Circle(secondCenter, secondCircleData[2]);

            Console.WriteLine(Circle.Intersect(firstCircle, secondCircle)
                ?"Yes"
                :"No");
        }
    }
}
