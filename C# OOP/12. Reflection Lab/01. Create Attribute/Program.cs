using _01._Create_Attribute.Author;
using System;
using System.Reflection;

namespace _01._Create_Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Tracker tracker = new Tracker();
            tracker.PrintMthodsByAuthor();
        }
    }
}
