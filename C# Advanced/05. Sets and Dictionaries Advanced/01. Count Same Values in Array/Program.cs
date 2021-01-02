using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> valueOccurances = new Dictionary<double, int>();

            foreach(double number in nums)
            {
                if (valueOccurances.ContainsKey(number))
                {
                    valueOccurances[number]++;
                }
                else
                {
                    valueOccurances.Add(number, 1);
                }
            }

            foreach(var item in valueOccurances)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
