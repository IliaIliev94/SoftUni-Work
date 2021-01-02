using System;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Article newArticle = new Article(input[0], input[1], input[2]);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(':');

                if (commands[0].Equals("Edit"))
                {
                    newArticle.Edit(commands[1].Trim());
                }
                else if (commands[0].Equals("ChangeAuthor"))
                {
                    newArticle.ChangeAuthor(commands[1].Trim());
                }
                else
                {
                    newArticle.Rename(commands[1].Trim());
                }
            }

            newArticle.ToString();

        }
    }

}
