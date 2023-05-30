using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(func);

            myThread.Start();

            

            Console.Read();

        }
        static void func()
        {
            while (true)
            {
                Console.WriteLine("thread 2 ");
                Thread.Sleep(1000);
            }
        }
    }
}
