using System.Collections;

namespace Lab11
{
    class Book : IComparable<Book>
    {
        class SortByAuthor : IComparer<Book>
        {
            public int Compare(Book? x, Book? y)
            {
                if (x == null && y == null) return 0;
                if (x == null) return -1;
                if (y == null) return 1;

                int res = x.Author.CompareTo(y.Author);
                if (res == 0) return x.CompareTo(y);
                return res;
            }
        }

        public static IComparer<Book> ByAuthor()
        {
            return new SortByAuthor();
        }

        public int    Id     { get; set; }
        public double Price  { get; set; }
        public string Title  { get; set; }
        public string Author { get; set; }

        public int CompareTo(Book? other)
        {
            if (other != null)
            {
                return (int)(Price - other.Price);
            }
            return 1;
        }

        public override string ToString()
        {
            return "id="+Id+" price="+Price+"$  "+Author+" : "+Title;
        }
    }
}
