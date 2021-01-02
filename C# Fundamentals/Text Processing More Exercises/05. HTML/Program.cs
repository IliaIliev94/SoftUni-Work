using System;
using System.Collections.Generic;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string article = Console.ReadLine();
            string content = Console.ReadLine();
            List<string> comments = new List<string>();
            string command = Console.ReadLine();
            while(!command.Equals("end of comments"))
            {
                comments.Add(command);
                command = Console.ReadLine();
            }

            Console.WriteLine($"<h1>\n\t{article}\n</h1>");
            Console.WriteLine($"<article>\n\t{content}\n</article>");
            foreach(var item in comments)
            {
                Console.WriteLine($"<div>\n\t{item}\n</div>");
            }
        }
    }
}
