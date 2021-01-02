using System;
using System.Linq;

namespace _04._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[data[0], data[1]];

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] temp = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = temp[j];
                }
            }

            string[] command = Console.ReadLine().Split();

            while(!command[0].Equals("END"))
            {
                bool isValid = false;
                int first = 0;
                int second = 0;
                int third = 0;
                int fourth = 0;
                if (command[0].Equals("swap") && command.Length == 5) {

                    first = int.Parse(command[1]);
                    second = int.Parse(command[2]);
                    third = int.Parse(command[3]);
                    fourth = int.Parse(command[4]);

                    if ((first >= 0 && first < matrix.GetLength(0)) && (second >= 0 && second < matrix.GetLength(1))
                    && (third >= 0 && third < matrix.GetLength(0)) && (fourth >= 0 && fourth < matrix.GetLength(1)))
                    {
                        isValid = true;
                        
                    }
                }
                if(isValid)
                {
                    string temp = matrix[third, fourth];
                    matrix[third, fourth] = matrix[first, second];
                    matrix[first, second] = temp;

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            if (j == 0)
                            {
                                Console.Write(matrix[i, j]);
                            }
                            else
                            {
                                Console.Write($" {matrix[i, j]}");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine().Split();
            }
        }
    }
}
