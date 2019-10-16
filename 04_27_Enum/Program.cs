using System;


namespace Enum_
{
    class Program
    {
        [Flags]
        enum Days
        {
            Sunday = 1, Monday = 2, Tuesday = 4, Wednesday = 8, Thursday = 16, Friday = 32, Saturday = 64
        }

        static void Main(string[] args)
        {
            Days woringDays = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday;

            Console.WriteLine(woringDays.HasFlag(Days.Sunday));

            Days today = Days.Friday;
            Console.WriteLine(woringDays.HasFlag(today));

            Console.WriteLine(woringDays);
        }
    }

}