using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckTyping
{
    internal class Program
    {
        static public int DuckTypingCall(dynamic target, dynamic item)
        {
            return target.IndexOf(item);
        }

        private static void Main(string[] args)
        {
            string txt = "test func";
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine(DuckTypingCall(txt, "test"));
            Console.WriteLine(DuckTypingCall(list, 3));
        }
    }
}