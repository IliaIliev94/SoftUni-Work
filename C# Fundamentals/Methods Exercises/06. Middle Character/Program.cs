using System;

namespace _06._Middle_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(middle(input));
        }
        static string middle(string s)
        {
            int length = s.Length;
            string result = "";
            if (s.Length % 2 == 0)
            {
                int middleOne = (s.Length - 1) / 2;
                int middleTwo = s.Length / 2;
                result += s[middleOne].ToString() + s[middleTwo].ToString();
            }
            else
            {
                int middle = s.Length / 2;
                result = s[middle].ToString();
            }
            return result;
        }
    }
}
