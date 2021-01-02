using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Birthday_Celebrations
{
    public interface IBirthed
    {
        string Name { get; }
        string Birthdate { get; }

        public bool EndsWith(string year);
    }
}
