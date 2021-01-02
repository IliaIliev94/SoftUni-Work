using System;
using System.Linq;

namespace _02._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int j = 0; j < temp.Length; j++)
                {
                    matrix[i, j] = temp[j];
                }
            }


            for(int i = 0; i < matrix.GetLength(1); i++)
            {
                int sum = 0;
                for(int j = 0; j < matrix.GetLength(0); j++)
                {
                    sum += matrix[j, i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
