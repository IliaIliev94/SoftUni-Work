using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                        .Split(", ")
                        .Select(x => int.Parse(x))
                        .Where(x => x % 2 == 0)
                        .OrderBy(x => x)
                        .ToArray();

            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
