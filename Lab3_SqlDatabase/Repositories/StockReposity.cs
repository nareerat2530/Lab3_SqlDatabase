using System.Linq;
using Lab3_SqlDatabase.Interfaces;

namespace Lab3_SqlDatabase.Repositories
{
    public class StockReposity : Repository<Stock>, IStockRepository
    {
        private readonly BookStores_Lab2_NareeratContext _context;

        public StockReposity(BookStores_Lab2_NareeratContext context) : base(context)
        {
            _context = context;
        }
        public Stock GetStockByIsbnAndShopId(string isbn, int id)
        {
            return _context.Stocks.FirstOrDefault(s => s.IsbnId == isbn && s.ShopId == id);
        }
    }
}