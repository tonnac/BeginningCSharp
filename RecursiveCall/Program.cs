using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveCall
{
    class Program
    {
        static void Main(string[] args)
        {
            RecursiveCall(1);
        }

        private static void RecursiveCall(long n)
        {
            int i = 1;
            int j = 1;
            int k = 1;
            Console.WriteLine(n);
            RecursiveCall(n + 1);
        }
    }
}
