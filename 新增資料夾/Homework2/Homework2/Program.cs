using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\專案\\";
            string name = Console.ReadLine();

            string str = FindFile.FileReader(path + name);
            Console.WriteLine(str);

            Console.Read();

        }
    }
}
