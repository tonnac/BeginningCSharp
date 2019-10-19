using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace MultithreadCommonVariable
{
    class MyData
    {
        int number = 0;

        private object _numberLock = new object();
        public int Number { get { return number; } }

        public void Increment()
        {
            lock (_numberLock)
            {
                ++number;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyData data = new MyData();

            Thread t1 = new Thread(threadFunc);
            Thread t2 = new Thread(threadFunc);

            t1.Start(data);
            t2.Start(data);

            t1.Join();
            t2.Join();

            Console.WriteLine(data.Number);
            Console.ReadLine();
        }

        static void threadFunc(object inst)
        {
            MyData pg = inst as MyData;

            for(int i=0; i<10000000; ++i)
            {
                pg.Increment();
            }
        }
    } 
}
