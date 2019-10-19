using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace Regex_
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^01[01678]-[0-9]{4}-[0-9]{4}$");
            Regex regex0 = new Regex(@"^[a-z]{1,3}-[a-z]{4}-[a-z]{4}$");
            Regex regex1 = new Regex(@"^([a-z]{1,})|([0-9]{1,})|([!@]{2,})");


            string password = "010-1293-1234";
            string password0 = "asgfd-abcd-abcd";
            string password1 = "!@as123";

            if(regex1.IsMatch(password1))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
