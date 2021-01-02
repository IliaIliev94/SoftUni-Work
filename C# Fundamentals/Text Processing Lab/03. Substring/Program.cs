using System;
using System.Text;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string removeString = Console.ReadLine();
            string input = Console.ReadLine();
            while(input.ToLower().Contains(removeString.ToLower()))
            {
                for (int i = 0; i <= input.Length - removeString.Length; i++)
                {
                    string temp = input.Substring(i, removeString.Length).ToLower();
                    if (temp.Equals(removeString.ToLower()))
                    {
                        input = input.Remove(i, removeString.Length);
                    }
                }
            }
            Console.WriteLine(input);
        }
    }
}
