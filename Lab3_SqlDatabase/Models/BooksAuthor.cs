using System;
using System.Collections.Generic;

#nullable disable

namespace Lab3_SqlDatabase
{
    public partial class BooksAuthor
    {
        public int BaId { get; set; }
        public string IsbnId { get; set; }
        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Book Isbn { get; set; }
    }
}
