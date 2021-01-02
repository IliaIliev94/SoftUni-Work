using System;

namespace _07._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[n][];

            for (int i = 0; i < n; i++)
            {
                pascalTriangle[i] = new long[i + 1];
                if (i == 0)
                {
                    pascalTriangle[i][0] = 1;
                }
                else
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (j - 1 < 0)
                        {
                            pascalTriangle[i][j] = pascalTriangle[i - 1][j];
                        }
                        else if (j > pascalTriangle[i - 1].Length - 1)
                        {
                            pascalTriangle[i][j] = pascalTriangle[i - 1][j - 1];
                        }
                        else
                        {
                            pascalTriangle[i][j] = pascalTriangle[i - 1][j - 1] + pascalTriangle[i - 1][j];
                        }

                    }
                }

            }
            for (int i = 0; i < pascalTriangle.Length; i++)
            {
                Console.WriteLine(string.Join(" ", pascalTriangle[i]));
            }
        }
    }
}
