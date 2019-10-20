using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace StaticClass
{
    internal static class StaticOnly
    {
        private static string _name;

        public static string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        static public void WriteNameASync()
        {
            ThreadPool.QueueUserWorkItem(delegate (object objState)
            {
                Console.WriteLine(_name);
            });
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            StaticOnly.Name = "Anders";

            StaticOnly.WriteNameASync();

            Thread.Sleep(1000);
        }
    }
}