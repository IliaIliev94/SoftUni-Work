using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite
{
    public interface IMission
    {
        string CodeName { get; }
        string State { get; }
        string ToString();

        void CompleteMission();
    }
}
