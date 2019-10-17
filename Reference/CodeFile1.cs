using System;


namespace ConsoleApp1
{
    class Point
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point()
        { }

        public override string ToString()
        {
            return "X: " + x + ", Y: " + y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point pt1 = null;

            Change(pt1);
            Console.WriteLine("pt1: " + pt1);

            Change1(ref pt1);
            Console.WriteLine("pt1: " + pt1);
        }

        private static void Change(Point pt)
        {
            pt = new Point();
            pt.X = 6;
            pt.Y = 12;
        }

        private static void Change1(ref Point pt)
        {
            pt = new Point();
            pt.X = 6;
            pt.Y = 12;
        }
    }
}