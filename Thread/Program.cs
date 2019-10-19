using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Thread0
{
    class Program
    {
        static int count = 60;
        static void Main(string[] args)
        {
            Thread t = new Thread(threadFunc);
            t.IsBackground = true;
            t.Start();
            t.Join();
            Console.WriteLine("주 스레드 종료");
        }

        static void threadFunc()
        {
            Console.WriteLine("60초 후 종료");
            Thread.Sleep(1000 * count);
            Console.WriteLine("스레드 종료");
        }
    }
}
