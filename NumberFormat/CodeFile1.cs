#define A

using System;


namespace ConsoleApp1
{
    class Program
    {
#if A
        static int d = 5;
#else
        static int d = 4;
#endif
        static void Main(string[] args)
        {
//            uint a = 2390000;
            uint a = 0;

            var b = a % 10000; // 천단위
            var c = (a % 100000000) / 10000;
            var d = (a % 1000000000000) / 100000000;

            string completeString = string.Empty;

            if(d != 0)
            {
                string qwe = string.Format("{0}억", d);

                completeString += qwe;
            }
            if(c != 0)
            {
                string qwe = string.Format("{0}만", c);

                completeString += qwe;
            }
            if(b != 0)
            {
                string qwe = string.Format("{0}원", b);

                completeString += qwe;
            }
            else
            {
                completeString += "원";
            }

        }

    }

}