using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;

namespace SortingAlgorithms
{
    public class Sorter
    {
        public ICollection<int> Sort(ICollection<int> collection, string algorithm)
        {

            var sorterType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(ISortingStrategy).IsAssignableFrom(t) && t.IsClass)
                .FirstOrDefault(t => t.Name.ToLower().Contains(algorithm));

            ISortingStrategy strategy = Activator.CreateInstance(sorterType) as ISortingStrategy;
            return strategy.Sort(collection);
        }

       
    }
}
