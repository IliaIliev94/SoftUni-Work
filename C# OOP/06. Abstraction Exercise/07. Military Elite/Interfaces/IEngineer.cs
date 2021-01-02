using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite
{
    public interface IEngineer : ISpecialisedSoldier
    {
        List<IRepair> Repairs { get; }

        void Add(IRepair repair);
    }
}
