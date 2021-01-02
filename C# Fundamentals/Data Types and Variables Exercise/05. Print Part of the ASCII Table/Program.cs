using System;

namespace _05._Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                if (i < end)
                {
                    Console.Write($"{(char)i} ");
                }
                else
                {
                    Console.Write($"{(char)i}");
                }
                
            }
        }
    }
}
