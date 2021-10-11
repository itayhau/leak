using System;
using System.Collections.Generic;
using System.Threading;

namespace Leaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Waiting...");
            Thread.Sleep(30 * 1000);
            Console.WriteLine("Starting to overload memory now...");
            List<int> list = new List<int>();
            while (true)
            {
                list.Add(1234567890);
            }
        }
    }
}
