﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilestreamClose
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FileCreate();

            Console.WriteLine("File Open");
            Console.ReadLine();
        }

        private static void FileCreate()
        {
            FileStream fs = new FileStream("output.log", FileMode.Create);
            fs.Dispose();
        }
    }
}