using System;
using System.Threading;

namespace ThreadingApp
{
    class Mythread
    {
        public static  void Thread1()
        {
            for(int i = 1;i < 10;i++)
            {
                Console.WriteLine("Child thread {0}",i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(Mythread.Thread1));
            Thread t1 = new Thread(new ThreadStart(Mythread.Thread1));
            t.Start();
            t1.Start();
            t.Name = "hello";
            Console.WriteLine("Current Thread Name  "+t.Name);
            t.Priority = ThreadPriority.Highest;
            Console.WriteLine("Thread Prority  "+t.Priority);
            Console.ReadKey();

        }
    }
}
