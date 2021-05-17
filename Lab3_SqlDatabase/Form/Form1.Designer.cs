
namespace Lab3_SqlDatabase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.bt_RemoveAuthor = new System.Windows.Forms.Button();
            this.bt_AddAuthor = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_Removebook = new System.Windows.Forms.Button();
            this.bt_Addbook = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bt_RemoveAuthor);
            this.splitContainer1.Panel2.Controls.Add(this.bt_AddAuthor);
            this.splitContainer1.Panel2.Controls.Add(this.bt_Exit);
            this.splitContainer1.Panel2.Controls.Add(this.bt_Removebook);
            this.splitContainer1.Panel2.Controls.Add(this.bt_Addbook);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(686, 390);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(229, 391);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // bt_RemoveAuthor
            // 
            this.bt_RemoveAuthor.Location = new System.Drawing.Point(179, 348);
            this.bt_RemoveAuthor.Name = "bt_RemoveAuthor";
            this.bt_RemoveAuthor.Size = new System.Drawing.Size(102, 30);
            this.bt_RemoveAuthor.TabIndex = 5;
            this.bt_RemoveAuthor.Text = "Remove Author";
            this.bt_RemoveAuthor.UseVisualStyleBackColor = true;
            this.bt_RemoveAuthor.Click += new System.EventHandler(this.bt_RemoveAuthor_Click);
            // 
            // bt_AddAuthor
            // 
            this.bt_AddAuthor.Location = new System.Drawing.Point(98, 348);
            this.bt_AddAuthor.Name = "bt_AddAuthor";
            this.bt_AddAuthor.Size = new System.Drawing.Size(75, 30);
            this.bt_AddAuthor.TabIndex = 4;
            this.bt_AddAuthor.Text = "Add Author";
            this.bt_AddAuthor.UseVisualStyleBackColor = true;
            this.bt_AddAuthor.Click += new System.EventHandler(this.bt_AddAuthor_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Location = new System.Drawing.Point(380, 348);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(64, 30);
            this.bt_Exit.TabIndex = 3;
            this.bt_Exit.Text = "Exit";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // bt_Removebook
            // 
            this.bt_Removebook.Location = new System.Drawing.Point(287, 348);
            this.bt_Removebook.Name = "bt_Removebook";
            this.bt_Removebook.Size = new System.Drawing.Size(87, 30);
            this.bt_Removebook.TabIndex = 2;
            this.bt_Removebook.Text = "Remove Book";
            this.bt_Removebook.UseVisualStyleBackColor = true;
            this.bt_Removebook.Click += new System.EventHandler(this.bt_Removebook_Click);
            // 
            // bt_Addbook
            // 
            this.bt_Addbook.Location = new System.Drawing.Point(17, 348);
            this.bt_Addbook.Name = "bt_Addbook";
            this.bt_Addbook.Size = new System.Drawing.Size(75, 30);
            this.bt_Addbook.TabIndex = 1;
            this.bt_Addbook.Text = "Add Book";
            this.bt_Addbook.UseVisualStyleBackColor = true;
            this.bt_Addbook.Click += new System.EventHandler(this.bt_Addbook_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(452, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bt_RemoveAuthor;

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button bt_Removebook;
        private System.Windows.Forms.Button bt_Addbook;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button bt_AddAuthor;
    }
}

