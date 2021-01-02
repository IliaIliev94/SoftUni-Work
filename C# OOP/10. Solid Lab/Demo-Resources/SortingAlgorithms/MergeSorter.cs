using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class MergeSorter : ISortingStrategy
    {
        public ICollection<int> Sort(ICollection<int> collection)
        {
            Console.WriteLine("Merge sort rules");
            return collection;
        }
    }
}
