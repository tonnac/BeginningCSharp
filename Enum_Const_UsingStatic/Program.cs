using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
using static MyDay;
using static BitMode;

public enum MyDay
{
    Saturday, Sunday,
}

public class BitMode
{
    public const int ON = 1;
    public const int OFF = 0;
}

namespace Enum_Const_UsingStatic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyDay day = Saturday;
            int bit = ON;

            WriteLine(day);
            WriteLine(bit);
        }
    }
}