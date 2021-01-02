using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[1];
            int[] previous = nums;
            for (int i = 0; i < n; i++)
            {
                nums = new int[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    if (nums.Length == 1)
                    {
                        nums[i] = 1;
                    }
                    else
                    {
                        if (j > previous.Length - 1 || j - 1 < 0)
                        {
                            nums[j] = 1;
                        }
                        else
                        {
                            nums[j] = previous[j] + previous[j - 1];
                        }
                    }
                }
                Console.WriteLine(string.Join(" ", nums));
                previous = nums;
            }

        }
    }
}
