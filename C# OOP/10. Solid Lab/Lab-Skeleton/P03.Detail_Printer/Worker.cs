using P03.Detail_Printer.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03.Detail_Printer
{
    public abstract class Worker : IEmployee
    {
        public string Name { get; set; }

        public abstract void Print();
    }
}
