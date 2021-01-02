using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> nums = Console.ReadLine().Split().Select(long.Parse).ToList();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int specialNumber = input[0];
            int power = input[1];

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == specialNumber)
                {
                    int specialNumIndex = i;
                    for (int j = 0, k = specialNumIndex - 1; j < power && k >= 0 && k != specialNumIndex; j++, k--)
                    {

                        nums.RemoveAt(k);
                        specialNumIndex--;

                    }
                    for (int j = 0; j < power && specialNumIndex + 1 < nums.Count; j++)
                    {

                        nums.RemoveAt(specialNumIndex + 1);
                    }

                    nums.RemoveAt(specialNumIndex);
                    i = specialNumIndex - 1;
                    
                }
            }
            Console.WriteLine(nums.Sum());
            
        }
    }
}
