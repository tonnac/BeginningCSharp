using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;

namespace Reflection_Example
{
    public class SystemInfo
    {
        private bool _is64Bit;

        public SystemInfo()
        {
            _is64Bit = Environment.Is64BitOperatingSystem;
            Console.WriteLine("SystemInfo created.");
        }

        public void WriteInfo()
        {
            Console.WriteLine("OS == {0}bits", (_is64Bit == true) ? "64" : "32");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            //            SystemInfo sysInfo = new SystemInfo();
            //            sysInfo.WriteInfo();

            Type systemInfoType = Type.GetType("Reflection_Example.SystemInfo");
            ConstructorInfo ctorInfo = systemInfoType.GetConstructor(Type.EmptyTypes);
            //object objInstance = Activator.CreateInstance(systemInfoType);
            object objInstance = ctorInfo.Invoke(null);

            MethodInfo methodInfo = systemInfoType.GetMethod("WriteInfo");
            methodInfo.Invoke(objInstance, null);

            #region Private Fields Access

            FieldInfo fieldInfo = systemInfoType.GetField("_is64Bit", BindingFlags.NonPublic | BindingFlags.Instance);
            fieldInfo.SetValue(objInstance, !Environment.Is64BitOperatingSystem);
            methodInfo.Invoke(objInstance, null);

            #endregion Private Fields Access
        }
    }
}