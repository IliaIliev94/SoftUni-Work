using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class SelectionSorter : ISortingStrategy
    {
        public ICollection<int> Sort(ICollection<int> collection)
        {
            Console.WriteLine("Selection sort rules");
            return collection;
        }
    }
}
