using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Stopwatch0
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();

            st.Start();
            sum();
            st.Stop();

            Console.WriteLine("Total ticks: " + st.ElapsedTicks);

            Console.WriteLine("Millisecond: " + st.ElapsedMilliseconds);

            Console.WriteLine("Second: " + st.ElapsedMilliseconds / 1000);
            Console.WriteLine("Second: " + st.ElapsedTicks / Stopwatch.Frequency);
        }

        static private long sum()
        {
            long sum = 0;

            for(int i=0; i<100000; ++i)
            {
                sum += i;
            }
            return sum;
        }
    }
}
