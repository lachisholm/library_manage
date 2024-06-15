using System;
using System.Collections.Generic;

namespace LibraryManagement
{
    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added successfully.");
        }

        public void RemoveBook(string title)
        {
            Book bookToRemove = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine("Book removed successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void ListBooks()
        {
            Console.WriteLine("Listing all books:");
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }
        }
    }
}
