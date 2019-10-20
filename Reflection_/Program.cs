using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection_
{
    internal class TestClass
    {
        private int a;
        private float b;
        private uint c;

        public int A
        {
            get { return a; }
        }

        public float B
        {
            get { return b; }
        }

        public uint C
        {
            get { return c; }
            set { c = value; }
        }

        public TestClass(int a)
        {
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            Console.WriteLine("Current Domain Name: " + currentDomain.FriendlyName);

            #region Get All

            //foreach (Assembly asm in currentDomain.GetAssemblies())
            //{
            //    Console.WriteLine("A     " + asm.FullName);

            //    foreach (Module module in asm.GetModules())
            //    {
            //        Console.WriteLine("M         " + module.FullyQualifiedName);

            //        foreach (Type type in module.GetTypes())
            //        {
            //            Console.WriteLine("T             " + type.FullName);

            //            foreach (MemberInfo memberInfo in type.GetMembers())
            //            {
            //                Console.WriteLine("I                " + memberInfo.Name);
            //            }
            //        }
            //    }
            //}

            #endregion Get All

            foreach (Assembly asm in currentDomain.GetAssemblies())
            {
                Console.WriteLine("A     " + asm.FullName);

                foreach (Module module in asm.GetModules())
                {
                    Console.WriteLine("M         " + module.FullyQualifiedName);

                    foreach (Type type in module.GetTypes())
                    {
                        Console.WriteLine("T             " + type.FullName);

                        foreach (ConstructorInfo ctorInfo in type.GetConstructors())
                        {
                            Console.WriteLine("Ctor         " + ctorInfo.Name);
                        }

                        foreach (EventInfo eventInfo in type.GetEvents())
                        {
                            Console.WriteLine("Event        " + eventInfo.Name);
                        }

                        foreach (FieldInfo fieldInfo in type.GetFields())
                        {
                            Console.WriteLine("Field        " + fieldInfo.Name);
                        }

                        foreach (MethodInfo methodInfo in type.GetMethods())
                        {
                            Console.WriteLine("Method       " + methodInfo.Name);
                        }

                        foreach (PropertyInfo propertyInfo in type.GetProperties())
                        {
                            Console.WriteLine("Property     " + propertyInfo.Name);
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}