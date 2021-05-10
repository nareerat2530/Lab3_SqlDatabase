using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_SqlDatabase
{
    public partial class AddbookForm : Form
    {
        private Author _author;
        private UnitOfWork.UnitOfWork _unitOfWork;
        public AddbookForm( Author author)
        {
            _author = author;
            _unitOfWork = new UnitOfWork.UnitOfWork(new BookStores_Lab2_NareeratContext());
            InitializeComponent();
        }


        private void bt_Summit_Click(object sender, EventArgs e)
        {
            var category = _unitOfWork.Category.GetCategoryByName(CategoryTextBox.Text.Trim());
          if(category == null)
          {
              category = new Category
              {
                  CategoryName = CategoryTextBox.Text.Trim()
              };
              _unitOfWork.Category.Add(category);
              _unitOfWork.Complete();
          }

          var _book = new Book
          {
              Title = TitleTextBox.Text,
              IsbnId = ISBNTextBox.Text,
              Category = category,
              Language = LanguageTextBox.Text,
              Price = Decimal.Parse(PriceTextBox.Text)
          };
          var booksAuthor = new BooksAuthor
          {
              IsbnId = _book.IsbnId,
              AuthorId = _author.AuthorId,
              Author = _author,
              Isbn = _book
          };
            _unitOfWork.Books.Add(_book);
            _unitOfWork.Complete();

        }
    }
}
