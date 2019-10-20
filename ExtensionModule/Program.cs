using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Reflection;

namespace ExtensionModule
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string pluginFolder = @".\plugin";
            if (Directory.Exists(pluginFolder) == true)
            {
                ProcessPlugin(pluginFolder);
            }
        }

        private static void ProcessPlugin(string rootPath)
        {
            foreach (string dllPath in Directory.EnumerateFiles(rootPath, "*.dll"))
            {
                Assembly pluginDll = Assembly.LoadFrom(dllPath);

                Type entryType = FindEntryType(pluginDll);

                if (entryType == null)
                {
                    continue;
                }

                object instance = Activator.CreateInstance(entryType);

                MethodInfo entryMethod = FindStartupMethod(entryType);
                if (entryMethod == null)
                {
                    continue;
                }

                entryMethod.Invoke(instance, null);
            }
        }

        private static Type FindEntryType(Assembly pluginDll)
        {
            foreach (Type type in pluginDll.GetTypes())
            {
                foreach (object objAttr in type.GetCustomAttributes(false))
                {
                    if (objAttr.GetType().Name == "PluginAttribute")
                    {
                        return type;
                    }
                }
            }

            return null;
        }

        private static MethodInfo FindStartupMethod(Type entryType)
        {
            foreach (MethodInfo methodInfo in entryType.GetMethods())
            {
                foreach (object objAttribute in methodInfo.GetCustomAttributes(false))
                {
                    if (objAttribute.GetType().Name == "StartupAttribute")
                    {
                        return methodInfo;
                    }
                }
            }
            return null;
        }
    }
}