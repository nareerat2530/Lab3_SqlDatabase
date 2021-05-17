namespace Lab3_SqlDatabase.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Author GetAuthorByNameAndLastName(string firstName, string lastName);
    }
}