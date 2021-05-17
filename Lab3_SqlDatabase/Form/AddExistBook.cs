using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab3_SqlDatabase
{ 
    public partial class AddExistBook : Form
    {
        private readonly Shop _shop;
        private readonly UnitOfWork.UnitOfWork _unitOfWork;
        public AddExistBook(Shop shop)
        {
            _shop = shop;
            _unitOfWork = new UnitOfWork.UnitOfWork(new BookStores_Lab2_NareeratContext());
            InitializeComponent();
        }
        private void AddExistBook_Load(object sender, EventArgs e)
        {
            var bookList = _unitOfWork.Books.GetAll().ToList();
            var titles = new List<Book>();
            foreach (var i in bookList)
            {
                var stock = _unitOfWork.Stocks.GetStockByIsbnAndShopId(i.IsbnId, _shop.ShopId);
                if (stock is not null) titles.Add(stock.Isbn);
            }

            bookList.RemoveAll(b => titles.Contains(b));

            LstBox_Booklist.DataSource = bookList.Select(x => x.Title).ToList();
            label_ShopName.Text = _shop.ShopName;
        }
        private void bt_Add_Click(object sender, EventArgs e)
        {
            var bookList = new List<Book>();

            if (LstBox_Booklist.SelectedItem == null)
            {
                MessageBox.Show("you need to pick a book");
                return;
            }

            var bookTitle = LstBox_Booklist.GetItemText(LstBox_Booklist.SelectedItem);

            var book = _unitOfWork.Books.GetBookWithTitle(bookTitle);

            int.TryParse(tex_Quantity.Text, out var quantity);
            if (quantity < 1) quantity = 1;

            var stock = new Stock
            {
                ShopId = _shop.ShopId,
                IsbnId = book.IsbnId,
                Quantity = quantity
            };
            bookList.Add(book);
            _unitOfWork.Stocks.Add(stock);
            _unitOfWork.Complete();
            _unitOfWork.Dispose();
            Hide();
            MessageBox.Show("Added book Successfully");
        }
    }
}