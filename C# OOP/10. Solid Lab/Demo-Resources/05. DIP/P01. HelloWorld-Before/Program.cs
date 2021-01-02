using P01._HelloWorld;
using System;

namespace P01._HelloWorld_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            var helloWorld = new HelloWorld();
            Console.WriteLine(helloWorld.Greeting("Opa", DateTime.Now));
        }
    }
}
