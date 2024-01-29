using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> library = new List<string>();

            Member memberObj = new Member("Aaron", 20);
            Console.WriteLine($"Member : {memberObj.Name}, Id : {memberObj.Id}");

            Librarian librarianObj = new Librarian("Jackson", 50);
            Console.WriteLine($"Librarian : {librarianObj.Name}, Id : {librarianObj.Id}");

            Console.WriteLine("");
            FictionBook fictionBookObj = new FictionBook("Game of Thrones", "George R.R. Martin ", "Fantasy");
            Console.WriteLine($"Fiction Book: {fictionBookObj.BookTitle}, Genre: {fictionBookObj.Genre}");
            FictionBook fictionBookObj2 = new FictionBook("Murder on the Orient Express", "Agatha Christie", "Mystery");
            Console.WriteLine($"Fiction Book: {fictionBookObj2.BookTitle}, Genre: {fictionBookObj2.Genre}");


            NonfictionBook nonfictionBookObj = new NonfictionBook("A Brief History of Time", "Stephen Hawking", "Science");
            Console.WriteLine($"Nonfiction Book: {nonfictionBookObj.BookTitle}, Subject: {nonfictionBookObj.Subject}");

            Console.WriteLine("");
            // Adding books to the library
            library.Add(fictionBookObj.BookTitle);
            library.Add(fictionBookObj2.BookTitle);
            library.Add(nonfictionBookObj.BookTitle);

            Console.WriteLine("Library :");
            foreach (var bookTitle in library)
            {
                Console.WriteLine(bookTitle);
            }

            // Member borrows a book
            memberObj.BorrowTheBooks();
            memberObj.BorrowTheBooks(); //  just to showcase the exception handling

            Console.WriteLine("");
            // Librarian adds a book to the library
            librarianObj.AddBookToLibrary(library, fictionBookObj);

            // Librarian removes a book from the library
            librarianObj.RemoveBookFromLibrary(library, nonfictionBookObj);

            Console.WriteLine("");

            // Display updated library books
            Console.WriteLine("Updated Library Books:");
            foreach (var bookTitle in library)
            {
                Console.WriteLine(bookTitle);
            }

            // Execute the transaction
            Transaction transactionObj = new Transaction("Aaron", "Game of Thrones");
            transactionObj.ExecuteBorrowing();
        
           Console.ReadKey();
        }
    }
}
