using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield_NaturalNumber
{
    internal class A
    {
        private decimal _posX;
        private decimal _posY;

        public A(decimal _posX, decimal _posY)
        {
            this._posX = _posX;
            this._posY = _posY;
        }

        public override string ToString()
        {
            return string.Format("X: {0}, Y: {1}", _posX, _posY);
        }
    }

    internal class YieldNaturalNumber
    {
        public static IEnumerable<A> Next(int max)
        {
            int _start = 0;

            while (true)
            {
                _start++;

                if (max < _start)
                {
                    yield break;
                }

                yield return new A(_start, _start);
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            foreach (A n in YieldNaturalNumber.Next(100000))
            {
                Console.WriteLine(n);
            }
        }
    }
}