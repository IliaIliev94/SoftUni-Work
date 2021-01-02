using System;

namespace _02._Recursive_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }

        public static int Factorial(int n)
        {
            if(n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
