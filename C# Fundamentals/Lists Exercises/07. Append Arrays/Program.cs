using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            List<int> nums = new List<int>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                string compare = input[i];
                int[] result = compare.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < result.Length; j++)
                {
                    nums.Add(result[j]);
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
