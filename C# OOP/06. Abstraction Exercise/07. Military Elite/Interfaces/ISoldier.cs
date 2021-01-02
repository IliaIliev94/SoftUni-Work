using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite
{
    public interface ISoldier
    {
        int Id { get; }
        string FirstName { get; }
        string LastName { get; }

        string ToString();
    }
}
