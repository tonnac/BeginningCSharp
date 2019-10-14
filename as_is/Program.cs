using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Inheritance;

namespace as_is
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer pc = new Computer();
            Notebook notebook = pc as Notebook;

            if(notebook != null)
            {
                notebook.CloseLid();
            }

            //             int n = 5;
            //             if((n as string) != null)

            int n = 5;
            if(n is string)
            {
                Console.WriteLine("n is string");
            }

        }
    }
}
