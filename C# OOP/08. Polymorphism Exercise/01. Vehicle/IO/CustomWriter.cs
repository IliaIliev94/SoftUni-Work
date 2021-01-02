using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Vehicle.IO
{
    public class CustomWriter : IWriter
    {
        public void CustomWriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
