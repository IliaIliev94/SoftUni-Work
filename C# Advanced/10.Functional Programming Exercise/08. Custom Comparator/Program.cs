using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            Array.Sort(nums, (x, y) => CompareTo(x, y));
            Console.WriteLine(string.Join(" ", nums));
        }
        public static int CompareTo(int a, int b)
        {
            if((a % 2 == 0 & b % 2 == 0) || (a % 2 != 0 && b % 2 != 0))
            {
                if(a == b)
                {
                    return 0;
                }
                else if(a > b)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else if(a % 2 == 0 && b % 2 != 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
