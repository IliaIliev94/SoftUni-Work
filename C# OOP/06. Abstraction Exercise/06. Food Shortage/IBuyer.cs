using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Food_Shortage
{
    public interface IBuyer
    {
        string Name { get; }
        int Food { get; }
        void BuyFood();
    }
}
