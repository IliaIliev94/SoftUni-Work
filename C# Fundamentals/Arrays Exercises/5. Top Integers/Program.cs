using System;
using System.Linq;

namespace _5._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isWritten = false;
            for (int i = 0; i < nums.Length; i++)
            {
                bool isTop = true;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] <= nums[j])
                    {
                        isTop = false;
                        break;
                    }
                }

                if(isTop)
                {
                    if(isWritten)
                    {
                        Console.Write($" {nums[i]}");
                    }
                    else
                    {
                        Console.Write(nums[i]);
                        isWritten = true;
                    }
                }
            }
        }
    }
}
