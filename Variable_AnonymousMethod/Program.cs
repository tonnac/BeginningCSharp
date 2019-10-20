using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_AnonymousMethod
{
    internal delegate int? MyDivide(int a, int b);

    internal class Program
    {
        private static void Main(string[] args)
        {
            MyDivide myFunc = delegate (int a, int b)
            {
                if (b == 0)
                {
                    return null;
                }

                return a / b;
            };

            Console.WriteLine("10 / 2 = " + myFunc(10, 2));
            Console.WriteLine("10 / 0 = " + myFunc(10, 0));
        }
    }
}