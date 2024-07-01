using System;

namespace Lab10
{
    public class Book
    {
        public int    Id     { get; set; }
        public double Price  { get; set; }
        public string Title  { get; set; }
        public string Author { get; set; }
        public string Genre  { get; set; }

        public override string ToString()
        {
            return $"{Id} price={Price}$ genre:{Genre} Author:{Author} Title:{Title}";
        }
    }
}
