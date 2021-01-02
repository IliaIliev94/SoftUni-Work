using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Articles
{
    class Article
    {
        private string Title;
        private string Content;
        private string Author;

        public Article(string Title, string Content, string Author)
        {
            this.Title = Title;
            this.Content = Content;
            this.Author = Author;
        }

        public void Edit(string NewContent)
        {
            this.Content = NewContent;
        }

        public void ChangeAuthor(string NewAuthor)
        {
            this.Author = NewAuthor;
        }
        public void Rename(string NewTitle)
        {
            this.Title = NewTitle;
        }

        public void ToString()
        {
            Console.WriteLine($"{this.Title} - {this.Content}: {this.Author}");
        }

    }
}
