using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Circle
    {
        double pi = 3.14;

        public double Pi
        {
            get { return pi; }
            set { pi = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle o = new Circle();
            o.Pi = 3.14159;
            double piValue = o.Pi;
        }
    }
}
