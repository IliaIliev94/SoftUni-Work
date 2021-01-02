using System;
using System.IO;

namespace _01.__Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("../../../input.txt");
            int counter = 0;
            using(reader)
            {
                while(!reader.EndOfStream)
                {
                    var input = reader.ReadLine();
                    if(counter % 2 != 0)
                    {
                        Console.WriteLine(input);
                    }
                    counter++;
                }
            }
        }
    }
}
