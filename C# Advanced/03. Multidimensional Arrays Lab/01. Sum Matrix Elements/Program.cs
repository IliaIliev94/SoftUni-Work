using System;
using System.Linq;

namespace _01._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];
            int sum = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] temp = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for(int j = 0; j < temp.Length; j++)
                {
                    matrix[i, j] = temp[j];
                }
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
