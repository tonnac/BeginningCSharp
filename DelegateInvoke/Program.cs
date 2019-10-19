using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateInvoke
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

            IAsyncResult ar = calc.BeginInvoke(1, 1000000000, null, null);

            ar.AsyncWaitHandle.WaitOne();

            long result = calc.EndInvoke(ar);

            Console.WriteLine(result);
        }
    }
}