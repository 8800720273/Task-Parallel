using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingApp
{
    class LockClass
    {
      public  void Lck()
        {
            lock(this)
            {
                for(int i = 1;i <5;i++ )
                {
                    Console.WriteLine("lock{0}",i);
                    Thread.Sleep(1000);
                }
            }
        }
    }
    class Thread6
    {
        static void Main(string[] args)
        {
            LockClass lc = new LockClass();
            Thread t = new Thread(new ThreadStart(lc.Lck));
            Thread t1 = new Thread(new ThreadStart(lc.Lck));
            t.Start();
            t1.Start();
            Console.ReadKey();
        }
    }
}
