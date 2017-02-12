namespace _03.CirclesIntersection
{
    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }

        public Circle(Point center , int radius)
        {
            Center = center;
            Radius = radius;
        }

        public static bool Intersect(Circle firstCirc,Circle secondCirc)
        {
            return 
                Point.CalculateDistance(firstCirc.Center, secondCirc.Center)
                <= firstCirc.Radius + secondCirc.Radius; 
        }
    }
}
