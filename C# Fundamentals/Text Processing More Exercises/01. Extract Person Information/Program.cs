using System;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string name = new string("");
                string age = new string("");
                int index = input.IndexOf('@');
                for (int j = index + 1; input[j] != '|'; j++)
                {
                    name += input[j];
                }
                index = input.IndexOf('#');
                for (int j = index + 1; input[j] != '*'; j++)
                {
                    age += input[j];
                }
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
