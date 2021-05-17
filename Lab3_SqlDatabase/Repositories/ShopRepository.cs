using Lab3_SqlDatabase.Interfaces;

namespace Lab3_SqlDatabase.Repositories
{
    internal class ShopRepository : Repository<Shop>, IShopRepository
    {
        public ShopRepository(BookStores_Lab2_NareeratContext context) : base(context)
        {
        }
    }
}