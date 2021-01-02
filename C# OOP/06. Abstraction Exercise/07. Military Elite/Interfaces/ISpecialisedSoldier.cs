using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite
{
    public interface ISpecialisedSoldier : IPrivate
    {
        string Corps { get; }
    }
}
