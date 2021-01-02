using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int waterTank = int.Parse(Console.ReadLine());
            int capacity = 255;
            int sum = 0;
            int input;

            for (int i = 0; i < waterTank; i++)
            {
                input = int.Parse(Console.ReadLine());
                if (sum + input > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += input;

                }
            }
            Console.WriteLine(sum);
        }
    }
}
