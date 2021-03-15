using BookShop.Models;
using BookShop.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookShop.Models
{
    public class Book
    {
        public Book()
        {
            this.BookCategories = new HashSet<BookCategory>();
        }
        public int BookId { get; set; }

        [Required, MaxLength(50)]
        public string Title { get; set; }

        [Required, MaxLength(1000)]
        public string Description { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? ReleaseDate { get; set; }

        public int Copies { get; set; }

        public decimal Price { get; set; }

        public EditionType EditionType { get; set; }

        public AgeRestriction AgeRestriction { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }

        public virtual ICollection<BookCategory> BookCategories { get; set; }

    }
}
