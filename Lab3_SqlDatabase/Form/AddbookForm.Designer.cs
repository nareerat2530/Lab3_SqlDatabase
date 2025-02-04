﻿
namespace Lab3_SqlDatabase
{
    partial class AddbookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_Bookdetails = new System.Windows.Forms.GroupBox();
            this.Language = new System.Windows.Forms.Label();
            this.LanguageTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_Isbn = new System.Windows.Forms.Label();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.Label();
            this.Label_Author = new System.Windows.Forms.Label();
            this.bt_Summit = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.gb_Bookdetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Bookdetails
            // 
            this.gb_Bookdetails.Controls.Add(this.Language);
            this.gb_Bookdetails.Controls.Add(this.LanguageTextBox);
            this.gb_Bookdetails.Controls.Add(this.PriceTextBox);
            this.gb_Bookdetails.Controls.Add(this.label_Price);
            this.gb_Bookdetails.Controls.Add(this.label_Isbn);
            this.gb_Bookdetails.Controls.Add(this.ISBNTextBox);
            this.gb_Bookdetails.Controls.Add(this.CategoryTextBox);
            this.gb_Bookdetails.Controls.Add(this.Title);
            this.gb_Bookdetails.Controls.Add(this.label_Title);
            this.gb_Bookdetails.Controls.Add(this.TitleTextBox);
            this.gb_Bookdetails.Controls.Add(this.Category);
            this.gb_Bookdetails.Location = new System.Drawing.Point(10, 61);
            this.gb_Bookdetails.Name = "gb_Bookdetails";
            this.gb_Bookdetails.Size = new System.Drawing.Size(268, 243);
            this.gb_Bookdetails.TabIndex = 2;
            this.gb_Bookdetails.TabStop = false;
            this.gb_Bookdetails.Text = "Book Details";
            // 
            // Language
            // 
            this.Language.AutoSize = true;
            this.Language.Location = new System.Drawing.Point(0, 205);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(55, 13);
            this.Language.TabIndex = 13;
            this.Language.Text = "Language";
            // 
            // LanguageTextBox
            // 
            this.LanguageTextBox.Location = new System.Drawing.Point(89, 202);
            this.LanguageTextBox.Name = "LanguageTextBox";
            this.LanguageTextBox.Size = new System.Drawing.Size(145, 20);
            this.LanguageTextBox.TabIndex = 12;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(89, 164);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(145, 20);
            this.PriceTextBox.TabIndex = 11;
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(4, 167);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(31, 13);
            this.label_Price.TabIndex = 10;
            this.label_Price.Text = "Price";
            // 
            // label_Isbn
            // 
            this.label_Isbn.AutoSize = true;
            this.label_Isbn.Location = new System.Drawing.Point(6, 127);
            this.label_Isbn.Name = "label_Isbn";
            this.label_Isbn.Size = new System.Drawing.Size(32, 13);
            this.label_Isbn.TabIndex = 9;
            this.label_Isbn.Text = "ISBN";
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(89, 124);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(145, 20);
            this.ISBNTextBox.TabIndex = 8;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(89, 84);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(145, 20);
            this.CategoryTextBox.TabIndex = 7;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(4, 35);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 6;
            this.Title.Text = "Title";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(1422, -55);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(27, 13);
            this.label_Title.TabIndex = 5;
            this.label_Title.Text = "Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(89, 32);
            this.TitleTextBox.Multiline = true;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(145, 32);
            this.TitleTextBox.TabIndex = 4;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(4, 87);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(49, 13);
            this.Category.TabIndex = 3;
            this.Category.Text = "Category";
            // 
            // Label_Author
            // 
            this.Label_Author.Location = new System.Drawing.Point(12, 21);
            this.Label_Author.Name = "Label_Author";
            this.Label_Author.Size = new System.Drawing.Size(100, 23);
            this.Label_Author.TabIndex = 14;
            this.Label_Author.Text = "label1";
            // 
            // bt_Summit
            // 
            this.bt_Summit.Location = new System.Drawing.Point(16, 319);
            this.bt_Summit.Name = "bt_Summit";
            this.bt_Summit.Size = new System.Drawing.Size(92, 20);
            this.bt_Summit.TabIndex = 3;
            this.bt_Summit.Text = "Summit";
            this.bt_Summit.UseVisualStyleBackColor = true;
            this.bt_Summit.Click += new System.EventHandler(this.bt_Summit_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(186, 319);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(92, 20);
            this.bt_Cancel.TabIndex = 4;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // AddbookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 351);
            this.Controls.Add(this.Label_Author);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Summit);
            this.Controls.Add(this.gb_Bookdetails);
            this.Name = "AddbookForm";
            this.Text = "AddbookForm";
            this.Load += new System.EventHandler(this.AddbookForm_Load);
            this.gb_Bookdetails.ResumeLayout(false);
            this.gb_Bookdetails.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label Label_Author;

        private System.Windows.Forms.Label Language;
        private System.Windows.Forms.TextBox LanguageTextBox;

        #endregion

        private System.Windows.Forms.GroupBox gb_Bookdetails;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label label_Isbn;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Button bt_Summit;
        private System.Windows.Forms.Button bt_Cancel;
    }
}