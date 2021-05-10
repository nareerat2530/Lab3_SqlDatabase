using Lab3_SqlDatabase.Interfaces;
using Lab3_SqlDatabase.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_SqlDatabase.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public UnitOfWork(DbContext context)
        {
            _context = context;
            Books = new BookRepository(_context);
            Authors = new AuthorRepository(_context);
            Stocks = new StockReposity(_context);
            Shops = new ShopRepository(_context);
            Category = new CategoryRepository(_context);
        }
        

        public IBookRepository Books { get; private set; }

        public IAuthorRepository Authors { get; private set; }

        public IShopRepository Shops { get; private set; }

        public IStockRepository Stocks { get; private set; }
        public ICategoryRepository Category { get; private set; }

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
