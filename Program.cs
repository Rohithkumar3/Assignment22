using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Library library = new Library();

        while (true)
        {
            Console.WriteLine("\nLibrary Management System Menu: 1.Add Book 2. View All Books 3. Search by ID 4. Search by Title 5. Exit");
            Console.Write("Enter your choice: ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
               Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Book ID: ");
                    int bookId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter Genre: ");
                    string genre = Console.ReadLine();

                    Book newBook = new Book
                    {
                        BookId = bookId,
                        Title = title,
                        Author = author,
                        Genre = genre,
                        IsAvailable = true
                    };

                    library.AddBook(newBook);
                    break;

                case 2:
                    library.ViewAllBooks();
                    break;

                case 3:
                    Console.Write("Enter Book ID to search: ");
                    int searchId = int.Parse(Console.ReadLine());
                    library.SearchBookById(searchId);
                    break;

                case 4:
                    Console.Write("Enter Title to search: ");
                    string searchTitle = Console.ReadLine();
                    library.SearchBookByTitle(searchTitle);
                    break;

                case 5:
                    Console.WriteLine("Exiting program. Goodbye!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice!!!");
                    break;
                }
                Console.ReadLine();
            }
        }
    }
}

