using System;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = int.Parse(Console.ReadLine());
            int[] nums = new int[index];
            Console.WriteLine(string.Join(" ", tribonacii(index, nums)));

        }

        static int[] tribonacii(int n, int[] nums)
        {

            if (n >= 1)
            {
                nums[0] = 1;
            }

            if (n >= 2)
            {
                nums[1] = 1;
            }

            if (n >= 3)
            {
                nums[2] = 2;
            }


            for (int i = 3; i < nums.Length; i++)
            {
                nums[i] = nums[i - 1] + nums[i - 2] + nums[i - 3];
            }
            return nums;
        }
    }
}
