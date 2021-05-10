namespace Lab3_SqlDatabase.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetCategoryByName(string name);
    }
}