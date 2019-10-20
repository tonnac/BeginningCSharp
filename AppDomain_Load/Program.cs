using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using System.Runtime.Remoting;

namespace AppDomain_Load
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AppDomain newAppDomain = AppDomain.CreateDomain("MyAppDomain");

            string dllPath = "AppDomainDLL.dll";

            ObjectHandle objHandle = newAppDomain.CreateInstanceFrom(dllPath, "ClassLibrary1.Class1");

            Console.ReadLine();

            AppDomain.Unload(newAppDomain);

            Console.WriteLine("지워");
            Console.ReadLine();
        }
    }
}