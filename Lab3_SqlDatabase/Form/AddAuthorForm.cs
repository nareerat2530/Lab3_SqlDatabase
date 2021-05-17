using System;
using System.Windows.Forms;

namespace Lab3_SqlDatabase
{
    public partial class AddAuthorForm : Form
    {
        private readonly UnitOfWork.UnitOfWork _unitOfwork;
        public AddAuthorForm()
        {
            _unitOfwork = new UnitOfWork.UnitOfWork(new BookStores_Lab2_NareeratContext());
            InitializeComponent();
        }
        private void bt_Summit_Click(object sender, EventArgs e)
        {
            var author = _unitOfwork.Authors.GetAuthorByNameAndLastName(FirstnameTextBox.Text, texBox_Lastname.Text);
            if (author == null)
            {
                author = new Author
                {
                    FirstName = FirstnameTextBox.Text,
                    LastName = texBox_Lastname.Text,
                    Birthday = dateTimePicker1.Value
                };
            }
            else
            {
                MessageBox.Show("This Author  already exist");
                return;
            }

            _unitOfwork.Authors.Add(author);
            _unitOfwork.Complete();
            Hide();
        }
    }
}