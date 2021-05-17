using System.Collections.Generic;

namespace Lab3_SqlDatabase.Interfaces
{
    public interface IBooksAuthorRepository : IRepository<BooksAuthor>
    {
        public List<BooksAuthor> GetBooksByAuthor(Author author);
    }
}