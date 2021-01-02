using System;
using System.Linq;

namespace _05._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[data[0], data[1]];
            string snake = Console.ReadLine().Trim();
            int counter = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                if(i % 2 == 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = snake[counter % snake.Length].ToString();
                        counter++;
                    }
                }
                else
                {
                    for(int j = matrix.GetLength(1) - 1; j >= 0; j--)
                    {
                        matrix[i, j] = snake[counter % snake.Length].ToString();
                        counter++;
                    }
                }
                
            }
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        static string ReverseString(string s)
        {
            string result = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result += s[i];
            }

            return result;
        }


    }
}
