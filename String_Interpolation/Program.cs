using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Interpolation
{
    internal class Person
    {
        public string Name { get; set; } = "Empty";
        public int Age { get; set; } = 20;

        //public override string ToString() => "이름" + Name + ", 나이: " + Age;

        public override string ToString() => $"이름: {Name.ToUpper()}, 나이: {(Age > 19 ? "성년" : "미성년") }";
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(new Person { Name = "qwe", Age = 20 });
            Console.WriteLine(new Person { Name = "gfd", Age = 15 });
            Console.WriteLine(new Person { Name = "abc", Age = 23 });
        }
    }
}