using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public interface ISortingStrategy
    {
        ICollection<int> Sort(ICollection<int> collection);
    }
}
