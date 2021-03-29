using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class SleepHelper
    {
        public static void SleepAWhile(int second)
        {
            int ms = second * 1000;
            
            System.Threading.Thread.Sleep(ms);//暫停程式ms秒
        }
    }
}
