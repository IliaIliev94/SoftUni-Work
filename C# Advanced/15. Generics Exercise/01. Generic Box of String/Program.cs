using System;

namespace _01._Generic_Box_of_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                var newBox = new Box<int>(input);
                Console.WriteLine(newBox);
            }
        }
    }
}
