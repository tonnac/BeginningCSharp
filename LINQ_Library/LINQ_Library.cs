using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Library
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1} in {2}", Name, Age, Address);
        }
    }

    public class MainLanguage
    {
        public string Name { get; set; }
        public string Language { get; set; }
    }

    public static class Template
    {
        public static List<Person> people = new List<Person>
        {
            new Person { Name = "Tom", Age = 63, Address = "Korea"},
            new Person { Name = "Winnie", Age = 40, Address = "Tibet"},
            new Person { Name = "Anders", Age = 47, Address = "Sudan"},
            new Person { Name = "Hans", Age = 25, Address = "Tibet"},
            new Person { Name = "Eureka", Age = 32, Address = "Sudan"},
            new Person { Name = "Hawk", Age = 15, Address = "Korea"},
        };

        public static List<MainLanguage> languages = new List<MainLanguage>
        {
            new MainLanguage { Name = "Anders", Language = "Delphi"},
            new MainLanguage { Name = "Anders", Language = "C#"},
            new MainLanguage { Name = "Tom", Language = "Borland C++"},
            new MainLanguage { Name = "Hans", Language = "Visual C++"},
            new MainLanguage { Name = "Winnie", Language = "R"},
        };
    }
}