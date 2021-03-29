﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class Readfile
    {
        public static void ListAllFile(string path)
        {
            if (! Directory.Exists(path))
            {
                Console.WriteLine("不存在");
                Console.Read();
                return;
            }
            string[] folderItems = Directory.GetFileSystemEntries(path);
            foreach(string item in folderItems)
            {
                Console.WriteLine(item);
            }
        }

        public static void CreateFolder(string path)
        {
            if (Directory.Exists(path)) return;

            Directory.CreateDirectory(path);
        }
        public static void DeleteFolder(string path)
        {
            if (!Directory.Exists(path)) return;
            Directory.Delete(path);
        }
    }
}
