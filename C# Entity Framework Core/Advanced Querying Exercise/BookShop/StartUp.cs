using BookShop.Data;
using BookShop.Initializer;
using BookShop.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BookShop
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            BookShopContext dbContext = new BookShopContext();
            DbInitializer.ResetDatabase(dbContext);
            Console.WriteLine(RemoveBooks(dbContext));
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {

            var books = context.Books
                .Where(book => book.AgeRestriction == (AgeRestriction)Enum.Parse(typeof(AgeRestriction), command, true))
                .Select(book => book.Title)
                .OrderBy(book => book)
                .ToList();

            return string.Join(Environment.NewLine, books);
        }

        public static string GetGoldenBooks(BookShopContext context)
        {

            var bookTitles = context.Books
                .Where(book => book.EditionType == EditionType.Gold && book.Copies < 5000)
                .OrderBy(book => book.BookId)
                .Select(book => book.Title)
                .ToList();

            return string.Join(Environment.NewLine, bookTitles);
        }

        public static string GetBooksByPrice(BookShopContext context)
        {

            var books = context.Books
                .Select(book => new { book.Title, Price = book.Price })
                .Where(book => book.Price > 40)
                .OrderByDescending(book => book.Price)
                .ToList();

            return FormatData(books, "{Title} - ${Price}");

        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var books = context.Books
                .Where(book => book.ReleaseDate.Value.Year != year)
                .OrderBy(book => book.BookId)
                .Select(book => book.Title)
                .ToList();

            return string.Join(Environment.NewLine, books);
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var books = context.BooksCategories
                .Where(bookCategory => input.ToLower().Contains(bookCategory.Category.Name.ToLower()))
                .OrderBy(bookCategory => bookCategory.Book.Title)
                .Select(bookCategory => bookCategory.Book.Title)
                .ToList();

            return string.Join(Environment.NewLine, books);
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {

            var books = context.Books.
                Where(book => DateTime.Compare(book.ReleaseDate.Value, DateTime.ParseExact(date, "dd-MM-yyyy", null)) < 0)
                .OrderByDescending(book => book.ReleaseDate.Value)
                .Select(book => new { book.Title, book.EditionType, book.Price })
                .ToList();


            return FormatData(books, "{Title} - {EditionType} - ${Price}");
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authors = context.Authors.
                Where(author => author.FirstName.EndsWith(input))
                .Select(author => author.FirstName + " " + author.LastName)
                .OrderBy(author => author)
                .ToList();

            return string.Join(Environment.NewLine, authors);
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var books = context.Books
                .Where(book => book.Title.ToLower().Contains(input.ToLower()))
                .Select(book => book.Title)
                .OrderBy(book => book)
                .ToList();

            return string.Join(Environment.NewLine, books);
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var books = context.Books
                .OrderBy(book => book.BookId)
                .Select(book => new 
                { 
                    book.Title, 
                    AuthorFirstName = book.Author.FirstName, 
                    AuthorLastName = book.Author.LastName 
                })
                .Where(book => book.AuthorLastName.StartsWith(input, true, null))
                .ToList();

            return FormatData(books, "{Title} ({AuthorFirstName} {AuthorLastName})");
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            int booksCount = context.Books
                .Where(book => book.Title.Length > lengthCheck)
                .Count();

            return booksCount;
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var authorBookCopies = context.Authors
                .Select(author => new
                {
                    AuthorFullName = author.FirstName + " " + author.LastName,
                    BookCopies = author.Books.Select(book => book.Copies).Sum()
                })
                .OrderByDescending(author => author.BookCopies)
                .ToList();

            return FormatData(authorBookCopies, "{AuthorFullName} - {BookCopies}");
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var booksTotalProfit = context.Categories
                .Select(category => new
                {
                    CategoryName = category.Name,
                    TotalProfit = category.CategoryBooks.Select(cb => cb.Book.Price * cb.Book.Copies).Sum()
                })
                .OrderByDescending(category => category.TotalProfit)
                .ThenBy(category => category.CategoryName)
                .ToList();

            return FormatData(booksTotalProfit, "{CategoryName} ${TotalProfit}");
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var books = context.Categories
                .Select(category => new
                {
                    category.Name,
                    Books = category.CategoryBooks
                        .Select(cb => new
                        {
                            Title = cb.Book.Title,
                            ReleaseDate = cb.Book.ReleaseDate.Value
                        })
                        .OrderByDescending(book => book.ReleaseDate)
                        .Take(3)
                        .ToList()
                })
                .OrderBy(category => category.Name)
                .ToList();

            return string.Join(Environment.NewLine, books.Select(category => $"--{category.Name}" +
                $"{Environment.NewLine}{string.Join(Environment.NewLine, category.Books.Select(book => $"{book.Title} ({book.ReleaseDate.Year})"))}"));
        }

        public static void IncreasePrices(BookShopContext context)
        {
            var books = context.Books.
                Where(book => book.ReleaseDate.Value.Year < 2010)
                .ToList();

            foreach(var book in books)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var books = context.Books
                .Where(book => book.Copies < 4200)
                .ToList();

            int booksCount = books.Count;

            foreach(var book in books)
            {
                context.Books.Remove(book);
            }

            context.SaveChanges();

            return booksCount;
        }

        public static string FormatData<T>(List<T> entities, string text)
        {
            StringBuilder result = new StringBuilder();

            foreach(T entity in entities)
            {
                string line = text;
                foreach(string property in entity.GetType().GetProperties().Select(property => property.Name))
                {
                    PropertyInfo propertyInfo = entity.GetType().GetProperty(property);
                    string valueToAppend = propertyInfo.PropertyType.Name == "Decimal" ? ((decimal)propertyInfo.GetValue(entity)).ToString("0.00") : propertyInfo.GetValue(entity).ToString();
                    line = line.Replace("{" + property + "}", valueToAppend);
                }
                result.AppendLine(line);
            }

            return result.ToString().TrimEnd();
        }

    }
}
