using System;
using System.Linq;

namespace _03._Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] temp = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for(int j = 0; j < temp.Length; j++)
                {
                    matrix[i, j] = temp[j];
                }
            }
            int maxSum = 0;
            int[,] largest = new int[2, 2];
            for(int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                int sum = 0;
                for(int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    sum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];
                    if(sum > maxSum)
                    {
                        maxSum = sum;
                        for(int k = 0; k < largest.GetLength(0); k++)
                        {
                            for(int l = 0; l < largest.GetLength(1); l++)
                            {
                                largest[k, l] = matrix[i + k, l + j];
                            }
                        }
                    }
                }
            }
            for(int i = 0; i < largest.GetLength(0); i++)
            {
                for(int j = 0; j < largest.GetLength(1); j++)
                {
                    if(j == 0)
                    {
                        Console.Write($"{largest[i, j]} ");
                    }
                    else
                    {
                        Console.Write(largest[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
