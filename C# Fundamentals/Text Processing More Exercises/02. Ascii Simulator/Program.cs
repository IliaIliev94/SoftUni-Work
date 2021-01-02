using System;

namespace _02._Ascii_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = Console.ReadLine()[0];
            char second = Console.ReadLine()[0];
            string input = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > first && input[i] < second)
                {
                    sum += (int)input[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
