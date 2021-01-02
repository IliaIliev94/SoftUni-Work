using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int divisor = 0;
            if (num % 10 == 0)
            {
                divisor = 10;
            }
            else if (num % 7 == 0)
            {
                divisor = 7;
            }
            else if (num % 6 == 0)
            {
                divisor = 6;
            }
            else if (num % 3 == 0)
            {
                divisor = 3;
            }
            else if (num % 2 == 0)
            {
                divisor = 2;
            }

            if (divisor != 0)
            {
                Console.WriteLine($"The number is divisible by {divisor}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
