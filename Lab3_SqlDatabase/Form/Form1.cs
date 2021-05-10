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
                    var authorNodes = new TreeNode
                    {
                        Text = author.FirstName +" "+ author.LastName,
                        Tag = author
                    };
                    authorNode.Nodes.Add(authorNodes);
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
            if (e.Node.Parent is null) return;
            switch (e.Node.Tag)
            {
                case Shop shops:
                {
                    dataGridView1.Columns.Add("Name", "Name");
                    dataGridView1.Columns.Add("ISBN", "ISBN");
                    dataGridView1.Columns.Add("Quantity", "Quantity");


                    foreach (var book in books)
                    foreach (var stock in stocks)
                        if (shops.ShopId == stock.ShopId)
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
                    _authorIsActive = author;
                    dataGridView1.Columns.Add("Title", "Title");
                    dataGridView1.Columns.Add("Category", "Category");
                    dataGridView1.Columns.Add("ISBN", "ISBN");

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
            var isbn = dataGridView1.SelectedCells[2].Value.ToString();
            var book = unitOfWork.Books.GetBookWithISBN(isbn);
            unitOfWork.Books.Remove(book);
            unitOfWork.Complete();
            
        }

        private void bt_Addbook_Click(object sender, EventArgs e)
        {
            var addBook = new AddbookForm(_authorIsActive);
            addBook.Show();
        }
    }
}