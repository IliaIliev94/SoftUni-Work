using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite
{
    public interface ISpy : ISoldier
    {
        int CodeNumber { get; }
    }
}
