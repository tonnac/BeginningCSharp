using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using static System.Console;

namespace Sync_Webclient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WebClient wc = new WebClient();

            #region Sync

            //string text = wc.DownloadString("http://www.microsoft.com");
            //Console.WriteLine(text);

            #endregion Sync

            #region ASync

            //wc.DownloadStringCompleted += wc_DownloadStringCompleted;
            //wc.DownloadStringAsync(new Uri("http://www.microsoft.com"));
            //Console.ReadLine();

            #endregion ASync

            #region ASync / AWait

            AwaitDownloadString();
            Console.ReadLine();

            #endregion ASync / AWait
        }

        private static void wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            Console.WriteLine(e.Result);
        }

        private static async void AwaitDownloadString()
        {
            WebClient wc = new WebClient();

            WriteLine(Thread.CurrentThread.ManagedThreadId);
            string text = await wc.DownloadStringTaskAsync("http://www.microsoft.com");
            WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(text);
        }
    }
}