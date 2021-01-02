using System;

namespace _07._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FilterPrint(Console.ReadLine()
                        .Split(), x => x.Length <= n);
        }
        public static void FilterPrint(string[] nums, Predicate<string> Filter)
        {
            foreach(var num in nums)
            {
                if(Filter(num))
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
