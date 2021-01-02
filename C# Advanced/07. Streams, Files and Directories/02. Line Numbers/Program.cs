using System;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("../../../input.txt");
            var writer = new StreamWriter("../../../output.txt");
            int counter = 1;
            using(reader)
            {
                using(writer)
                {
                    while (!reader.EndOfStream)
                    {
                        var input = reader.ReadLine();
                        writer.WriteLine($"{counter}. {input}");
                        counter++;
                    }
                }
               
            }
        }
    }
}
