using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> nums = new Dictionary<int, int>();

            for(int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(nums.ContainsKey(number))
                {
                    nums[number]++;
                }
                else
                {
                    nums.Add(number, 1);
                }
            }

            foreach(var item in nums)
            {
                if(item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }
        }
    }
}
