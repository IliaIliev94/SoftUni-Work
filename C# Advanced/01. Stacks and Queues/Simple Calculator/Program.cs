using System;
using System.Collections.Generic;
namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            Stack<string> expressions = new Stack<string>();

            for(int i = input.Length - 1; i >= 0; i--)
            {
                expressions.Push(input[i]);
            }
            
            while(expressions.Count > 1)
            {
                int firstNum = int.Parse(expressions.Pop());
                string operatorSign = expressions.Pop();
                int secondNum = int.Parse(expressions.Pop());

                if(operatorSign.Equals("+"))
                {
                    expressions.Push((firstNum + secondNum).ToString());
                }
                else
                {
                    expressions.Push((firstNum - secondNum).ToString());
                }
            }
            Console.WriteLine(expressions.Peek());
        }
    }
}
