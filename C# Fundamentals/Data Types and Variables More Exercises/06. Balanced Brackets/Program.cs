using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input;
            string bracket = "";
            bool isBalanced = true;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                if (input == "(" || input == ")")
                {
                    if (input == "(" && isBalanced == false)
                    {
                        break;
                    }
                    else if (input == "(" && bracket == ")")
                    {
                        isBalanced = true;
                        bracket = "";
                    }
                    else if (input == ")" && bracket == "(")
                    {
                        isBalanced = true;
                        bracket = "";
                    }
                    else
                    {
                        bracket = input;
                        isBalanced = false;
                    }

                }
            }
            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
            
        }
    }
}
