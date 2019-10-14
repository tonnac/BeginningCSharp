using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _04_24_IComparer
{
    class IntegerCompare : IComparer
    {
        public int Compare(object x, object y)
        {
            int xValue = (int)x;
            int yValue = (int)y;

            if(xValue < yValue)
            {
                return -1;
            }
            else if(xValue == yValue)
            {
                return 0;
            }
            return 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 5, 4, 3, 2, 1 };

            Array.Sort(intArray, new IntegerCompare());
            foreach(int item in intArray)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
