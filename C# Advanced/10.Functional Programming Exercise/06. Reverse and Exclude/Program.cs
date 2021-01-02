using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();
            int filterNum = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", Reverse(nums, x => x % filterNum == 0)));
        }
        public static List<int> Reverse(List<int> nums, Predicate<int> Filter)
        {
            List<int> result = new List<int>();

            for(int i = nums.Count - 1; i >= 0; i--)
            {
                if(!Filter(nums[i]))
                {
                    result.Add(nums[i]);
                }
            }
            return result;
        }
    }
}
