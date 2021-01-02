using System;

namespace _01._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string result = new string("");
            for (int i = 0; i < input.Length; i++)
            {
                int length = input[i].Length;
                for (int j = 0; j < length; j++)
                {
                    result += input[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
