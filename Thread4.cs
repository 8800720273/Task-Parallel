using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingApp
{
    public class Wedding
    {
        public void Venue()
        {
            for(int i = 0;i < 10;i++)
            {
                Console.WriteLine("Venue Decesion {0} ",+i);
            }
        }
        public void WeddingCard()
        {
            for(int i = 1;i<5;i++)
            {
                Console.WriteLine("Wedding Card Printing {0}",+ i);
            }
            
        }
        public void WeddingCardDistribution()
        {
            for(int i = 1;i < 10;i++)
            {
                Console.WriteLine("Wedding card Distribution {0}",+ i);
            }
            
        }
    }
    class Thread4
    {
        static void Main(string[] args)
        {
            Wedding wed = new Wedding();
            Thread t = new Thread(new ThreadStart(wed.Venue));
            Thread th = new Thread(new ThreadStart(wed.WeddingCard));
            Thread th1 = new Thread(new ThreadStart(wed.WeddingCardDistribution));
            t.Name = "Venue";
            th.Name = "Wedding Card Printing....";
            th1.Name = "Wedding Card Distribution";
            Console.WriteLine("Thread Name  "  +t.Name);
            Console.WriteLine("Thread Name   "+th.Name);
            Console.WriteLine("Thread Name    "+th1.Name);
            t.Start();
            t.Join();
            th.Start();
            th.Join();
            th1.Start();
            Thread4 ts = new Thread4();

            
            Console.ReadKey();
        }
    }
}
