using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Lab3_SqlDatabase
{
    public partial class Form1 : Form
    {
        private List<Author> authors;
        private List<Book> books;

        private readonly BookStores_Lab2_NareeratContext db = new();
        private List<Shop> shops;
        private List<Stock> stocks;
        private UnitOfWork.UnitOfWork unitOfWork;
        private Author _authorIsActive;
        private Shop _shopIsActive;


        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            if (db.Database.CanConnect())
            {
                unitOfWork = new UnitOfWork.UnitOfWork(new BookStores_Lab2_NareeratContext());
                books = unitOfWork.Books.GetAll().ToList();
                authors = unitOfWork.Authors.GetAll().ToList();
                shops = unitOfWork.Shops.GetAll().ToList();
                stocks = unitOfWork.Stocks.GetAll().ToList();
              
                
                TreeNode authorNode = new()
                {
                    Name = "Authors",
                    Text = "Authors",
                    Tag = "Authors"
                };

                foreach (var author in authors)
                {
                    var writer = new TreeNode
                    {
                        Text = author.FirstName +" "+ author.LastName,
                        Tag = author
                    };
                    authorNode.Nodes.Add(writer);
                }

                TreeNode shopNode = new()
                {
                    Text = "Shops",
                    Tag = "Shops"
                };
                foreach (var shop in shops)
                {
                    var storeNode = new TreeNode
                    {
                        Text = shop.ShopName,
                        Tag = shop
                    };

                    shopNode.Nodes.Add(storeNode);
                }

                treeView1.Nodes.Add(authorNode);
                treeView1.Nodes.Add(shopNode);
            }
            else
            {
                Debug.WriteLine("Failed!");
            }
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

        public void DataGridWriter(Object o)
        {
            dataGridView1.Show();
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

                    foreach (var book in books)
                    foreach (var stock in stocks)
                        if (shop.ShopId == stock.ShopId)
                            if (stock.IsbnId == book.IsbnId)
                            {
                                var rowIndex = dataGridView1.Rows.Add();
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

                    var booksWithAuthorAndCategory = unitOfWork.Books.GetBookWithAuthorAndCategory();
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

        private void bt_Removebook_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null) return;
            var removeBook = dataGridView1.CurrentCell.RowIndex;
            string? isbn;
            if (_authorIsActive == null)
            {
                if (dataGridView1.SelectedCells[0].Value != null)
                {
                    isbn = dataGridView1.SelectedCells[0].Value.ToString();
                    var stock = unitOfWork.Stocks.GetStockByIsbnAndShopId(isbn,_shopIsActive.ShopId );
                    
                    dataGridView1.Rows.RemoveAt(removeBook);
                    stocks.RemoveAll(s => s.ShopId == _shopIsActive.ShopId && s.IsbnId == isbn );
                    unitOfWork.Stocks.Remove(stock);
                    unitOfWork.Complete();
                    
                    return;
                }
            }

            isbn = dataGridView1.SelectedCells[0].Value.ToString();
            var book = unitOfWork.Books.GetBookWithISBN(isbn);
            books.RemoveAll(b => b.IsbnId == book.IsbnId);
            unitOfWork.Books.Remove(book);
            unitOfWork.Complete();
            
            
        }

        private void bt_Addbook_Click(object sender, EventArgs e)
        {
            
            if (_authorIsActive == null)
            {
                var addExitBook = new AddExistBook(_shopIsActive);
                addExitBook.Show();
                return;
                
            }
            var addBook = new AddbookForm(_authorIsActive);
            addBook.Show();
            
                
            dataGridView1.Hide();
            
            
            
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
            dataGridView1.Hide();
           books = unitOfWork.Books.GetAll().ToList();
           authors = unitOfWork.Authors.GetAll().ToList();
           shops = unitOfWork.Shops.GetAll().ToList();
           stocks = unitOfWork.Stocks.GetAll().ToList();
        }
    }
}