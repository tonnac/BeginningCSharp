using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = string.Format("{0:#,###}", 126378216);

            Console.WriteLine(a);
        }
    }
}