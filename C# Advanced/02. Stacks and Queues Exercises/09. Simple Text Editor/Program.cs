using System;
using System.Collections.Generic;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> operations = new Stack<string>();
            string text = "";
            for(int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                if(command[0] == "1")
                {
                    operations.Push(text);
                    text += command[1];
                }
                else if(command[0] == "2")
                {
                    int startIndex = text.Length - int.Parse(command[1]);
                    operations.Push(text);
                    text = text.Remove(startIndex, int.Parse(command[1]));
                    
                }
                else if(command[0] == "3")
                {
                    Console.WriteLine(text[int.Parse(command[1]) - 1]);
                }
                else
                {
                    text = operations.Pop();
                }
            }
        }
    }
}
