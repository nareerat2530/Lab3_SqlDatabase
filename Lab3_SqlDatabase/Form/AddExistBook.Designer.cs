using System.ComponentModel;

namespace Lab3_SqlDatabase
{
    partial class AddExistBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.LstBox_Booklist = new System.Windows.Forms.ListBox();
            this.bt_Add = new System.Windows.Forms.Button();
            this.label_ShopName = new System.Windows.Forms.Label();
            this.tex_Quantity = new System.Windows.Forms.TextBox();
            this.label_Quantity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstBox_Booklist
            // 
            this.LstBox_Booklist.FormattingEnabled = true;
            this.LstBox_Booklist.Location = new System.Drawing.Point(12, 51);
            this.LstBox_Booklist.Name = "LstBox_Booklist";
            this.LstBox_Booklist.Size = new System.Drawing.Size(198, 134);
            this.LstBox_Booklist.TabIndex = 1;
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(76, 251);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(75, 23);
            this.bt_Add.TabIndex = 2;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // label_ShopName
            // 
            this.label_ShopName.Location = new System.Drawing.Point(12, 25);
            this.label_ShopName.Name = "label_ShopName";
            this.label_ShopName.Size = new System.Drawing.Size(198, 23);
            this.label_ShopName.TabIndex = 3;
            this.label_ShopName.Text = "label1";
            // 
            // tex_Quantity
            // 
            this.tex_Quantity.Location = new System.Drawing.Point(110, 206);
            this.tex_Quantity.Name = "tex_Quantity";
            this.tex_Quantity.Size = new System.Drawing.Size(100, 20);
            this.tex_Quantity.TabIndex = 4;
            // 
            // label_Quantity
            // 
            this.label_Quantity.Location = new System.Drawing.Point(4, 206);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(85, 23);
            this.label_Quantity.TabIndex = 5;
            this.label_Quantity.Text = "Quantity";
            // 
            // AddExistBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 305);
            this.Controls.Add(this.label_Quantity);
            this.Controls.Add(this.tex_Quantity);
            this.Controls.Add(this.label_ShopName);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.LstBox_Booklist);
            this.Name = "AddExistBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddExistBook";
            this.Load += new System.EventHandler(this.AddExistBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label_Quantity;
        private System.Windows.Forms.Label label_ShopName;
        private System.Windows.Forms.TextBox tex_Quantity;

        private System.Windows.Forms.ListBox LstBox_Booklist;
        private System.Windows.Forms.Button bt_Add;

        #endregion
    }
}