using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _8_collection_generic.Model.B;

namespace _8_collection_generic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Title = "C# Programming",
                    Author = "John Doe",
                },
                new Book
                {
                    Id = 2,
                    Title = "Learn LINQ",
                    Author = "Jane Smith",
                },
                new Book
                {
                    Id = 3,
                    Title = "Mastering Generics",
                    Author = "Alice Brown",
                },
            };

            System.Console.WriteLine("LIST OF BOOKS");
            foreach (Book book in books)
            {
                System.Console.WriteLine(book); // will call the ToString method
            }

            System.Console.WriteLine("");
            Dictionary<int, Book> bookDictionary = new Dictionary<int, Book>();
            foreach (var book in books)
            {
                bookDictionary[book.Id] = book;
            }

            System.Console.WriteLine("SEARCH ING FOR BOOK WITH ID 2");
            if (bookDictionary.TryGetValue(2, out Book foundBook))
            {
                System.Console.WriteLine(foundBook);
            }
            else
            {
                System.Console.WriteLine("BOOK NOT FOUND");
            }

            // adding new book data to the dictionary
            Book bookId4 = new Book
            {
                Id = 4,
                Title = "Javascript Notes",
                Author = "Alice Johnson",
            };

            bookDictionary.Add(bookId4.Id, bookId4);
            bookDictionary[bookId4.Id] = bookId4;

            System.Console.WriteLine("LIST OF NEW BOOKS AFTER ADDING NEW ITEM TO THE DICTIONARY");
            foreach (Book book in bookDictionary.Values)
            {
                System.Console.WriteLine(book);
            }

            System.Console.WriteLine("");
            // remove item from dictionary
            // books.RemoveAll(b => b.Id == 2); // Remove for  list collection
            bookDictionary.Remove(2); // Remove for dictionary

            System.Console.WriteLine("LIST OF BOOKS AFTER REMOVING ITEM FROM THE DICTIONARY");
            foreach (Book book in bookDictionary.Values)
            {
                System.Console.WriteLine(book);
            }
        }
    }
}
