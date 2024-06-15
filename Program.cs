using System;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nLibrary Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. List Books");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter book title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter book author: ");
                        string author = Console.ReadLine();
                        Book book = new Book(title, author);
                        library.AddBook(book);
                        break;
                    case "2":
                        Console.Write("Enter book title to remove: ");
                        string titleToRemove = Console.ReadLine();
                        library.RemoveBook(titleToRemove);
                        break;
                    case "3":
                        library.ListBooks();
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
