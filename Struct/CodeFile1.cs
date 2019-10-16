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
            Vector v0;
            v0.x = 23f;
            v0.y = 9.3f;
            v0.z = 3.9f;
            Vector v1 = new Vector(1.2f, 3.4f, -3.5f);

            Console.WriteLine(v0.ToString());
            Console.WriteLine(v1.ToString());
        }
    }
}