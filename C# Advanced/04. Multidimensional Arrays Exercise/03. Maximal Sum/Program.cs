using System;
using System.Linq;

namespace _03._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[dimensions[0], dimensions[1]];

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] temp = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = temp[j];
                }
            } 
            var maxSum = 0;
            int[,] largest = new int[3, 3];
            for(int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for(int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    var sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] +
                        matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if(sum > maxSum)
                    {
                        maxSum = sum;

                        for(int l = 0; l < largest.GetLength(0); l++)
                        {
                            for(int k = 0; k < largest.GetLength(1); k++)
                            {
                                largest[l, k] = matrix[i + l, j + k];
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for(int i = 0; i < largest.GetLength(0); i++)
            {
                for(int j = 0; j < largest.GetLength(1); j++)
                {
                    if(j == 0)
                    {
                        Console.Write(largest[i, j]);
                    }
                    else
                    {
                        Console.Write($" {largest[i, j]}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
