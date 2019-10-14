using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate3_SelectionSort
{
    class SortObject
    {
        int[] numbers;

        public delegate bool CompareDelegate(int arg1, int arg2);

        public SortObject(int[] numbers)
        {
            this.numbers = numbers;
        }

        public int[] Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }
        public void Sort(CompareDelegate compareMethod)
        {
            int temp;

            for(int i=0; i<numbers.Length; ++i)
            {
                int lowPos = i;

                for(int j = i + 1; j<numbers.Length; ++j)
                {
                    if (compareMethod(numbers[j], numbers[lowPos]))
                    {
                        lowPos = j;
                    }
                }

                temp = numbers[lowPos];
                numbers[lowPos] = numbers[i];
                numbers[i] = temp;
            }
        }
        public void Display()
        {
            foreach (int element in numbers)
            {
                Console.Write(element + ", ");
            }
        }
    }

    class Program
    {
        public static bool AscendingCompare(int arg1, int arg2)
        {
            return (arg1 < arg2);
        }

        static bool DescendingCompare(int arg1, int arg2)
        {
            return (arg1 > arg2);
        }

        static void Main(string[] args)
        {
            int[] intArray = new int[] { 5, 2, 3, 1, 0, 4 };

            SortObject so = new SortObject(intArray);
            so.Sort(AscendingCompare);
            so.Display();

            Console.WriteLine();
            so.Sort(DescendingCompare);
            so.Display();
        }
    }
}
