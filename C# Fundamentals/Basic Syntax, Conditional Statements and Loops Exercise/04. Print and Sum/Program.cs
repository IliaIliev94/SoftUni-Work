using System;

namespace _04._Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                if (i != num2)
                {
                    Console.Write($"{i} ");
                }
                else
                {
                    Console.Write($"{i}");
                    Console.WriteLine();
                }
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
