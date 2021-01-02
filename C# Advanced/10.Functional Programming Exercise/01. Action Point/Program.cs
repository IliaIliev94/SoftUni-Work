using System;
using System.Linq;


namespace _01._Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> Print = msg => Console.WriteLine(msg);
            string[] input = Console.ReadLine().Split();
            ForEach(input, Print);
        }
        public static void ForEach(string[] s, Action<string> Print)
        {
            foreach(var character in s)
            {
                Print(character);
            }
            
        }
    }
}
