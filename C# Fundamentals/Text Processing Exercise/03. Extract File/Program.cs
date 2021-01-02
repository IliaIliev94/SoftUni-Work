using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');
            string[] result = input[input.Length - 1].Split('.');
            Console.WriteLine($"File name: {result[0]}");
            Console.WriteLine($"File extension: {result[1]}");
        }
    }
}
