using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while(!input.Equals("end"))
            {
                string newString = new string("");
                for (int j = input.Length - 1; j >= 0; j--)
                {
                    newString = string.Concat(newString, input[j]);
                }
                Console.WriteLine($"{input} = {newString}");
                input = Console.ReadLine();
            }
        }
    }
}
