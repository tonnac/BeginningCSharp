using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Operator_null
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> list = null;

            Write(list?.Count);

            for (int? i = 0; i < list?.Count; ++i)
            {
                //blahblah
            }

            {
                string[] lines = { "txt", "doc" };
                string firstElement = lines?[0];
            }
            {
                string[] lines = null;
                string firstElement = lines?[0];
            }

            list?.Add(5);
        }
    }
}