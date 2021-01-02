using System;
using System.Collections.Generic;

namespace Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> usernames = new HashSet<string>();
            for(int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                usernames.Add(name);
            }

            foreach(string name in usernames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
