using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EventWaitHandle0
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            EventWaitHandle ewh = new EventWaitHandle(false, EventResetMode.ManualReset);

            Thread t = new Thread(threadFunc);
            t.IsBackground = true;
            t.Start(ewh);

            ewh.WaitOne();
            Console.WriteLine("주 스레드 종료");
        }

        private static void threadFunc(object state)
        {
            EventWaitHandle ewh = state as EventWaitHandle;

            Console.WriteLine("30초후 종료");
            Thread.Sleep(1000 * 30);
            Console.WriteLine("스레드 종료");

            ewh.Set();
        }
    }
}