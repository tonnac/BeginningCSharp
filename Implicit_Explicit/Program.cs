using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class Gram
    {
        double mass;
        public Gram(double value)
        {
            this.mass = value;
        }

        public override string ToString()
        {
            return mass + "g";
        }
    }

    class Kilogram
    {
        double mass;

        public Kilogram(double value)
        {
            this.mass = value;
        }

        public static Kilogram operator +(Kilogram op1, Kilogram op2)
        {
            return new Kilogram(op1.mass + op2.mass);
        }
        public override string ToString()
        {
            return mass + "kg";
        }

        //public static implicit operator Gram(Kilogram kilogram)
        //{
        //    return new Gram(kilogram.mass * 1000);
        //}

        public static explicit operator Gram(Kilogram kilogram)
        {
            return new Gram(kilogram.mass * 1000);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kilogram kg1 = new Kilogram(5);
            Kilogram kg2 = new Kilogram(10);

            Kilogram kg3 = kg1 + kg2;

            //Casting
            //Gram g1 = kg1;
            Gram g2 = (Gram)kg2;
            Console.WriteLine(g1.ToString());
            Console.WriteLine(g2.ToString());
        }
    }
}
