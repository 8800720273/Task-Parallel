using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingApp
{
    class Mythread1
    {
        public  void Run1()
        {
            for(int i = 0;i < 10;i++)
            {
                Console.WriteLine("Run 1 {0}",i);
                Thread.Sleep(10);
            }
        }
        public void Run2()
        {
            for(int j = 0;j < 10;j++)
            {
                Console.WriteLine("Run 2 {0}",j);
            }
        }
    }
    class Thread3
    {
        static void Main(string[] args)
        {
            Mythread1 t = new Mythread1();
            ThreadStart ts = new ThreadStart(t.Run1);
            Thread th = new Thread(ts);
           ThreadStart ts1 = new ThreadStart(t.Run2);
           Thread th1 = new Thread(ts1);
            th.Start();
            th1.Start();
            Console.WriteLine("Current Thread ID"+th.ManagedThreadId);
            Console.WriteLine("Current Thread ID"+th1.ManagedThreadId);
            try
            {
                th.Abort();
                th1.Abort();
            }
            catch(ThreadAbortException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
             
        }
    }
}
