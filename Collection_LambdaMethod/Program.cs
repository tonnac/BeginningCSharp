using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_LambdaMethod
{
    internal class Person
    {
        public int Age;
        public string Name;
    }

    public static class Util
    {
        public static IEnumerable<T> WhereFunc<T>(this IEnumerable<T> inst) where T : struct, IComparable
        {
            foreach (var item in inst)
            {
                if (item.CompareTo(2) > 0)
                {
                    yield return item;
                }
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> list = new List<int> { 3, 1, 4, 5, 2 };

            list.ForEach((elem) => Console.WriteLine(elem + " * 2 == " + (elem * 2)));

            Array.ForEach(list.ToArray(), (elem) => Console.WriteLine(elem + " * 2 == " + (elem * 2)));

            list.ForEach(
                delegate (int elem)
                {
                    if (elem % 2 == 0)
                    {
                        Console.WriteLine(elem);
                    }
                });

            #region Find All

            List<int> evenList = list.FindAll((elem) => elem % 2 == 0);
            evenList.ForEach(elem => Console.WriteLine(elem));
            List<int> evenList0 = list.FindAll(
                delegate (int elem)
                {
                    return elem % 2 == 0;
                });

            #endregion Find All

            #region Count

            int count = list.Count(elem => elem > 3);

            #endregion Count

            //Count의 Lazy evaluation

            #region Where

            //IEnumerable<int> enumList = list.Where(elem => elem % 2 == 0);
            IEnumerable<int> enumList = list.WhereFunc();
            Array.ForEach(enumList.ToArray(), elem => Console.WriteLine(elem));

            #endregion Where

            /*Convert의 Lazy evaluation*/

            #region Select

            IEnumerable<double> doubleList = list.Select(elem => (double)elem);
            Array.ForEach(doubleList.ToArray(), elem => Console.WriteLine(elem));

            IEnumerable<Person> personList = list.Select(
                elem => new Person { Age = elem, Name = Guid.NewGuid().ToString() });

            Array.ForEach(personList.ToArray(), elem => Console.WriteLine(elem.Name));

            var itemList = list.Select(elem => new { TypeNo = elem, CreateDate = DateTime.Now.Ticks });
            Array.ForEach(itemList.ToArray(), elem => Console.WriteLine(elem.TypeNo));

            #endregion Select
        }
    }
}