using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 1;
            int maxCount = 0;
            int longest = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length - 1; j++)
                {
                    if (nums[j] == nums[j + 1])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    longest = nums[i];
                }
                count = 1;
            }

            for (int i = 0; i < maxCount; i++)
            {
                if (i != maxCount - 1)
                {
                    Console.Write($"{longest} ");
                }
                else
                {
                    Console.Write(longest);
                }
            }
        }
    }
}
