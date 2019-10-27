using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readonly_Structure
{
    internal readonly struct Vector
    {
        readonly public int X;
        readonly public int Y;

        //이걸로만 변경가능
        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Vector Increment(int x, int y)
        {
            return new Vector(X + x, Y + y);
        }
    }

    internal class Program
    {
        private readonly Vector v1 = new Vector();

        private static void Main(string[] args)
        {
            Program pg = new Program();
            Vector v2 = pg.v1.Increment(32, 12);
        }
    }
}