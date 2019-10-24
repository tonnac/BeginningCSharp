using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace CallerInfomation
{
    internal class Program
    {
        private static void LogMessage(string text,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string filePath = "",
            [CallerLineNumber] int lineNumber = 0)
        {
            Console.WriteLine("텍스트: " + text);
            Console.WriteLine("Method Name: " + memberName);
            Console.WriteLine("File Path: " + filePath);
            Console.WriteLine("Line Number: " + lineNumber);
        }

        private static void Main(string[] args)
        {
            LogMessage("테스트로그");
        }
    }
}