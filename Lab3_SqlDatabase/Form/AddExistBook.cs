using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab3_SqlDatabase
{
    public partial class AddExistBook : Form
    {
        private Shop _shop;
        private UnitOfWork.UnitOfWork _unitOfWork;
        public AddExistBook(Shop shop)
        {
            _shop = shop;
            _unitOfWork = new UnitOfWork.UnitOfWork(new BookStores_Lab2_NareeratContext());
            InitializeComponent();
        }


        private void AddExistBook_Load(object sender, EventArgs e)
        {
            
            var bookList = _unitOfWork.Books.GetAll().ToList();
            foreach (var i in bookList)
            {
                LstBox_Booklist.Items.Add(i.Title);
            }
            label_ShopName.Text = _shop.ShopName;
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();   
            if (LstBox_Booklist.SelectedItem == null)
            {
                MessageBox.Show("you need to pick a book");
                return;
            }
           var bookTitle = LstBox_Booklist.GetItemText(LstBox_Booklist.SelectedItem);
            
            var book = _unitOfWork.Books.GetBookWithTitle(bookTitle);
            
            int.TryParse(tex_Quantity.Text, out int quantity);

            if (quantity < 1)
            {
                quantity = 1;
            }

            var stock = _unitOfWork.Stocks.GetStockByIsbnAndShopId(book.IsbnId, _shop.ShopId);
            if (stock == null)
            {
                 stock = new Stock
                {
                    ShopId = _shop.ShopId,
                    IsbnId = book.IsbnId,
                    Quantity = quantity
                };
                _unitOfWork.Stocks.Add(stock);
                _unitOfWork.Complete();
                form1.DataGridWriter(e);
               Hide();
                return;
            }

            stock.Quantity += quantity;
            form1.DataGridWriter(e);
            _unitOfWork.Complete();
            
            Hide();


        }
    }
}