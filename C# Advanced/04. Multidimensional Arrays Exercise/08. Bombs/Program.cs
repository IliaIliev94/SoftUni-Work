using System;
using System.Linq;

namespace _08._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rows][];
            for(int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            string[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < indexes.Length; i++)
                {
                    int row = (int)char.GetNumericValue(indexes[i][0]);
                    int column = (int)char.GetNumericValue(indexes[i][2]);
                    int value = matrix[row][column];
                    if(value > 0)
                    {
                        for (int j = row - 1; j <= row + 1; j++)
                        {
                            for (int k = column - 1; k <= column + 1; k++)
                            {
                                if ((j >= 0 && j < matrix.Length) && (k >= 0 && k < matrix[j].Length))
                                {
                                    if (matrix[j][k] > 0)
                                    {
                                        matrix[j][k] -= value;
                                    }

                                }
                            }
                        }
                    }
                    
            }
            
            int sum = 0;
            int aliveCells = 0;
            for(int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    int value = matrix[i][j];
                    if(value > 0)
                    {
                        sum += value;
                        aliveCells++;
                    }
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");
            for(int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }
    }
}
