using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime startTime = DateTime.Now;
            //Console.WriteLine("開始");
            ////SleepHelper.SleepAWhile(1);

            //DateTime endTime = DateTime.Now;
            //TimeSpan sp = endTime - startTime;
            //Console.WriteLine($"花費{sp}秒");

            //DateTime a = DateTime.Now;
            //Console.WriteLine(a);

            //a = a.AddHours(2);
            //Console.WriteLine(a);

            Random r = new Random();
            int rr = r.Next(1, 5);


            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            Console.WriteLine("開始");
            sw.Start();
            SleepHelper.SleepAWhile(rr);
            sw.Stop();
            //sw.Reset();
            Console.WriteLine((double)sw.ElapsedMilliseconds/1000);


            Console.ReadLine();

        }
    }
}
