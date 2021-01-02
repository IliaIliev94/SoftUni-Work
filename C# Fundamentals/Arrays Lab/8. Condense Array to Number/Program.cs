using System;

namespace _8._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] nums = new int[input.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int element = int.Parse(input[i]);
                nums[i] = element;
            }
            int[] result = new int[nums.Length - 1];
            while (nums.Length != 1)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    result[i] = nums[i] + nums[i + 1];
                }
                nums = result;
                result = new int[nums.Length - 1];
            }
            Console.WriteLine(nums[0]);
        }
    }
}
