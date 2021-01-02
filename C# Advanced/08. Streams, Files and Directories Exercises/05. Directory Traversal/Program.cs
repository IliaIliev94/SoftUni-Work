using System;
using System.IO;
using System.Collections.Generic;

namespace _05._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> files = new Dictionary<string, Dictionary<string, long>>();
            string[] fileNames = Directory.GetFiles("../../../Directory/");

            string[] names = new string[fileNames.Length];
            for(int i = 0; i < names.Length; i++)
            {
                string[] temp = fileNames[i].Split("/");
                names[i] = temp[temp.Length - 1];
            }

            foreach(string name in names)
            {
                string[] data = name.Split(".");
                if(files.ContainsKey(data[1]))
                {
                    files[data[1]].Add(name, Size(name));
                }
                else
                {
                    Dictionary<string, long> temp = new Dictionary<string, long>();
                    temp.Add(name, Size(name));
                    files.Add(data[1], temp);
                }
            }

            foreach(var item in files)
            {
                Console.WriteLine($".{item.Key}");
                foreach(var file in item.Value)
                {
                    Console.WriteLine($"--{file.Key} - {(file.Value * 1.0/1000)}kb");
                }
            }
        }
        static long Size(string path)
        {
            var fileStream = new FileStream("../../../Directory/" + path, FileMode.Open);
            return fileStream.Length;
        }
    }
}
