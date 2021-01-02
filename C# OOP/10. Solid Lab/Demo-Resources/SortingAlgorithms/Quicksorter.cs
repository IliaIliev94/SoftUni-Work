using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class QuickSorter : ISortingStrategy
    {
        public ICollection<int> Sort(ICollection<int> collection)
        {
            Console.WriteLine("Quicksort rules");
            return collection;
        }
    }
}
