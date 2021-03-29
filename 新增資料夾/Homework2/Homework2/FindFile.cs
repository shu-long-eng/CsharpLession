using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework2
{
    class FindFile
    {
        public static string FileReader(string path)
        {
            if (!File.Exists(path)) { Console.WriteLine("檔案不存在");return ""; }

            string str = File.ReadAllText(path);

            return str;
        }
    }
}
