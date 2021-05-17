namespace Lab3_SqlDatabase.Interfaces
{
    public interface IStockRepository : IRepository<Stock>
    {
        Stock GetStockByIsbnAndShopId(string isbn, int id);
    }
}