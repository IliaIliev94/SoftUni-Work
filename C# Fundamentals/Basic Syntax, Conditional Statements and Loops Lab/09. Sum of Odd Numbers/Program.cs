using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int sum = 0;

            while (n > 0)
            {
                Console.WriteLine(i);
                sum += i;
                i += 2;
                n--;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
