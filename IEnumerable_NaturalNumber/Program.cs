using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IEnumerable_NaturalNumber
{
    internal class NaturalNumber : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new NaturalNumberEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new NaturalNumberEnumerator();
        }

        public class NaturalNumberEnumerator : IEnumerator<int>
        {
            private int _current;

            public int Current
            {
                get { return _current; }
            }

            object IEnumerator.Current
            {
                get { return _current; }
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                _current++;
                return true;
            }

            public void Reset()
            {
                _current = 0;
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            NaturalNumber number = new NaturalNumber();

            foreach (int n in number)
            {
                Console.WriteLine(n);
            }
        }
    }
}