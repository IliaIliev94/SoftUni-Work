using System;
using System.Linq;

namespace _6._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isTrue = false;
            for (int i = 0; i < nums.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    sumLeft += nums[j];
                }
                for (int k = i + 1; k < nums.Length; k++)
                {
                    sumRight += nums[k];
                }
                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    isTrue = true;
                    break;
                }
            }
            if (!isTrue)
            {
                Console.WriteLine("no");
            }
        }
    }
}
