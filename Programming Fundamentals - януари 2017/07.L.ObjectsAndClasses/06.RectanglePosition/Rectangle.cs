namespace _06.RectanglePosition
{
    public class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        int CalcAria()
        {
            return Width * Height;
        }

        public int Bottom
        {
            get
            {
                return Top - Height;
            }
        }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public bool IsInside(Rectangle r)
        {
            bool leftIsCorrect = Left >= r.Left;
            bool rightIsCorrect = Right <= r.Right;
            bool topIsCorrect = Top <= r.Top;
            bool bottomIsCorrect = Bottom >= r.Bottom;

            return leftIsCorrect
                && rightIsCorrect
                && topIsCorrect
                && bottomIsCorrect;
        }
    }
}
