using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LINQ_Library;

namespace LINQ_Select
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Select All
            IEnumerable<Person> all = from person in Template.people select person;
            Array.ForEach(all.ToArray(), elem => Console.WriteLine(elem));

            //Convert String
            IEnumerable<string> nameList = from person in Template.people select person.Name;
            IEnumerable<string> nameList0 = Template.people.Select(elem => elem.Name);
            Array.ForEach(nameList.ToArray(), elem => Console.WriteLine(elem));

            //Anynomous Type
            var dataList = from per in Template.people select new { Name = per.Name, Year = DateTime.Now.AddYears(-per.Age).Year };
            Array.ForEach(dataList.ToArray(), elem =>
            {
                Console.WriteLine(string.Format("{0} - {1}", elem.Name, elem.Year));
            });
            //MethodExtention
            var dataList0 = Template.people.Select(elem =>

                new { Name = elem.Name, Year = DateTime.Now.AddYears(-elem.Age).Year }
            );

            int a = 5;
        }
    }
}