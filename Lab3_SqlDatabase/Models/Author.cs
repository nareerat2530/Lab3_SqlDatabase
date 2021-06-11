using System;
using System.Collections.Generic;

#nullable disable

namespace Lab3_SqlDatabase
{
    public class Author
    {
        public Author()
        {
            BooksAuthors = new HashSet<BooksAuthor>();
        }

        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }

        public virtual ICollection<BooksAuthor> BooksAuthors { get; set; }
    }
}