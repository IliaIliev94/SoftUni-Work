using System;
using System.Linq;
using System.Collections.Generic;
namespace _09._List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int[], bool> Filter = (x, nums) =>
            {
                foreach (var num in nums)
                {
                    if (x % num != 0)
                    {
                        return false;
                    }
                }
                return true;
            };
            int n = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(" ", FilterPrint(n, nums, Filter)));
        }

        static List<int> FilterPrint(int n, int[] nums, Func<int, int[], bool> Filter)
        {
            List<int> result = new List<int>();
            for(int i = 1; i <= n; i++)
            {
                if(Filter(i, nums))
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
