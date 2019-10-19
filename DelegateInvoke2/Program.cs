using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateInvoke2
{
    internal class Calc
    {
        public static long Cumsum(int start, int end)
        {
            long sum = 0;
            for (int i = start; i <= end; ++i)
            {
                sum += i;
            }
            return sum;
        }
    }

    internal class Program
    {
        public delegate long CalcMethod(int start, int end);

        private static void Main(string[] args)
        {
            CalcMethod calc = new CalcMethod(Calc.Cumsum);

            calc.BeginInvoke(1, 1000000000, calcCompleted, calc);

            Console.ReadLine();
        }

        private static void calcCompleted(IAsyncResult ar)
        {
            CalcMethod calc = ar.AsyncState as CalcMethod;
            long result = calc.EndInvoke(ar);

            Console.WriteLine(result);
        }
    }
}