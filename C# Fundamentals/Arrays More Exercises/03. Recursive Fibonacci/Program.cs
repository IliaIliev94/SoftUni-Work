using System;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(fibonacci(n));
        }
        static int fibonacci(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 1;
            }
            return fibonacci(n - 1) + fibonacci(n - 2);
        }
    }
}
