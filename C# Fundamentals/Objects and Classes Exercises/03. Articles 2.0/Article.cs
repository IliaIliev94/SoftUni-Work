using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Articles_2._0
{
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
