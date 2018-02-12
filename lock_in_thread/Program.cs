/*
 *  C# Program to Demonstrate Lock in Thread
 */

using System;
using System.Threading;

namespace lock_in_thread
{
    class Program
    {
        static readonly object _object = new object();

        static void TEST()
        {
            lock (_object)
            {
                Thread.Sleep(100);
                Console.WriteLine(Environment.TickCount);
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadStart start = new ThreadStart(TEST);
                new Thread(start).Start();
            }
        }
    }
}
