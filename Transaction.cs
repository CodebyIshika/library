using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab_02
{
    /// <summary>
    /// Represents a transaction for borrowing a book.
    /// </summary>
    public class Transaction
    {
        // Properties to store information about the member and the book in the transaction.
        public string Member {  get; set; }

        public string BookName { get; set; }

        // Constructor to initialize a transaction with member and book details.
        public Transaction(string member, string bookName)
        {
            Member = member;
            BookName = bookName;
        }

        // Method to execute the borrowing 
        public void ExecuteBorrowing()
        {
            // Display a message indicating that a member has borrowed a specific book.
            Console.WriteLine($"{Member} has borrowed the {BookName}");
        }
    }
}
