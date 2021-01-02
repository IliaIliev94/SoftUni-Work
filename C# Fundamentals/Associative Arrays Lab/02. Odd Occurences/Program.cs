using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Odd_Occurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<string, int> words = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                string key = input[i].ToLower();
                if (words.ContainsKey(key))
                {
                    words[key]++;
                }
                else
                {
                    words.Add(key, 1);
                }
            }

            List<string> oddWords = words.Where(x => x.Value % 2 != 0).Select(x => x.Key).ToList();
            Console.WriteLine(string.Join(" ", oddWords));
        }
    }
}
