using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorter sorter = new Sorter();
            sorter.Sort(new List<int>(), Console.ReadLine());
        }
    }
}
