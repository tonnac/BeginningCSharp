using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Nullable<int> intValue = 10;

            int target = intValue.Value;

            double? temp = null;

            Console.WriteLine(temp.HasValue);

            temp = 3.141592;
            Console.WriteLine(temp.HasValue);
            Console.WriteLine(temp.Value);
        }
    }
}