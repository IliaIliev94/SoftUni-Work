using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = Console.ReadLine()[0];
            char b = Console.ReadLine()[0];
            Console.WriteLine(string.Join(" ", charactersBetween(a, b)));
        }
        static char[] charactersBetween(char a, char b)
        {
            int difference = (int)Math.Abs(Math.Min(a, b) - Math.Max(a, b)) - 1;
            char[] characters = new char[difference];
            int count = 0;
            for (char i = (char)(int)((double)Math.Min(a, b) + 1); i < (char)(int)(double)Math.Max(a, b); i++)
            {
                characters[count] = (char)i;
                count++;
            }
            return characters;
        }
    }
}
