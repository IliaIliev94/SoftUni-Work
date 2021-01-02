using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers[i] = num;
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.Write(numbers[i]);
                }
                else
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}
