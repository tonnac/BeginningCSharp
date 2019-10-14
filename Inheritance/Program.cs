using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.Boot();

            //Casting
            Computer pc1 = new Computer();
            Notebook noteb = (Notebook)pc1;
        }
    }
}
