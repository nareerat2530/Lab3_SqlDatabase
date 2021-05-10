using System.Linq;
using Lab3_SqlDatabase.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab3_SqlDatabase.Repositories
{
    
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private BookStores_Lab2_NareeratContext _context;

        public CategoryRepository(DbContext context) : base(context)
        {
            _context = new BookStores_Lab2_NareeratContext();
        }

        public Category GetCategoryByName(string name)
        {
            return _context.Categories.FirstOrDefault(c => c.CategoryName == name);
        }
    }
}