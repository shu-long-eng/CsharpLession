using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class TestFileReader
    {
        public static string ReadFile(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("不存在");
                Console.Read();
                return "";
            }

                string con = File.ReadAllText(path);

            return con;
        }

        public static void WriteFile(string path,string content)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("不存在");
                Console.Read();
                return;
            }
            File.WriteAllText(path, content);

        }
        public static void Append(string path, string content)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("不存在");
                Console.Read();
                return;
            }

            string time = DateTime.Now.ToString("yyyy/MM/dd" +
                "HH:mm:ss");

            content = System.Environment.NewLine+time+"    " + content;

            File.AppendAllText(path, content);
        }

    }
}
