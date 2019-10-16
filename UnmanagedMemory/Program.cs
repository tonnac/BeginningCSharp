using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace UnmanagedMemory
{
    class UnmanagedMemoryManager : IDisposable
    {

        IntPtr pBuffer;
        bool _disposed;

        public UnmanagedMemoryManager()
        {
            pBuffer = Marshal.AllocCoTaskMem(4096 * 1024);
        }
        public void Dispose()
        {
            Dispose(false);
        }

        public void Dispose(bool disposing)
        {
            if (_disposed == false)
            {
                Marshal.FreeCoTaskMem(pBuffer);
                _disposed = true;
            }

            if(disposing == false)
            {
                GC.SuppressFinalize(this);
            }
        }

        ~UnmanagedMemoryManager()
        {
            Dispose(true);
        }

    }
    class Program
    {
        static int number = 0;

        static void Main(string[] args)
        {
            //while(true)
            //{
            //    using (UnmanagedMemoryManager m = new UnmanagedMemoryManager())
            //    {
            //    }
            //    Console.WriteLine(++number + " : " + Process.GetCurrentProcess().PrivateMemorySize64);
            //}

            while (true)
            {
                UnmanagedMemoryManager m = new UnmanagedMemoryManager();
                m = null;

                GC.Collect();
                Console.WriteLine(++number + " : " + Process.GetCurrentProcess().PrivateMemorySize64);
            }

        }
    }

}
