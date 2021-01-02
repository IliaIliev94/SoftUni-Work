using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result = vowelsCount(input);
            Console.WriteLine(result);
        }
        static int vowelsCount(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char letter = Char.ToLower(s[i]);
                if (letter == 'a' || letter == 'e' || letter == 'u' || letter == 'o' || letter == 'i')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
