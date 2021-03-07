using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\專案\\";
            string fileName = "TEST.txt";

            //Read file
            string con = TestFileReader.ReadFile(path + fileName);

            Console.WriteLine(con);

            //Append File
            string content = "Hellow";

            TestFileReader.WriteFile(path + fileName, content);

            TestFileReader.Append(path + fileName, content);

            Console.WriteLine(content);


            Readfile.ListAllFile("D:\\");

            Readfile.CreateFolder(path + "NEW");
            Readfile.DeleteFolder(path + "NEW");

            Console.Read();

            ////ex: C:\\Csharp\\aaa.txt
            //string newpath = "C:\\Csharp\\aaa.txt";
            //System.IO.Path.Combine("C:\\Csharp", "aaa.txt"); //C:\\Csharp\\aaa.txt
            //System.IO.Path.GetDirectoryName(path);//F:\\CSharp
            //System.IO.Path.GetFileName(newPath);// aaa.txt

            Console.Read();
        }
    }
}
