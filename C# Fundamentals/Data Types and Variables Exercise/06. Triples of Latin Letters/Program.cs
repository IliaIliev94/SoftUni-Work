using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()) + 97;

            for (char i = (char)97; i < num; i++)
            {
                for (char j = (char)97; j < num; j++)
                {
                    for (char k = (char)97; k < num; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
