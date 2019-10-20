using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace AnonymousMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread thread = new Thread(
                delegate (object obj)
                {
                    Console.WriteLine("Called");
                });
            thread.Start();

            thread.Join();
        }
    }
}