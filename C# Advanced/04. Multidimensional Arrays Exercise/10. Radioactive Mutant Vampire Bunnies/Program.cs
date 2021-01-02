using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[dimensions[0], dimensions[1]];
            int row = 0;
            int column = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                string temp = Console.ReadLine();
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = temp[j];
                    if(temp[j] == 'P')
                    {
                        row = i;
                        column = j;
                    }
                }
            }
            string commands = Console.ReadLine();
            bool won = false;
            bool isDead = false;
            for(int i = 0; i < commands.Length && !won && !isDead; i++)
            {
                UpdatePlayer(matrix, ref row, ref column, ref won, ref isDead, commands[i]);

                List<int> positions = new List<int>();
                for(int j = 0; j < matrix.GetLength(0); j++)
                {
                    for(int k = 0; k < matrix.GetLength(1); k++)
                    {
                        char cell = matrix[j, k];
                        if(cell == 'B')
                        {
                            positions.Add(j);
                            positions.Add(k);
                        }

                    }
                }

                MakeBunnies(matrix, positions, ref isDead);
                 
            }

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            if(won)
            {
                Console.WriteLine($"won: {row} {column}");
            }
            else
            {
                Console.WriteLine($"dead: {row} {column}");
            }
        }


        static void UpdatePlayer(char[,] matrix, ref int row, ref int column, ref bool won, ref bool isDead, char command)
        {
            if (command == 'L')
            {
                if (column - 1 < 0)
                {
                    won = true;
                    matrix[row, column] = '.';
                }
                else
                {
                    char temp = matrix[row, column - 1];

                    if (temp != 'B')
                    {
                        matrix[row, column - 1] = matrix[row, column];
                        matrix[row, column] = temp;
                    }
                    else
                    {
                        isDead = true;
                        matrix[row, column] = '.';
                    }
                    column = column - 1;
                }
            }
            else if (command == 'R')
            {
                if (column + 1 > matrix.GetLength(1) - 1)
                {
                    won = true;
                    matrix[row, column] = '.';
                }
                else
                {
                    char temp = matrix[row, column + 1];

                    if (temp != 'B')
                    {
                        matrix[row, column + 1] = matrix[row, column];
                        matrix[row, column] = temp;

                    }
                    else
                    {
                        isDead = true;
                        matrix[row, column] = '.';
                    }
                    column = column + 1;
                }
            }
            else if (command == 'U')
            {
                if (row - 1 < 0)
                {
                    won = true;
                    matrix[row, column] = '.';
                }
                else
                {
                    char temp = matrix[row - 1, column];

                    if (temp != 'B')
                    {
                        matrix[row - 1, column] = matrix[row, column];
                        matrix[row, column] = temp;

                    }
                    else
                    {
                        isDead = true;
                        matrix[row, column] = '.';
                    }
                    row = row - 1;
                }
            }
            else
            {
                if (row + 1 > matrix.GetLength(0) - 1)
                {
                    won = true;
                    matrix[row, column] = '.';
                }
                else
                {
                    char temp = matrix[row + 1, column];

                    if (temp != 'B')
                    {
                        matrix[row + 1, column] = matrix[row, column];
                        matrix[row, column] = temp;

                    }
                    else
                    {
                        isDead = true;
                        matrix[row, column] = '.';
                    }
                    row = row + 1;
                }
            }
        }
        static void MakeBunnies(char[,] matrix, List<int> positions, ref bool isDead)
        {
            for (int j = 0; j < positions.Count; j += 2)
            {
                int tempRow = positions[j];
                int tempColumn = positions[j + 1];
                for (int l = tempRow - 1; l <= tempRow + 1; l++)
                {
                    if (l == tempRow)
                    {
                        if (l >= 0 && l < matrix.GetLength(0))
                        {
                            if (tempColumn - 1 >= 0)
                            {
                                if (matrix[l, tempColumn - 1] == 'P')
                                {
                                    matrix[l, tempColumn - 1] = 'B';
                                    isDead = true;
                                }
                                else
                                {
                                    matrix[l, tempColumn - 1] = 'B';
                                }
                            }
                            if (tempColumn + 1 < matrix.GetLength(1))
                            {
                                if (matrix[l, tempColumn + 1] == 'P')
                                {
                                    matrix[l, tempColumn + 1] = 'B';
                                    isDead = true;
                                }
                                else
                                {
                                    matrix[l, tempColumn + 1] = 'B';
                                }
                            }
                        }
                    }
                    else
                    {
                        if (l >= 0 && l < matrix.GetLength(0))
                        {
                            if (matrix[l, tempColumn] == 'P')
                            {
                                matrix[l, tempColumn] = 'B';
                                isDead = true;
                            }
                            else
                            {
                                matrix[l, tempColumn] = 'B';
                            }


                        }
                    }
                }
            }

        }
    }
}
