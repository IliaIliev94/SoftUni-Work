using System;
using System.Linq;

namespace _06._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] nums = new int[rows][];

            for(int i = 0; i < rows; i++)
            {
                nums[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            string[] command = Console.ReadLine().Split() ;
            while (!command[0].Equals("END"))
            {
                int row = int.Parse(command[1]);
                int column = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                if((row > nums.Length - 1 || row < 0) || (column > nums[row].Length - 1 || column < 0))
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (command[0].Equals("Add"))
                    {
                        nums[row][column] += value;
                    }
                    else
                    {
                        nums[row][column] -= value;
                    }
                }
                
                command = Console.ReadLine().Split();
            }
            for(int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(string.Join(" ", nums[i]));
            }
        }
    }
}
