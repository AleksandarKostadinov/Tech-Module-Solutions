namespace _06.RectanglePosition
{
    using System;
    using System.Linq;
    public class TwoRectangles
    {
        public static void Main()
        {
            Rectangle firstRect = ReadRectangle();
            Rectangle secondRect = ReadRectangle();

            Console.WriteLine(firstRect.IsInside(secondRect)
                ? "Inside" 
                : "Not inside");
        }

        public static Rectangle ReadRectangle()
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Rectangle rect = new Rectangle
            {
                Left = input[0],
                Top = input[1],
                Width = input[2],
                Height = input[3]
            };

            return rect;
        }
    }
}
