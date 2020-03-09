using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Railway
{
    public class FileHandler
    {
        public static string[] ReadFile(string path)
        {
            return File.ReadAllLines(path);
        }

        public static string[] SplitData(string line)
        {
           return line.Split(';', ',', ':');
        }


    }
}
