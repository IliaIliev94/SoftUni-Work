using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isCapital = (string x) => char.IsUpper(x[0]);
            string[] input = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

            Console.WriteLine(string.Join("\n", IsCapital(input, isCapital)));
        }

        public static List<string> IsCapital(string[] s, Predicate<string> isCapital)
        {
            List<string> result = new List<string>();

            foreach(string word in s)
            {
                if(isCapital(word))
                {
                    result.Add(word);
                }
            }
            return result;
        }
    }
}
