using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = ConfigurationManager.AppSettings["SourceFilePath"];
            string targetPath = ConfigurationManager.AppSettings["TargetFiledPath"];
            Console.WriteLine(" " + sourcePath);
            Console.WriteLine(" " + targetPath);
            Console.ReadLine();
        }
    }
}
