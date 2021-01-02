using System;
using System.Linq;

namespace _01._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] square = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int j = 0; j < temp.Length; j++)
                {
                    square[i, j] = temp[j];
                }
            }
            int primaryDiagonalSum = 0;
            int primaryDiagonalCounter = 0;
            int secondaryDiagonalSum = 0;
            int secondaryDiagonalCounter = square.GetLength(1) - 1;
            for(int i = 0; i < square.GetLength(0); i++)
            {

                primaryDiagonalSum += square[i, primaryDiagonalCounter];
                primaryDiagonalCounter++;
                secondaryDiagonalSum += square[i, secondaryDiagonalCounter];
                secondaryDiagonalCounter--;

            }
            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }
    }
}
