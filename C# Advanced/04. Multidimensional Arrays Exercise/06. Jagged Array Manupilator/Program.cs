using System;
using System.Linq;

namespace _06._Jagged_Array_Manupilator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] matrix = new double[rows][];

            for(int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            }
            for(int i = 0; i < matrix.Length - 1; i++)
            {
                if (matrix[i].Length == matrix[i + 1].Length)
                {
                    for(int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] *= 2;
                        matrix[i + 1][j] *= 2;
                    }

                }
                else
                {
                    for(int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] /= 2;
                    }
                    for(int j = 0; j < matrix[i + 1].Length; j++)
                    {
                        matrix[i + 1][j] /= 2;
                    }
                }
            }
            string[] command = Console.ReadLine().Split();

            while(!command[0].Equals("End"))
            {
                int row = int.Parse(command[1]);
                int column = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                if(command[0].Equals("Add"))
                {
                    if((row >= 0 && row < matrix.Length) && (column >= 0 && column <  matrix[row].Length))
                    {
                        matrix[row][column] += value;
                    }
                }
                else
                {
                    if ((row >= 0 && row < matrix.Length) && (column >= 0 && column < matrix[row].Length))
                    {
                        matrix[row][column] -= value;
                    }
                }
                command = Console.ReadLine().Split();
            }
            for(int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }
    }
}
