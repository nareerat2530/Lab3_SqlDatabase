using System.Collections.Generic;

#nullable disable

namespace Lab3_SqlDatabase
{
    public class Book
    {
        public Book()
        {
            BooksAuthors = new HashSet<BooksAuthor>();
            Orderdetails = new HashSet<Orderdetail>();
            Stocks = new HashSet<Stock>();
        }

        public string IsbnId { get; set; }
        public string Title { get; set; }
        public int? CategoryId { get; set; }
        public string Language { get; set; }
        public decimal Price { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<BooksAuthor> BooksAuthors { get; set; }
        public virtual ICollection<Orderdetail> Orderdetails { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}