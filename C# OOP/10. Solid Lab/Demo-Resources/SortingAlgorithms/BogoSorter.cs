using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class BogoSorter : ISortingStrategy
    {
        public ICollection<int> Sort(ICollection<int> collection)
        {
            Console.WriteLine("Bogo rules");
            return collection;
        }
    }
}
