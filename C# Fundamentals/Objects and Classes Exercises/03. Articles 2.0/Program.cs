using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> newArticles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(", ");
                newArticles.Add(new Article(commands[0], commands[1], commands[2]));
            }
            string sort = Console.ReadLine();

            if (sort.Equals("title"))
            {
                newArticles.Sort((s, y) => string.Compare(s.Title, y.Title));
            }
            else if (sort.Equals("content"))
            {
                newArticles.Sort((s, y) => string.Compare(s.Content, y.Content));
            }
            else
            {
                newArticles.Sort((s, y) => string.Compare(s.Author, y.Author));

            }

            for (int i = 0; i < newArticles.Count; i++)
            {
                Console.WriteLine($"{newArticles[i].Title} - {newArticles[i].Content}: {newArticles[i].Author}");
            }
        }
    }
    class Article
    {

        public Article(string Title, string Content, string Author)
        {
            this.Title = Title;
            this.Content = Content;
            this.Author = Author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }


    }
}
