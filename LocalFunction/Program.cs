using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunction
{
    internal delegate (bool, int) MyDivide(int a, int b);

    internal class Program
    {
        //할때마다 델리게이트 만들어야되네
        private void AnynomousMethodTest()
        {
            MyDivide func = delegate (int a, int b)
            {
                if (b == 0) { return (false, 0); }
                return (true, a / b);
            };
        }

        //로컬메소드면 해결
        private void LocalFuncTest()
        {
            (bool, int) func(int a, int b)
            {
                if (b == 0) { return (false, 0); }
                return (true, a / b);
            }

            func(10, 5);
        }

        private void LocalLambdaFuncTest()
        {
            (bool, int) func(int a, int b) => (b == 0) ? (false, 0) : (true, a / b);

            func(10, 5);
        }

        private static void Main(string[] args)
        {
        }
    }
}