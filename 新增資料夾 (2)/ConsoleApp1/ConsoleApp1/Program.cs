using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hellow();
            Hellow();

            double a = my(20, 0);
            int b = Add(5, 7);

            Console.WriteLine(1/0);
            Console.WriteLine(b);

            try
            {
                Console.WriteLine(a);
            }
            catch (Exception e)
            {
                Console.WriteLine("error");
            }
            finally
            {
                Console.WriteLine("end");
            }




            Console.Read();
        }

        static void Hellow()
        {
            Console.WriteLine("Hellow, word");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static double my(double a, double b)
        {
           // Console.WriteLine(a / b);
            return a / b;
        }


    }
}
