using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> ParseInt = x => Convert.ToInt32(x);
            List<int> nums = Console.ReadLine().Split().Select(ParseInt).ToList();

            Console.WriteLine(ListOperation(nums, nums => nums.Min()));
        }
        static int ListOperation(List<int> nums, Func<List<int>, int> func)
        {
            return func(nums);
        }
    }
}
