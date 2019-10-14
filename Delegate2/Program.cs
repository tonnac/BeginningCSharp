using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{
    class Program
    {
        delegate int GetResultDelegate();

        class Target
        {
            public void Do(GetResultDelegate getResult)
            {
                Console.WriteLine(getResult());
            }
        }

        class Source
        {
            public int GetResult()
            {
                return 10;
            }
            public void Test()
            {
                Target target = new Target();
                target.Do(GetResult);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
