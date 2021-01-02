using System;
using System.Linq;
namespace _4._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotations; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    int temp = nums[j + 1];
                    nums[j + 1] = nums[j];
                    nums[j] = temp;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (i != nums.Length - 1)
                {
                    Console.Write($"{nums[i]} ");
                }
                else
                {
                    Console.WriteLine(nums[i]);
                }
                
            }
        }
    }
}
