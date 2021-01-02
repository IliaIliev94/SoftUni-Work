using System;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] nums = new int[input.Length];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
                if (nums[i] % 2 == 0) 
                {
                    sum += nums[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
