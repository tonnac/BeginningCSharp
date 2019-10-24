using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Nameof
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"이름: {Name}, 나이: {Age}";
        }
    }

    internal class Program
    {
        //private void OutputPerson(string name, int age)
        //{
        //    WriteLine($"name == {name}");
        //    WriteLine($"age == {age}");

        //    WriteLine($"{nameof(name)} == {name}");
        //    WriteLine($"{nameof(age)} == {age}");
        //}

        private static void Main(string[] args)
        {
            Person person = new Person { Name = "Anders", Age = 49 };
            OutputPerson(person.Name, person.Age);

            string typeName = nameof(Person);
            WriteLine($"{typeName} 속성: {nameof(person.Name)}, {nameof(person.Age)}");

            Dictionary<string, int> ee = new Dictionary<string, int>
            {
                ["qwe"] = 5,
                ["www"] = 3
            };
        }

        private static void OutputPerson(string name, int age)
        {
            string methodName = nameof(OutputPerson);

            WriteLine($"{methodName}.{nameof(name)} == {name}");
            WriteLine($"{methodName}.{nameof(age)} == {age}");

            string localName = name;
            WriteLine($"{methodName}.{nameof(localName)} == {localName}");
        }
    }
}