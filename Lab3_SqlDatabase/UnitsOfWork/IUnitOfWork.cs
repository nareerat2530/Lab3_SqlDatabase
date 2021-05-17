using System;
using Lab3_SqlDatabase.Interfaces;

namespace Lab3_SqlDatabase.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository Books { get; }
        IAuthorRepository Authors { get; }
        IShopRepository Shops { get; }
        IStockRepository Stocks { get; }
        ICategoryRepository Category { get; }
        IBooksAuthorRepository BooksAuthor { get; }
        int Complete();
    }
}