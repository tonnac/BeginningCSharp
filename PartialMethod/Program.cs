using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethod
{
    partial class MyTest
    {
        partial void Log(object obj);

        public void WriteTest()
        {
            this.Log("Call Test");
        }
    }

    partial class MyTest
    {
        partial void Log(Object obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            MyTest t = new MyTest();
            t.WriteTest();
        }
    }
}