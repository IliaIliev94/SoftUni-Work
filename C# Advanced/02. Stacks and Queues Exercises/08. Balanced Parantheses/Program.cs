using System;
using System.Collections.Generic;

namespace _08._Balanced_Parantheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> parantheses = new Stack<char>();
            bool isBalanced = true;
            foreach(char character in input)
            {
                if(character == '(' || character == '{' || character == '[')
                {
                    parantheses.Push(character);
                }
                else 
                {
                    if(parantheses.Count > 0 && (character - parantheses.Peek() == 1 || character - parantheses.Peek() == 2))
                    {
                        parantheses.Pop();
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
            }
            if(isBalanced && parantheses.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
