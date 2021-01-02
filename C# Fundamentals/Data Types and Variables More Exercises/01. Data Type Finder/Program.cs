using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int i;
            float j;
            char c;
            bool b;

            while(!command.Equals("END"))
            {
                if (int.TryParse(command, out i))
                {
                    Console.WriteLine($"{command} is integer type");
                }
                else if (float.TryParse(command, out j))
                {
                    Console.WriteLine($"{command} is floating point type");
                }
                else if (char.TryParse(command, out c))
                {
                    Console.WriteLine($"{command} is character type");
                }
                else if (bool.TryParse(command, out b))
                {
                    Console.WriteLine($"{command} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{command} is string type");
                }
                command = Console.ReadLine();
            }
        }
    }
}
