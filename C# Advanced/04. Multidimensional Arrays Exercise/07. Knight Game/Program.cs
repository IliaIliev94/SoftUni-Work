using System;
using System.Linq;

namespace _07._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            char[][] matrix = new char[rows][];
            for(int i = 0; i < matrix.Length; i++)
            {
                string temp = Console.ReadLine().Trim();
                matrix[i] = new char[temp.Length];
                for(int j = 0; j < temp.Length; j++)
                {

                    matrix[i][j] = temp[j];

                    
                }
            }
            bool noAttack = false;
            int count = 0;
            while(!noAttack)
            {
                int attacks = 0;
                int maxValue = 0;
                int row = 0;
                int column = 0;
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (char.ToUpper(matrix[i][j]) == 'K')
                        {
                            int value = AttackCount(matrix, i, j);
                            if(value > 0)
                            {
                                attacks++;
                                if (value > maxValue)
                                {
                                    maxValue = value;
                                    row = i;
                                    column = j;
                                }
                            }

                        }
                    }
                }
                if(attacks == 0)
                {
                    noAttack = true;
                }
                else
                {
                    matrix[row][column] = '0';
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        static int AttackCount(char[][] matrix, int row, int column)
        {
            int count = 0;

            if(row - 2 >= 0 && row - 2 < matrix.Length)
            {
                if (column - 1 >= 0 && column - 1 < matrix[row - 2].Length)
                {
                    if (char.ToUpper(matrix[row - 2][column - 1]) == 'K')
                    {
                        count++;
                    }
                }
                if(column + 1 >= 0 && column + 1 < matrix[row - 2].Length)
                {
                    if(Char.ToUpper(matrix[row - 2][column + 1]) == 'K')
                    {
                        count++;
                    }
                }
            }
            if (row - 1 >= 0 && row - 1 < matrix.Length)
            {
                if (column - 2 >= 0 && column - 2 < matrix[row - 1].Length)
                {
                    if (char.ToUpper(matrix[row - 1][column - 2]) == 'K')
                    {
                        count++;
                    }
                }
                if (column + 2 >= 0 && column + 2 < matrix[row - 1].Length)
                {
                    if (char.ToUpper(matrix[row - 1][column + 2]) == 'K')
                    {
                        count++;
                    }
                }
            }
            if (row + 1 >= 0 && row + 1 < matrix.Length)
            {
                if (column - 2 >= 0 && column - 2 < matrix[row + 1].Length)
                {
                    if (char.ToUpper(matrix[row + 1][column - 2]) == 'K')
                    {
                        count++;
                    }
                }
                if (column + 2 >= 0 && column + 2 < matrix[row + 1].Length)
                {
                    if (char.ToUpper(matrix[row + 1][column + 2]) == 'K')
                    {
                        count++;
                    }
                }
            }
            if (row + 2 >= 0 && row + 2 < matrix.Length)
            {
                if (column - 1 >= 0 && column -1 < matrix[row + 2].Length)
                {
                    if (char.ToUpper(matrix[row + 2][column - 1]) == 'K')
                    {
                        count++;
                    }
                }
                if (column + 1 >= 0 && column + 1 < matrix[row + 2].Length)
                {
                    if (char.ToUpper(matrix[row + 2][column + 1]) == 'K')
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
