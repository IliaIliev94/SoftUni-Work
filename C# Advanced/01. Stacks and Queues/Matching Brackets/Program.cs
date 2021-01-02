using System;
using System.Collections.Generic;
using System.Text;

namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Stack<int> expressions = new Stack<int>();
            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == '(')
                {
                    expressions.Push(i);
                }
                else if(input[i] == ')')
                {
                    int startIndex = expressions.Pop();
                    Console.WriteLine(input.Substring(startIndex, i + 1 - startIndex));
                }
            }
        }
    }
}
