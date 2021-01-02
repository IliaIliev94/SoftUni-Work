using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Vehicle.IO
{
    public class CustomReader : IReader
    {
        public string CustomReadLine()
        {
            return Console.ReadLine();
        }
    }
}
