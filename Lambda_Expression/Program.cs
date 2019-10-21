using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    internal delegate int? MyDivide(int a, int b);

    internal delegate int? MyAdd(int a, int b);

    internal class Program
    {
        private static void Main(string[] args)
        {
            MyDivide myFunc = (a, b) =>
            {
                if (b == 0)
                {
                    return null;
                }

                return a / b;
            };
            myFunc(10, 2);
            myFunc(10, 0);

            MyAdd myFunc0 = (a, b) => a + b;
            myFunc0(20, 30);
        }
    }
}