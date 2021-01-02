using System;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            while(!command.Equals("Done"))
            {
                string[] words = command.Split();
                if(words[0].Equals("TakeOdd"))
                {
                    string temp = new string("");
                    for(int i = 1; i < input.Length; i+=2)
                    {
                        temp += input[i];
                    }
                    input = temp;
                    Console.WriteLine(input);
                }
                else if(words[0].Equals("Cut"))
                {
                    int index = int.Parse(words[1]);
                    int length = int.Parse(words[2]);
                    string temp = input.Substring(index, length);
                    int startIndex = input.IndexOf(temp);
                    input = input.Remove(startIndex, length);
                    Console.WriteLine(input);
                }
                else
                {
                    string substring = words[1];
                    string substitute = words[2];
                    string temp = new string("");
                    if(input.Contains(substring))
                    {
                        while (input.Contains(substring))
                        {
                            input = input.Replace(substring, substitute);
                        }
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {input}");
        }
    }
}
