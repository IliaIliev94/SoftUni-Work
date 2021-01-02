using System;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../input.txt");
            for(int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine($"Line {i}:{lines[i]} ({LetterCount(lines[i])})({PunctuationCount(lines[i])})");
            }
        }

        static int LetterCount(string s)
        {
            int count = 0;
            foreach(char character in s)
            {
                if(char.IsLetter(character))
                {
                    count++;
                }
            }
            return count;
        }

        static int PunctuationCount(string s)
        {
            int count = 0;
            foreach(char character in s)
            {
                if(char.IsPunctuation(character))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
