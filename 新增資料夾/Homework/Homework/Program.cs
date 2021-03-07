using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                    if (args.Length == 0) { Console.WriteLine("必須有參數"); }

                    foreach (string item in args)
                {
                    
                    Console.WriteLine(item);
                }
            }
            catch
            {
                Console.WriteLine("無法讀取參數");
            }
            Console.ReadLine();
        }
    }
}
