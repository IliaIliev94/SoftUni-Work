using P03.Detail_Printer;
using P03.Detail_Printer.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class Employee : Worker, IEmployee
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public override void Print()
        {
            Console.WriteLine(this.Name);
        }
    }
}
