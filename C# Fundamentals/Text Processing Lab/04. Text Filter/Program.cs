using System;
using System.Text;
namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                while(text.Contains(bannedWords[i]))
                {
                    string temp = new string("");
                    for (int j = 0; j < bannedWords[i].Length; j++)
                    {
                        temp = string.Concat(temp, "*");
                    }
                    text = text.Replace(bannedWords[i], temp);
                }
            }
            Console.WriteLine(text);
        }
    }
}
