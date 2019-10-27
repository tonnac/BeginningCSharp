using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Parameter_In
{
    internal struct Vector
    {
        public int X;
        public int Y;

        public Vector(int x, int y)
        {
            WriteLine("Construct");
            X = x;
            Y = y;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Program pg = new Program();

            Vector v1 = new Vector(1, 3);
            pg.StructParam(in v1);
        }

        // C++의 const T&와 같음!
        private void StructParam(in Vector v)
        {
            ReadLine();
        }
    }
}