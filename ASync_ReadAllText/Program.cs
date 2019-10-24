using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ASync_ReadAllText
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string filePath = @"C:\Windows\system32\drivers\etc\HOSTS";

            #region ASync

            //ee = new ReadAllTextDeletgate(File.ReadAllText);
            //ee.BeginInvoke(filePath, ActionCompleted, ee);

            #endregion ASync

            #region Task

            AwaitFileRead(filePath);

            #endregion Task

            Console.Read();
        }

        #region ASync

        public delegate string ReadAllTextDeletgate(string path);

        static public event ReadAllTextDeletgate ee;

        private static void ActionCompleted(IAsyncResult ar)
        {
            ReadAllTextDeletgate func = ar.AsyncState as ReadAllTextDeletgate;
            string fileText = func.EndInvoke(ar);

            Console.WriteLine(fileText);
        }

        #endregion ASync

        #region Task

        private static Task<string> ReadAllTextASync(string filePath)
        {
            return Task.Factory.StartNew(() =>
            {
                return File.ReadAllText(filePath);
            });
        }

        private static async Task AwaitFileRead(string filePath)
        {
            string fileText = await ReadAllTextASync(filePath);
            Console.WriteLine(fileText);
        }

        #endregion Task
    }
}