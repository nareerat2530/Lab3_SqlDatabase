using System.Linq;
using Lab3_SqlDatabase.Interfaces;

namespace Lab3_SqlDatabase.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        private readonly BookStores_Lab2_NareeratContext _context;

        public AuthorRepository(BookStores_Lab2_NareeratContext context) : base(context)
        {
            _context = context;
        }

        public Author GetAuthorByNameAndLastName(string firstName, string lastName)
        {
            return _context.Authors.FirstOrDefault(a =>
                a.FirstName.ToLower() == firstName.ToLower() && a.LastName == lastName.ToLower());
        }
    }
}