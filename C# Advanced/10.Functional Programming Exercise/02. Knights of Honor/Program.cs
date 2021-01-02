using System;
using System.Linq;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> Print = msg => Console.WriteLine($"Sir {msg}");
            ForEach(Console.ReadLine().Split(), Print);
        }
        static void ForEach(string[] s, Action<string> Print)
        {
            foreach (var name in s)
            {
                Print(name);
            }
        }
    }
}
