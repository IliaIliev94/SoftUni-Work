using System;

namespace P02._Worker_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager(new Worker());
            Console.WriteLine(manager);
        }
    }
}
