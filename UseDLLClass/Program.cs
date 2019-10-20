using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;

namespace UseDLLClass
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFrom("AppDomainDLL.dll");
            Type systemInfoType = asm.GetType("Reflection_Example.SystemInfo");

            ConstructorInfo ctor = systemInfoType.GetConstructor(Type.EmptyTypes);
            object objInstance = ctor.Invoke(null);

            MethodInfo methodInfo = systemInfoType.GetMethod("WriteInfo");
            methodInfo.Invoke(objInstance, null);

            FieldInfo fieldInfo = systemInfoType.GetField("_is64Bit", BindingFlags.NonPublic | BindingFlags.Instance);
            object oldValue = fieldInfo.GetValue(objInstance);

            fieldInfo.SetValue(objInstance, !Environment.Is64BitOperatingSystem);

            methodInfo.Invoke(objInstance, null);
        }
    }
}