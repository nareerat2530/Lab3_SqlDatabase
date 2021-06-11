using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Lab3_SqlDatabase
{
    public partial class Form1 : Form
    {
        private readonly BookStores_Lab2_NareeratContext db = new();
        private Author _authorIsActive;
        private Shop _shopIsActive;
        private readonly UnitOfWork.UnitOfWork _unitOfWork;
        private List<Author> authors;
        private List<Book> books;
        private List<Shop> shops;
        private List<Stock> stocks;
        
        public Form1()
        {
            _unitOfWork = new UnitOfWork.UnitOfWork(new BookStores_Lab2_NareeratContext());
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (db.Database.CanConnect())
            {
                treeView1.Nodes.Clear();
                dataGridView1.Hide();
                TreeNodeInformation();
                DataGridWriter(e);
                books = _unitOfWork.Books.GetAll().ToList();
                authors = _unitOfWork.Authors.GetAll().ToList();
                shops = _unitOfWork.Shops.GetAll().ToList();
                stocks = _unitOfWork.Stocks.GetAll().ToList();

                _unitOfWork.Complete();
                dataGridView1.Refresh();
                dataGridView1.Update();
            }
            else
            {
                Debug.WriteLine("Failed!");
            }
        }
        private void TreeNodeInformation()
        {
            books = _unitOfWork.Books.GetAll().ToList();
            authors = _unitOfWork.Authors.GetAll().ToList();
            shops = _unitOfWork.Shops.GetAll().ToList();
            stocks = _unitOfWork.Stocks.GetAll().ToList();
            authors = authors.OrderBy(a => a.FirstName).ToList();

            TreeNode authorNode = new()
            {
                Name = "Authors",
                Text = "Authors",
                Tag = "Authors"
            };

            foreach (var writer in authors.Select(author => new TreeNode
            {
                Text = author.FirstName + " " + author.LastName,
                Tag = author
            }))
            {
                authorNode.Nodes.Add(writer);
            }

            TreeNode shopNode = new()
            {
                Text = "Shops",
                Tag = "Shops"
            };
            foreach (var storeNode in shops.Select(shop => new TreeNode
            {
                Text = shop.ShopName,
                Tag = shop
            }))
            {
                shopNode.Nodes.Add(storeNode);
            }

            treeView1.Nodes.Add(authorNode);
            treeView1.Nodes.Add(shopNode);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            bt_RemoveAuthor.Hide();
            bt_AddAuthor.Hide();
            bt_Addbook.Hide();
            bt_Removebook.Hide();
            var tag = e.Node.Tag;
            DataGridWriter(tag);
        }
        public void DataGridWriter(object o)
        {
            dataGridView1.Show();
            dataGridView1.Update();
            dataGridView1.Refresh();
            books = _unitOfWork.Books.GetAll().ToList();
            authors = _unitOfWork.Authors.GetAll().ToList();
            shops = _unitOfWork.Shops.GetAll().ToList();
            stocks = _unitOfWork.Stocks.GetAll().ToList();
            treeView1.Refresh();
            if (o is null) return;
            switch (o)
            {
                case Shop shop:
                {
                    bt_Addbook.Show();
                    bt_Removebook.Show();
                    _shopIsActive = shop;
                    _authorIsActive = null;
                    dataGridView1.Columns.Add("ISBN", "ISBN");
                    dataGridView1.Columns.Add("Name", "Name");
                    dataGridView1.Columns.Add("Quantity", "Quantity");
                    var stocks = _unitOfWork.Stocks.GetAll().ToList();
                    foreach (var book in books)
                    foreach (var stock in stocks)
                        if (shop.ShopId == stock.ShopId)
                            if (stock.IsbnId == book.IsbnId)
                            {
                                var rowIndex = dataGridView1.Rows.Add();
                                dataGridView1.Rows[rowIndex].Tag = stock;
                                dataGridView1.Rows[rowIndex].Cells["Name"].Value = book.Title;
                                dataGridView1.Rows[rowIndex].Cells["ISBN"].Value = stock.IsbnId;
                                dataGridView1.Rows[rowIndex].Cells["Quantity"].Value = stock.Quantity;
                            }

                    break;
                }
                case Author author:
                {
                    bt_AddAuthor.Show();
                    bt_RemoveAuthor.Show();
                    bt_Addbook.Show();
                    bt_Removebook.Show();
                    _authorIsActive = author;
                    dataGridView1.Columns.Add("ISBN", "ISBN");
                    dataGridView1.Columns.Add("Category", "Category");
                    dataGridView1.Columns.Add("Title", "Title");

                    var booksWithAuthorAndCategory = _unitOfWork.Books.GetBookWithAuthorAndCategory();
                    foreach (var book in booksWithAuthorAndCategory)
                    foreach (var authors in book.BooksAuthors)
                        if (authors.AuthorId == author.AuthorId)
                        {
                            var rowIndex = dataGridView1.Rows.Add();
                            dataGridView1.Rows[rowIndex].Cells["Title"].Value = book.Title;
                            dataGridView1.Rows[rowIndex].Cells["Category"].Value = book.Category.CategoryName;
                            dataGridView1.Rows[rowIndex].Cells["ISBN"].Value = book.IsbnId;
                        }

                    break;
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (e.ColumnIndex == 2)
            {
                var stock = dataGridView1.Rows[e.RowIndex].Tag as Stock;

                if (int.TryParse(cell.Value.ToString(), out var result))
                    if (stock != null)
                        stock.Quantity = result;
            }

            _unitOfWork.Complete();
        }

        private void bt_Removebook_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null) return;
            var removeBook = dataGridView1.CurrentCell.RowIndex;
            string isbn;
            if (_authorIsActive == null)
                if (dataGridView1.SelectedCells[0].Value != null)
                {
                    isbn = dataGridView1.SelectedCells[0].Value.ToString();
                    var stock = _unitOfWork.Stocks.GetStockByIsbnAndShopId(isbn, _shopIsActive.ShopId);

                    dataGridView1.Rows.RemoveAt(removeBook);
                    stocks.RemoveAll(s => s.ShopId == _shopIsActive.ShopId && s.IsbnId == isbn);
                    _unitOfWork.Stocks.Remove(stock);
                    _unitOfWork.Complete();

                    return;
                }

            isbn = dataGridView1.SelectedCells[0].Value.ToString();
            var book = _unitOfWork.Books.GetBookWithISBN(isbn);
            books.RemoveAll(b => b.IsbnId == book.IsbnId);
            dataGridView1.Rows.RemoveAt(removeBook);
            _unitOfWork.Books.Remove(book);
            _unitOfWork.Complete();
            MessageBox.Show("Book removed Successfully");
        }

        private void bt_RemoveAuthor_Click(object sender, EventArgs e)
        {
            var author = treeView1.SelectedNode.Tag as Author;
            var bookList = _unitOfWork.Books.GetBookWithAuthorAndCategory();
            var books = bookList.Where(b => b.BooksAuthors.Any(a => a.AuthorId == author.AuthorId));

            treeView1.Nodes.Remove(treeView1.SelectedNode);
            _unitOfWork.Authors.Remove(author);
            _unitOfWork.Books.RemoveRange(books);
            _unitOfWork.Complete();
            treeView1.Nodes.Clear();
            TreeNodeInformation();
        }
        private void bt_Addbook_Click(object sender, EventArgs e)
        {
            if (_authorIsActive == null)
            {
                var addExitBook = new AddExistBook(_shopIsActive);
                addExitBook.Show();
                dataGridView1.Refresh();
                dataGridView1.Update();
                return;
            }

            var addBook = new AddbookForm(_authorIsActive);

            addBook.Show();
            dataGridView1.Refresh();
            dataGridView1.Update();
        }
        private void bt_Exit_Click(object sender, EventArgs e)
        {
            DialogResult exitButton;
            exitButton = MessageBox.Show("Confirm if you want to exit", "Save DataGirdView", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (exitButton == DialogResult.Yes) Application.Exit();
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            books = _unitOfWork.Books.GetAll().ToList();
            authors = _unitOfWork.Authors.GetAll().ToList();
            shops = _unitOfWork.Shops.GetAll().ToList();
            stocks = _unitOfWork.Stocks.GetAll().ToList();
            treeView1.Nodes.Clear();
            dataGridView1.Hide();
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.Update();
            TreeNodeInformation();
            DataGridWriter(e);
        }
        private void bt_AddAuthor_Click(object sender, EventArgs e)
        {
            var abbAuthor = new AddAuthorForm();
            abbAuthor.Show();
            dataGridView1.Refresh();
            dataGridView1.Update();
        }
    }
}