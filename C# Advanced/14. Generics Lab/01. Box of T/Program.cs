using System;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> test = new Box<int>();
            test.Add(2);
            test.Add(3);
            Console.WriteLine(test.Count);
            Console.WriteLine(test.Remove());
        }
    }
}
