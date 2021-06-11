using System;
using System.Windows.Forms;

namespace Lab3_SqlDatabase
{
    public partial class AddbookForm : Form
    {
        private readonly Author _author;

        private readonly UnitOfWork.UnitOfWork _unitOfWork;
        public AddbookForm(Author author)
        {
            _author = author;
            _unitOfWork = new UnitOfWork.UnitOfWork(new BookStores_Lab2_NareeratContext());
            InitializeComponent();
        }
        private void bt_Summit_Click(object sender, EventArgs e)
        {
            var category = _unitOfWork.Category.GetCategoryByName(CategoryTextBox.Text.Trim());
            if (category == null)
            {
                category = new Category
                {
                    CategoryName = CategoryTextBox.Text.Trim()
                };
                _unitOfWork.Category.Add(category);
                _unitOfWork.Complete();
            }

            var book = _unitOfWork.Books.GetBookWithISBN(ISBNTextBox.Text.Trim());
            if (book == null)
            {
                book = new Book
                {
                    Title = TitleTextBox.Text.Trim(),
                    IsbnId = ISBNTextBox.Text.Trim(),
                    CategoryId = category.CategoryId,
                    Category = category,
                    Language = LanguageTextBox.Text.Trim(),
                    Price = decimal.Parse(PriceTextBox.Text)
                };
            }
            else
            {
                MessageBox.Show("A book with this isbn exist");
                return;
            }

            var booksAuthor = new BooksAuthor
            {
                IsbnId = book.IsbnId,
                AuthorId = _author.AuthorId,
                Isbn = book
            };

            _unitOfWork.Books.Add(book);
            _unitOfWork.BooksAuthor.Add(booksAuthor);
            _unitOfWork.Complete();
            Hide();
            MessageBox.Show($"You have added a {book.Title}");
        }
        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AddbookForm_Load(object sender, EventArgs e)
        {
            Label_Author.Text = _author.FirstName + " " + _author.LastName;
        }
    }
}