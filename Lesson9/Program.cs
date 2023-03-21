using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    enum Genre
    {
        Fantasy,
        Fiction,
        Drama,
        NonFiction
    }

    enum Cover
    {
        Hardcover,
        Softcover
    }
    
    internal class Program
        
    {
        
        static Book GetBook()
        {
            Book book = new Book();

            book.Id = Guid.NewGuid();
            book.Name = "Harry Potter and the Philosopher's Stone";
            book.Year = 1997;
            book.genre = Genre.Fiction;
            book.Category = "Kids";
            book.Author = "J. K. Rowling";
            book.cover = Cover.Hardcover;
            book.Summary = "\nIt is a story about Harry Potter, an orphan brought up by his aunt and uncle because his parents were killed when he was a baby." +
                "\nHarry is unloved by his uncle and aunt but everything changes when he is invited to join Hogwarts School of Witchcraft and Wizardry and he finds out he's a wizard.";
            return book;
        }

        static void PrintBook (Book book)
        {
            Console.WriteLine($"Book ID: {book.Id}");
            Console.WriteLine($"Book name: {book.Name}");
            Console.WriteLine($"Book year: {book.Year}");
            Console.WriteLine($"Book genre: {book.genre}");
            Console.WriteLine($"Book category: {book.Category}");
            Console.WriteLine($"Book author: {book.Author}");
            Console.WriteLine($"Book cover: {book.cover}");
            Console.WriteLine($"Book summary: {book.Summary}");

        }

        static void Main(string[] args)
        {
            var getFirstBook = GetBook();
            PrintBook(getFirstBook);
            Console.WriteLine();
            Console.WriteLine();
            var getAuthorInfo = GetAuthor();
            GetAuthor(getAuthorInfo);
        }

        static Author GetAuthor()
        {
            Author author = new Author();

            author.firstName = "J.K.";
            author.lastName = "Rowling";
            author.country = "Great Britain";
            author.dob = 1965;
            author.numberOfBooks = 30;
            return author;
        }

        static void GetAuthor (Author author)
        {
            Console.WriteLine($"Author First Name: {author.firstName}");
            Console.WriteLine($"Author Last Name: {author.lastName}");
            Console.WriteLine($"Author Country: {author.country}");
            Console.WriteLine($"Author Date of Birthday: {author.dob}");
            Console.WriteLine($"Number of books writte by {author.firstName} {author.lastName}: {author.numberOfBooks}");
        }
    }

    
}