using System;
using System.Threading;

namespace ThreadingApp
{
    class MyThread
    {
        public void Thread2()
        {
            for(int i = 0;i <10;i++)
            {
                Console.WriteLine("Child {0}",i);
            }
        }
    }
    class Thread2
    {
        static void Main(string[] args)
        {
            MyThread th = new MyThread();
            Thread t = new Thread(new ThreadStart(th.Thread2));
            Thread t1 = new Thread(new ThreadStart(th.Thread2));
            t.Start();
            t1.Start();
            Console.WriteLine("Current Thread Name  "+t.ThreadState);
            Console.WriteLine("Current Thread Priority   "+t.Priority);
            Console.WriteLine("Cureent Thread   "+t.CurrentCulture);
            Console.ReadKey(); 
        }
    }
}
