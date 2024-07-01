using System;
using System.IO;
using System.Security.Cryptography;
using static System.Reflection.Metadata.BlobBuilder;

namespace Lab10
{
    class Program
    {
        static IList<double> GetBooks(Book[] books, String genre = null)
        {
            if (genre == null)
            {
                return (from b in books select b.Price).ToList();
            }
            else
            {
                return (from b in books where b.Genre == genre select b.Price).ToList();
            }
        }

        static void Main(string[] args)
        {
            Book[] books = Books.TestBooks;
            IList<double> all = GetBooks(books);
            Console.WriteLine($"All books average price: {all.Average()}");

            Console.WriteLine(); // ---------------------------------------------------

            IList<double> tech = GetBooks(books, "tech");
            Console.WriteLine($"Tech books average tech price: {tech.Average()}");

            Console.WriteLine(); // ---------------------------------------------------

            IList<string> groups = (from b in books group b by b.Genre into gr select gr.Key).ToList();
            foreach (string group in groups)
            {
                IList<double> booksOfGenre = GetBooks(books, group);
                Console.WriteLine($"\"{group}\" books average tech price: {booksOfGenre.Average()}");
            }

            Console.WriteLine(); // ---------------------------------------------------

            var groups2 = from b in books
                          group b by b.Genre into gr
                          select new { Genre = gr.Key, price = gr.Average(b => b.Price) };
            foreach (var group in groups2)
            {
                Console.WriteLine($"\"{group.Genre}\" books average tech price: {group.price}");
            }

            Console.WriteLine("Ok");
        }
    }
}
