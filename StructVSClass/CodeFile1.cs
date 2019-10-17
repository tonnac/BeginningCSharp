using System;

namespace ConsoleApp1
{
    struct Vector
    {
        public float x;
        public float y;
        public float z;

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return "X: " + x + ", Y: " + y + ", Z: " + z;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(1.2f, 3.4f, -3.5f);
            Vector v0 = v1;
            v0.x = 5.0f;
            v0.y = 5.0f;
            v0.z = 5.0f;

            Point p1 = new Point(3, 4);
            Point p2 = p1;

            p1.x = 93;
            p1.y = 293;

            Console.WriteLine(v0.ToString());
            Console.WriteLine(v1.ToString());
        }
    }
}