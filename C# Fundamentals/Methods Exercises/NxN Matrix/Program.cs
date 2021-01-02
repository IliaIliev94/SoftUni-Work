using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            matrix(input);
        }
        static void matrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(n);
                    }
                    else
                    {
                        Console.Write(" " + n);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
