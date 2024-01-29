using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab_02
{
    /// <summary>
    /// the base class for all books in the library system.
    /// </summary>
    public class Book : IBorrowBook
    {
        public string BookTitle {  get; set; }
        public string Author { get; set; }
        public bool BookIsAvailable { get; set; }

        // Constructor to initialize the book's title, author, and availability.
        public Book(string bookTitle, string author)
        {
            BookTitle = bookTitle;
            Author = author;
            BookIsAvailable = true;
        }

        // Method to borrow a book.
        public void BorrowTheBooks()
        {
            try
            {
                if (BookIsAvailable)
                {
                    Console.WriteLine($"The {BookTitle} is borrowed.");
                    BookIsAvailable = false;
                }
                else
                {
                    throw new Exception($"The {BookTitle} is not available for borrowing.");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    /// <summary>
    /// a fiction book, inheriting from the base Book class.
    /// </summary>
    public class FictionBook : Book
    {
        public string Genre { get; set; }

        // Constructor to initialize the fiction book with its title, author, and genre.
        public FictionBook(string bookTitle, string author, string genre) : base(bookTitle, author)
        {
            this.Genre = genre;
        }
    }

    /// <summary>
    /// a nonfiction book, inheriting from the base Book class.
    /// </summary>
    public class NonfictionBook : Book
    {
        public string Subject { get; set; }

        // Constructor to initialize the nonfiction book with its title, author, and subject.
        public NonfictionBook(string bookTitle, string author, string subject) : base(bookTitle, author)
        {
            this.Subject = subject;
        }
    }
}
