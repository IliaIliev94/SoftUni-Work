using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            double result = factorial(numOne) / factorial(numTwo);
            Console.WriteLine(result.ToString("0.00"));
        }
        static double factorial(int a)
        {
            if (a == 1)
            {
                return 1;
            }
            return a * factorial(a - 1);
        }
    }
}
