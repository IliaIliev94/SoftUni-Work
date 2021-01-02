using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach(var key in input)
            {
                if (numbers.ContainsKey(key))
                {
                    numbers[key]++;
                }
                else
                {
                    numbers.Add(key, 1);
                }
            }

            foreach (KeyValuePair<double,int> entries in numbers)
            {
                Console.WriteLine($"{entries.Key} -> {entries.Value}");
            }
        }
    }
}
