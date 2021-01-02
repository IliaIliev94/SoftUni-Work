using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Generic_Swap_Method_Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for(int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }
            int[] coordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Swap(names, coordinates[0], coordinates[1]);

            foreach(var name in names)
            {
                Print(name);
            }
        }

        static void Swap<T>(List<T> input, int firstIndex, int secondIndex)
        {
            T temp = input[firstIndex];
            input[firstIndex] = input[secondIndex];
            input[secondIndex] = temp;
        }

        static void Print<T>(T input)
        {
            Console.WriteLine($"{typeof(T)}: {input}");
        }
    }
}
