using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite
{
    public interface ICommando : ISpecialisedSoldier
    {
        List<IMission> Missions { get; }

        void Add(IMission mission);
    }
}
