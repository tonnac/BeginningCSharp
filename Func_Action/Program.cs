using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Action
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Action<string> logOut =
                (txt) =>
                {
                    Console.WriteLine(DateTime.Now + ": " + txt);
                };

            logOut("This is My World");

            Func<double> pi = () => 3.141592;

            Func<int, int, int> myFunc = (a, b) => a + b;
        }
    }
}