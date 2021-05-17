using System.Linq;
using Lab3_SqlDatabase.Interfaces;

namespace Lab3_SqlDatabase.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly BookStores_Lab2_NareeratContext _context;

        public CategoryRepository(BookStores_Lab2_NareeratContext context) : base(context)
        {
            _context = context;
        }
        public Category GetCategoryByName(string name)
        {
            return _context.Categories.FirstOrDefault(c => c.CategoryName.ToLower() == name.ToLower());
        }
    }
}