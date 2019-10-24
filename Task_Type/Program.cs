using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_Type
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(
                (obj) =>
                {
                    Console.WriteLine("process workitem");
                }, null);

            Task task1 = new Task(
                () =>
                {
                    Console.WriteLine("Process taskitem");
                });

            task1.Start();

            Task task2 = new Task(
                (obj) =>
                {
                    Console.WriteLine("process taskitem(obj)");
                }, null);

            task2.Start();
            // 끝나길 기다림
            task2.Wait();

            //Factory 에서 바로 생성 가능
            Task.Factory.StartNew(() => { Console.WriteLine("process taskitem"); });
            Task.Factory.StartNew((obj) => { Console.WriteLine($"process taskitem(obj) {obj.ToString()}"); }, task2);

            //반환값도 받을수 있다.
            Task<int> task = new Task<int>(
                (obj) =>
                {
                    Random rand = new Random((int)DateTime.Now.Ticks);
                    return rand.Next();
                }, null);

            task.Start();
            task.Wait();

            Console.WriteLine($"숫자 값: {task.Result}");

            //Factory에서 반환값 받는 Task 생성
            Task<int> taskReturn = Task.Factory.StartNew<int>(() => 1);
            taskReturn.Wait();
            Console.WriteLine(taskReturn.Result);

            Console.ReadLine();
        }
    }
}