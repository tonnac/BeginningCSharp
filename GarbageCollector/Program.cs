﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            object pg = new object();
            Console.WriteLine(GC.GetGeneration(pg));

            GC.Collect();
            Console.WriteLine(GC.GetGeneration(pg));

            GC.Collect();
            Console.WriteLine(GC.GetGeneration(pg));

            GC.Collect();
            Console.WriteLine(GC.GetGeneration(pg));

            Console.WriteLine(GC.GetTotalMemory(true));
        }
    }
}
