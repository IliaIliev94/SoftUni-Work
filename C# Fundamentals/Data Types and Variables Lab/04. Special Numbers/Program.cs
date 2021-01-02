using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            bool isSpecial;

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j > 0; j /= 10)
                {
                    sum += j % 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                sum = 0;
                isSpecial = false;
            }
        }
    }
}
