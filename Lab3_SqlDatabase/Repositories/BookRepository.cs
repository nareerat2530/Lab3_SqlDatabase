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
        public BookRepository(DbContext context) : base(context)
        {
            _context = new BookStores_Lab2_NareeratContext();
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
    }
}
