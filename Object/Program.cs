using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Inheritance;

namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToString
            Program program = new Program();
            Console.WriteLine(program.ToString() + "\n");

            //GetType
            Computer computer = new Computer();
            Type type = computer.GetType();

            Console.WriteLine(type.FullName);
            Console.WriteLine(type.IsClass);
            Console.WriteLine(type.IsArray + "\n");

            //typeof
            Type type1 = typeof(double);
            Console.WriteLine(type1.FullName);
            Console.WriteLine(typeof(System.Int16).FullName + "\n");

            //equals
            int n = 5;
            Console.WriteLine(n.Equals(5));

            //클래스는 포인터 주소로 비교를한다(디폴트)
            Notebook notebook0 = new Notebook();
            Notebook notebook1 = new Notebook();

            Console.WriteLine(notebook0.Equals(notebook1) + "\n");

            //스트링은 재정의해서 문자열을 비교한다
            string txt1 = new string(new char[] { 't', 'e', 'x', 't' });
            string txt2 = new string(new char[] { 't', 'e', 'x', 't' });

            Console.WriteLine(txt1.Equals(txt2) + "\n");

            //Gethashcode
            short n1 = 256;
            short n2 = 32750;
            short n3 = 256;

            Console.WriteLine(n1.GetHashCode());
            Console.WriteLine(n2.GetHashCode());
            Console.WriteLine(n3.GetHashCode() + "\n");

            Console.WriteLine(notebook0.GetHashCode());
            Console.WriteLine(notebook1.GetHashCode());
        }
    }
}
