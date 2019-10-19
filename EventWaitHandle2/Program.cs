using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace EventWaitHandle1
{
    internal class MyData
    {
        private long number = 0;

        public long Number
        {
            get { return number; }
        }

        public void Increment()
        {
            ++number;
        }
    }

    internal class Program
    {
        static private EventWaitHandle evt;

        private static void Main(string[] args)
        {
            MyData data = new MyData();

            evt = new EventWaitHandle(true, EventResetMode.ManualReset);

            Thread t0 = new Thread(threadFunc);
            Thread t1 = new Thread(threadFunc);

            t0.Start(data);
            t1.Start(data);

            t0.Join();
            t1.Join();

            Console.WriteLine(data.Number);
        }

        private static void threadFunc(object state)
        {
            MyData data = state as MyData;

            evt.WaitOne();
            evt.Reset();
            for (uint i = 0; i < 4000000000; ++i)
            {
                data.Increment();
            }
            evt.Set();
        }
    }
}