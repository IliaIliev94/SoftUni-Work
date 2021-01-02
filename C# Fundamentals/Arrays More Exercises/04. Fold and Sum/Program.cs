using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int middle = nums.Length / 2;
            int[] first = new int[middle];
            int[] second = new int[middle];

            for (int i = 0, j = middle/2 - 1; i < middle; i++, j--)
            {
                first[i] = nums[j];

                if (i + 1 == nums.Length / 4)
                {
                    j = nums.Length;
                }
            }
            for (int i = middle / 2, j = 0; j < middle; i++, j++) 
            {
                second[j] = nums[i];
            }

            int[] sum = new int[middle];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = first[i] + second[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
