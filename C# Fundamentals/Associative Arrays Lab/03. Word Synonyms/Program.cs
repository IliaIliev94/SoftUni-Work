using System;
using System.Collections.Generic;

namespace _02._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> words = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();

                if (words.ContainsKey(key))
                {
                    words[key] = words[key].Insert(words[key].Length,", " + value);
                }
                else
                {
                    words.Add(key, value);
                }
            }
            foreach(var item in words)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
