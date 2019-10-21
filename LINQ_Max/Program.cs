using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_Library;

namespace LINQ_Max
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var all = from person in Template.people where person.Address == "Korea" select person;

            var oldestAge = all.Max(elem => elem.Age);
        }
    }
}