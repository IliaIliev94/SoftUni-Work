using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Birthday_Celebrations
{
    public interface ICitizen
    {
        public string Id { get; }

        bool EndsWith(string id);
    }
}
