using Lab3_SqlDatabase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_SqlDatabase.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    { 
        IBookRepository Books { get; }
        IAuthorRepository Authors { get; }

        IShopRepository Shops { get; }
        IStockRepository Stocks { get; }
        ICategoryRepository Category { get; }
        int Complete();
    }
}
