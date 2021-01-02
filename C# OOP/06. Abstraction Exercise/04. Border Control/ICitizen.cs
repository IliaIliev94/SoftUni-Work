using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Border_Control
{
    public interface ICitizen
    {
        public string Id { get; }

        bool EndsWith(string id);
    }
}
