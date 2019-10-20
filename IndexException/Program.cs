using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexException
{
    internal class ArrayNoException<T>
    {
        private int _size;
        private T[] _items;

        public ArrayNoException(int size)
        {
            _size = size;
            _items = new T[size];
        }

        public T this[int index]
        {
            get
            {
                if (index >= _size)
                {
                    return default(T);
                }

                return _items[index];
            }

            set
            {
                if (index >= _size)
                {
                    return;
                }

                _items[index] = value;
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            ArrayNoException<int> list = new ArrayNoException<int>(10);

            list[10] = 5;
            Console.WriteLine(list[10]);
        }
    }
}