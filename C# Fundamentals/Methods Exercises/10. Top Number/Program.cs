using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (isDivisableByEight(i) && hasOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool isDivisableByEight(int a)
        {
            int sum = 0;
            for (int i = a; i != 0; i/= 10)
            {
                sum += i % 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool hasOddDigit(int a)
        {
            for (int i = a; i != 0; i /= 10)
            {
                int digit = i % 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
