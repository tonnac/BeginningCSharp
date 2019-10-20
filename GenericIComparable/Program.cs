using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIComparable
{
    internal class Utility
    {
        public static T Max<T>(T item1, T item2) where T : IComparable
        {
            if (item1.CompareTo(item2) >= 0)
            {
                return item1;
            }

            return item2;
        }
    }

    internal class Program
    {
        public class A
        {
            public A()
            {
            }
        }

        private static void Main(string[] args)
        {
            Utility.Max(1, 2);
            Utility.Max(2.3, 3.2);
        }
    }
}