using System;
using System.Diagnostics;
using System.Threading;

namespace StopWatchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(10000);
            stopwatch.Stop();
            TimeSpan timespan = stopwatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                timespan.Hours, timespan.Minutes, timespan.Seconds, timespan.Milliseconds/10);
            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine("Raw output: " + stopwatch.Elapsed.ToString());
            Console.WriteLine(stopwatch.ElapsedTicks + " Ticks");
        }
    }
}
