using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            dynamic d = 5;

            int sum = d + 10;
            Console.WriteLine(sum);

            var e = 5;
            e = "test";

            e.CallFunc();

            dynamic d2 = 5;
            d2 = "test";

            d2.CallFunc();
        }
    }
}