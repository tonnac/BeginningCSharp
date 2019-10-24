using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ASync_Parallel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Sync

            //int result3 = Method3();
            //int result5 = Method5();
            //Console.WriteLine(result3 + result5);

            #endregion Sync

            #region Thread

            //Dictionary<string, int> dict = new Dictionary<string, int>();

            //Thread t3 = new Thread((result) =>
            //{
            //    Thread.Sleep(3000);
            //    dict.Add("t3Result", 3);
            //});

            //Thread t5 = new Thread((result) =>
            //{
            //    Thread.Sleep(5000);
            //    dict.Add("t5Result", 5);
            //});

            //t3.Start(dict);
            //t5.Start(dict);

            //t3.Join();
            //t5.Join();

            //Console.WriteLine($"{dict["t3Result"] + dict["t5Result"]}");

            #endregion Thread

            #region Task

            //Task<int> task3 = Method3ASync();
            //Task<int> task5 = Method5ASync();

            //Task.WaitAll(task3, task5);
            //Console.WriteLine(task3.Result + task5.Result);

            #endregion Task

            #region ASync / AWait

            DoASyncTask();

            Console.ReadLine();

            #endregion ASync / AWait
        }

        private static int Method3()
        {
            Thread.Sleep(3000);
            return 3;
        }

        private static int Method5()
        {
            Thread.Sleep(5000);
            return 5;
        }

        private static Task<int> Method3ASync()
        {
            return Task.Factory.StartNew<int>(() =>
            {
                Thread.Sleep(3000);
                return 3;
            });
        }

        private static Task<int> Method5ASync()
        {
            return Task.Factory.StartNew<int>(() =>
            {
                Thread.Sleep(5000);
                return 5;
            });
        }

        private static async Task DoASyncTask()
        {
            var task3 = Method3ASync();
            var task5 = Method5ASync();

            await Task.WhenAll(task3, task5);

            Console.WriteLine(task3.Result + task5.Result);
        }
    }
}