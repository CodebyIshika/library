using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab_02
{
    /// <summary>
    /// Interface defining methods for managing books in a library.
    /// </summary>
    internal interface IManageBooks
    {
        // Method to add a book to the library's collection.
        void AddBookToLibrary(List<string> library, Book AddBook);

        // Method to remove a book from the library's collection.
        void RemoveBookFromLibrary(List<string> library, Book RemoveBook);
    }
}
