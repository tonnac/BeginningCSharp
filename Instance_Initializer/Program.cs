using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instance_Initializer
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
            : this(string.Empty, 0)
        {
        }

        public Person(string name)
            : this(name, 0)
        {
        }

        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person { Name = "Anders" };
            Person p3 = new Person { Age = 10 };
            Person p4 = new Person { Name = "Anders", Age = 10 };

            List<Person> list = new List<Person>
            {
                new Person{Name = "Jason"},
                new Person {Name = "Icon", Age = 15}
            };
        }
    }
}