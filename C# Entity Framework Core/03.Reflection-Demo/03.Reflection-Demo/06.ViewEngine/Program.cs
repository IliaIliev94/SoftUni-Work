namespace ViewEngineDemo
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using ViewEngineDemo.MyViewEngine;

    public static class Program
    {
        public static void Main()
        {
            var viewEngine = new ViewEngine();
            var people = new List<Person>
                             {
                                 new Person { FirstName = "Nikolay", LastName = "Kostov" },
                                 new Person { FirstName = "Viktor", LastName = "Dakov" },
                                 new Person { FirstName = "Ivaylo", LastName = "Kenov" },
                             };
            var html = viewEngine.GetHtml(File.ReadAllText("Details.html"), people);
            Console.WriteLine(html);
        }
    }
}
