using System;
using System.Linq;

namespace _09._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] square = new char[size, size];
            string[] commands = Console.ReadLine().Split();
            int row = 0;
            int column = 0;
            int totalCoals = 0;
            for (int i = 0; i < square.GetLength(0); i++)
            {
                char[] temp = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int j = 0; j < square.GetLength(1); j++)
                {
                    square[i, j] = temp[j];
                    if (temp[j] == 's')
                    {
                        row = i;
                        column = j;
                    }
                    else if (temp[j] == 'c')
                    {
                        totalCoals++;
                    }
                }
            }
            if(square.GetLength(0) > 0)
            {
                foreach (string command in commands)
                {

                    if (command == "up" && (row - 1 >= 0 && row - 1 < square.GetLength(0)))
                    {

                        row -= 1;

                    }
                    else if (command == "down" && (row + 1 >= 0 && row + 1 < square.GetLength(0)))
                    {

                        row += 1;

                    }
                    else if (command == "left" && (column - 1 >= 0))
                    {

                        column -= 1;

                    }
                    else if (command == "right" && (column + 1 < square.GetLength(1)))
                    {

                        column += 1;

                    }
                    if (square[row, column] == 'c')
                    {
                        totalCoals--;
                        square[row, column] = '*';
                        if (totalCoals == 0)
                        {
                            Console.WriteLine($"You collected all coals! ({row}, {column})");
                            break;
                        }
                    }
                    else if (square[row, column] == 'e')
                    {
                        Console.WriteLine($"Game over! ({row}, {column})");
                        break;
                    }
                }
            }
            
            if (square.GetLength(0) > 0 && square[row, column] != 'e' && totalCoals > 0)
            {

                Console.WriteLine($"{totalCoals} coals left. ({row}, {column})");

            }
        }
    }
}
