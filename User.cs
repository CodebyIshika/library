using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab_02
{
    /// <summary>
    /// the base class for all users in the library system.
    /// </summary>
    class User
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public User(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
    }

    /// <summary>
    /// a library member, inheriting from the User class and implementing IBorrowBook interface
    /// </summary>
    class Member : User, IBorrowBook
    {
        public Member(string name, int id) : base(name, id)
        {

        }

        // Method to borrow books for a member.
        public void BorrowTheBooks()
        {
            // Implementation for borrowing books goes here
        }
    }

    /// <summary>
    /// a librarian, inheriting from the User class and implementing IManageBooks interface.
    /// </summary>
    class Librarian : User, IManageBooks
    {
        public Librarian(string name, int userId) : base(name, userId)
        {

        }

        // Method to add a book to the library's collection.
        public void AddBookToLibrary(List<string> library, Book addBook)
        {
            try
            {
                if (!library.Contains(addBook.BookTitle))
                {
                    library.Add(addBook.BookTitle);
                    Console.WriteLine($"{addBook.BookTitle} is added to library.");
                }
                else
                {
                    throw new Exception($"{addBook.BookTitle} is already in the library.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Method to remove a book from the library's collection.
        public void RemoveBookFromLibrary(List<string> library, Book RemoveBook)
        {
            try
            {
                if (library.Contains(RemoveBook.BookTitle))
                {
                    library.Remove(RemoveBook.BookTitle);
                    Console.WriteLine($"{RemoveBook.BookTitle} is removed from the library.");
                }
                else
                {
                    throw new Exception($"{RemoveBook.BookTitle} is not in the library.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

}
