using System;
using System.Linq;

namespace _02._2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
            char[,] matrix = new char[data[0], data[1]];

            for (int i = 0; i < data[0]; i++)
            {
                char[] temp = Console.ReadLine().Trim().Split().Select(char.Parse).ToArray();
                for (int j = 0; j < data[1]; j++)
                {
                    matrix[i, j] = temp[j];
                }
            }
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    char character = matrix[i, j];
                    if (character == matrix[i, j + 1] && character == matrix[i + 1, j] && character == matrix[i + 1, j + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
