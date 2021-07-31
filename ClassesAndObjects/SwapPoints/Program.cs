using System;

namespace SwapPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);

            SwapPoints(p1, p2);

            Console.WriteLine($"p1({ p1.X},{ p1.Y}); p2({p2.X},{p2.Y})");

            Console.ReadKey();

            void SwapPoints(Point one, Point two)
            {
                int xx = one.X;
                int yy = one.Y;
                one.X = two.X;
                one.Y = two.Y;
                two.X = xx;
                two.Y = yy;
            }
        }
    }

    class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }        
    }
}
