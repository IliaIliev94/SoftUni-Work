using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();
            for(int i = 0; i < n; i++)
            {
                string[] element = Console.ReadLine().Split();
                foreach(string item in element)
                {
                    elements.Add(item);
                }
               
            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
