using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class DrawingObject
    {
        public abstract void Draw();

        public void Move() { Console.WriteLine("Move"); }
    }

    class Line : DrawingObject
    {
        public override void Draw()
        {
            return;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
