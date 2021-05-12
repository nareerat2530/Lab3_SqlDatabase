using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_SqlDatabase.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetBookWithAuthorAndCategory();
        Book GetBookWithISBN(string isbn);

        Book GetBookWithTitle(string title);
    }
}
