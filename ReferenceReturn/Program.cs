using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceReturn
{
    internal class IntList
    {
        private int[] list = new int[2] { 1, 2 };

        public int[] GetList()
        {
            return list;
        }

        internal void Print()
        {
            Array.ForEach(list, (e) => Console.Write(e + ", "));
            Console.WriteLine();
        }

        public ref int GetFirstItem()
        {
            return ref list[0];
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            int a = 5;
            ref int b = ref a;

            b = 6;

            {
                IntList intList = new IntList();
                int[] list = intList.GetList();
                list[0] = 5;

                intList.Print();
            }

            {
                IntList intList = new IntList();
                ref int item = ref intList.GetFirstItem();
                item = 5;

                intList.Print();
            }
        }
    }
}