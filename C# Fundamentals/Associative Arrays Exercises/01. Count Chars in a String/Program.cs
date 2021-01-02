using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<char, int> chars = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    char character = input[i][j];
                    if (chars.ContainsKey(character))
                    {
                        chars[character]++;
                    }
                    else
                    {
                        chars.Add(character, 1);
                    }
                }
            }
            foreach(var item in chars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
