using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Wild_Farm.Models
{
    public interface IFood
    {
        string Type { get; }
        int Quantity { get; }
    }
}
