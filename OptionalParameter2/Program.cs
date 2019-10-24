using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace OptionalParameter2
{
    internal class Program
    {
        private class Person
        {
            public void Output(string name, int age = 0, string address = "Korea")
            {
                WriteLine(string.Format("{0}: {1} in {2}", name, age, address));
            }
        }

        private static void Main(string[] args)
        {
            Person p = new Person();

            p.Output("Anders");
            p.Output("Winnie", 36);
            p.Output("Tom", 28, "Tibet");

            p.Output("Tom", address: "Tibet");
            p.Output(address: "Tibet", name: "Tom");
            p.Output(age: 5, name: "Tom", address: "Tibet");
            p.Output(name: "Tom");
        }
    }
}