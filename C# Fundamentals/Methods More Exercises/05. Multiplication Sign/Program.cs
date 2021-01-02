using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            multiplicationSign(num1, num2, num3);
        }
        static void multiplicationSign(int a, int b, int c)
        {
            int count = 0;

            if (a < 0)
            {
                count++;
            }
            if (b < 0)
            {
                count++;
            }
            if (c < 0)
            {
                count++;
            }
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("zero");
            }
            else if (count % 2 != 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
}
