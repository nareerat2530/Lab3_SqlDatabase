using Lab3_SqlDatabase.Interfaces;
using Lab3_SqlDatabase.Repositories;

namespace Lab3_SqlDatabase.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookStores_Lab2_NareeratContext _context;

        public UnitOfWork(BookStores_Lab2_NareeratContext context)
        {
            _context = context;
            Books = new BookRepository(_context);
            Authors = new AuthorRepository(_context);
            Stocks = new StockReposity(_context);
            Shops = new ShopRepository(_context);
            Category = new CategoryRepository(_context);
            BooksAuthor = new BooksAuthorRepository(_context);
        }

        public IBookRepository Books { get; }
        public IAuthorRepository Authors { get; }
        public IShopRepository Shops { get; }
        public IStockRepository Stocks { get; }
        public ICategoryRepository Category { get; }
        public IBooksAuthorRepository BooksAuthor { get; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}