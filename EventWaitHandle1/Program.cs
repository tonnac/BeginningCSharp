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
        private int number = 0;

        public int Number
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
        private static void Main(string[] args)
        {
            MyData data = new MyData();

            Hashtable ht1 = new Hashtable();
            ht1["data"] = data;
            ht1["evt"] = new EventWaitHandle(false, EventResetMode.ManualReset);

            ThreadPool.QueueUserWorkItem(threadFunc, ht1);

            Hashtable ht2 = new Hashtable();
            ht2["data"] = data;
            ht2["evt"] = new EventWaitHandle(false, EventResetMode.ManualReset);

            ThreadPool.QueueUserWorkItem(threadFunc, ht2);

            (ht1["evt"] as EventWaitHandle).WaitOne();
            (ht2["evt"] as EventWaitHandle).WaitOne();

            Console.WriteLine(data.Number);
        }

        private static void threadFunc(object state)
        {
            Hashtable ht = state as Hashtable;

            MyData data = ht["data"] as MyData;

            for (int i = 0; i < 10000000; ++i)
            {
                data.Increment();
            }

            (ht["evt"] as EventWaitHandle).Set();
        }
    }
}