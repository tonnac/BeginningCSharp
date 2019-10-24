using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    internal class Person
    {
        public void Output(string name)
        {
            Output(name, 0, "Korea");
        }

        public void Output(string name, int age)
        {
            Output(name, age, "Korea");
        }

        public void Output(string name, int age, string address)
        {
            Console.WriteLine(string.Format("{0}: {1} in {2}", name, age, address);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Person p = new Person();

            p.Output("Anders");
            p.Output("Winnie", 36);
            p.Output("Anders", 28, "Tibet");
        }
    }
}