using System.Xml.Serialization;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = Books.TestBooks;
            string path = Path.Combine(".", "books.xml");

            // Сериализация books
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Book[]));
            using (StreamWriter sw = new StreamWriter(path))
            {
                xmlSerializer.Serialize(sw, books);
            }

            // Десериализация books
            Console.WriteLine("Ok");

            using (StreamReader sr = new StreamReader(path))
            {
                var booksDeserialized = xmlSerializer.Deserialize(sr) as Book[];
                foreach (Book book in booksDeserialized)
                {
                    Console.WriteLine(book);
                }
            }
            
            
        }
    }
}
