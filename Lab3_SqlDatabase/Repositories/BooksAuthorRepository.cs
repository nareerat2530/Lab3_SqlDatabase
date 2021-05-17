using System.Collections.Generic;
using System.Linq;
using Lab3_SqlDatabase.Interfaces;

namespace Lab3_SqlDatabase.Repositories
{
    public class BooksAuthorRepository : Repository<BooksAuthor>, IBooksAuthorRepository
    {
        private readonly BookStores_Lab2_NareeratContext _context;

        public BooksAuthorRepository(BookStores_Lab2_NareeratContext context) : base(context)
        {
            _context = context;
        }

        public List<BooksAuthor> GetBooksByAuthor(Author author)
        {
            return _context.BooksAuthors.Where(b => b.AuthorId == author.Id).ToList();
        }
    }
}