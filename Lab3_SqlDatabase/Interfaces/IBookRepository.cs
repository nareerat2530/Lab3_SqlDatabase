using System.Collections.Generic;

namespace Lab3_SqlDatabase.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetBookWithAuthorAndCategory();
        Book GetBookWithISBN(string isbn);

        Book GetBookWithTitle(string title);
    }
}