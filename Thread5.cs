using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingApp
{
    class Thread5
    {
        public static void Hello()
        {
            Console.WriteLine("Console hELLO");
        }
        static void Main(string[] args)
        {
            //Action delegates
            Task t = new Task(new Action(Hello));
            t.Start();
            //Anonymous function
            Task th = new Task(delegate { Hello();},"task2");
            th.Start();
            //lamda expression
            Task th1 = new Task(() => Hello());
            th1.Start();
            Console.ReadKey();
        }
    }
}
