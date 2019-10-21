using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExtension
{
    internal static class ExtensionMethodSample
    {
        public static int GetWordCount(this string txt)
        {
            return txt.Split(' ').Length;
        }

        public static int GetInt(this int ra)
        {
            return ra;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            string text = "Hello World";
            Console.WriteLine("Count: " + text.GetWordCount());

            int p = 50;
            p.GetInt();
        }
    }
}