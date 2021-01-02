using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
 

            Predicate<int> Filter = x => x % 2 == 0;
            List<int> nums = Operation(Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList(), Console.ReadLine(), Filter);

            Console.WriteLine(string.Join(" ", nums));
        }
        public static List<int> Operation(List<int> nums, string condition, Predicate<int> Filter)
        {
            List<int> result = new List<int>();
            for(int i = nums[0]; i <= nums[1]; i++)
            {
                if(condition == "even")
                {
                    if (Filter(i))
                    {
                        result.Add(i);
                    }
                }
                else
                {
                    if(!Filter(i))
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }
    }
}
