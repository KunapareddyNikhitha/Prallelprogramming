﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Parallelprogramming
{
    class Program
    {
        //static void Main()
        //{
        //    Stopwatch stopwatch = new Stopwatch();

        //    Console.WriteLine("Parallel Foreach Loop Started");
        //    stopwatch.Start();
        //    List<int> integerList = Enumerable.Range(1, 10).ToList();

        //    Parallel.ForEach(integerList, i =>
        //    {
        //        long total = DoSomeIndependentTimeconsumingTask();
        //        Console.WriteLine("{0} - {1}", i, total);
        //    });
        //    Console.WriteLine("Parallel Foreach Loop Ended");
        //    stopwatch.Stop();

        //    Console.WriteLine($"Time Taken by Parallel Foreach Loop in Miliseconds {stopwatch.ElapsedMilliseconds}");
        //    Console.ReadLine();
        //}

        //static long DoSomeIndependentTimeconsumingTask()
        //{
        //    //Do Some Time Consuming Task here
        //    long total = 0;
        //    for (int i = 1; i < 100000000; i++)
        //    {
        //        total += i;
        //    }
        //    return total;
        //}
        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Standard Foreach Loop Started");
            stopwatch.Start();
            List<int> integerList = Enumerable.Range(1, 10).ToList();
            foreach (int i in integerList)
            {
                long total = DoSomeIndependentTimeconsumingTask();
                Console.WriteLine("{0} - {1}", i, total);
            };

            Console.WriteLine("Standard Foreach Loop Ended");
            stopwatch.Stop();

            Console.WriteLine($"Time Taken by Standard Foreach Loop in Miliseconds {stopwatch.ElapsedMilliseconds}");
            Console.ReadLine();
        }

        static long DoSomeIndependentTimeconsumingTask()
        {
            //Do Some Time Consuming Task here
            long total = 0;
            for (int i = 1; i < 100000000; i++)
            {
                total += i;
            }
            return total;
        }
    }
}