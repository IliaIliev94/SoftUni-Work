using System;
using System.Linq;

namespace _06._Sum_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    sumEven += nums[i];
                }
                else
                {
                    sumOdd += nums[i];
                }
            }
            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
