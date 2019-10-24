using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Threading;

namespace ASync_AWait
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AwaitRead();
            Console.ReadLine();
        }

        private static async void AwaitRead()
        {
            using (FileStream fs = new FileStream(@"C:\windows\system32\drivers\etc\HOSTS", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                byte[] buf = new byte[fs.Length];
                Console.WriteLine("Before ReadASync: " + Thread.CurrentThread.ManagedThreadId);
                await fs.ReadAsync(buf, 0, buf.Length);
                Console.WriteLine("After ReadASync: " + Thread.CurrentThread.ManagedThreadId);

                string txt = Encoding.UTF8.GetString(buf);
                Console.WriteLine(txt);
            }
        }
    }
}