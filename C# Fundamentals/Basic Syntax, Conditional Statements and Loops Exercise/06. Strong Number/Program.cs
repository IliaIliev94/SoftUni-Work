using System;

namespace _06._Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int digit;
            int j;
            int factorial = 1;
            int totalSum = 0;
            for (int i = num; i != 0; i /= 10)
            {
                digit = i % 10;
                j = 1;
                while (j <= digit)
                {
                    factorial *= j;
                    j++;
                }
                totalSum += factorial;
                factorial = 1;
            }
            if (totalSum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
