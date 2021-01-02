using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            int counter = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    int index = i + 2;
                    counter = 1;
                    while (index < input.Length && input[i] == input[index])
                    {
                        counter++;
                        index++;
                    }
                    input = input.Remove(i + 1, counter);
                    counter = 1;
                }
            }
            Console.WriteLine(input);
        }
    }
}
