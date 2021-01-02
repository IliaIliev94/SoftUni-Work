using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            for (int i = 0; i < 3; i++)
            {
                input += Console.ReadLine();
            }
            Console.WriteLine(input);
        }
    }
}
