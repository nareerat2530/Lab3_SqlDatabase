using Lab3_SqlDatabase.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_SqlDatabase.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private BookStores_Lab2_NareeratContext _context;
        public BookRepository( BookStores_Lab2_NareeratContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetBookWithAuthorAndCategory()
        {
            return _context.Books
                .Include(c => c.Category)
                .Include(c => c.BooksAuthors);


        }
        

        public Book GetBookWithISBN(string isbn)
        {
            return _context.Books.FirstOrDefault(b => b.IsbnId == isbn);
        }

        public Book GetBookWithTitle(string title)
        {
            return _context.Books.FirstOrDefault(b => b.Title == title);
        }
    }
}
