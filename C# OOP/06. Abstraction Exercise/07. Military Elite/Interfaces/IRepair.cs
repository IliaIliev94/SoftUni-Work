using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite
{
    public interface IRepair
    {
        string Name { get; }
        int Hours { get; }

        string ToString();
    }
}
