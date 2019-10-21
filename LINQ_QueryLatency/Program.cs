using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_Library;

namespace LINQ_QueryLatency
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("ToList() executed");

            var inKorea = (from person in Template.people where IsEqual(person.Address, "Korea") select person).ToList();

            Console.ReadLine();

            Console.WriteLine("IEnumeable<T> Where/Select evaluated");
            var inKorea2 = from person in Template.people where IsEqual(person.Address, "Korea") select person;

            Console.ReadLine();

            Console.WriteLine("IEnumerable<T> Take evaluated");
            var firstPeople = inKorea2.Take(1);

            Console.ReadLine();

            Array.ForEach(inKorea2.ToArray(), elem => Console.WriteLine(elem));

            Console.WriteLine(firstPeople.Single());
        }

        private static bool IsEqual(string arg1, string arg2)
        {
            Console.WriteLine("Executed");
            return arg1 == arg2;
        }
    }
}