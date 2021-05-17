
namespace Lab3_SqlDatabase
{
    partial class AddAuthorForm
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
            this.groupB_AuthorDetails = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_Lastname = new System.Windows.Forms.Label();
            this.label_Birthday = new System.Windows.Forms.Label();
            this.texBox_Lastname = new System.Windows.Forms.TextBox();
            this.FirstnameTextBox = new System.Windows.Forms.TextBox();
            this.Lb_Firstname = new System.Windows.Forms.Label();
            this.bt_Summit = new System.Windows.Forms.Button();
            this.button1_Cancel = new System.Windows.Forms.Button();
            this.groupB_AuthorDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupB_AuthorDetails
            // 
            this.groupB_AuthorDetails.Controls.Add(this.dateTimePicker1);
            this.groupB_AuthorDetails.Controls.Add(this.label_Lastname);
            this.groupB_AuthorDetails.Controls.Add(this.label_Birthday);
            this.groupB_AuthorDetails.Controls.Add(this.texBox_Lastname);
            this.groupB_AuthorDetails.Controls.Add(this.FirstnameTextBox);
            this.groupB_AuthorDetails.Controls.Add(this.Lb_Firstname);
            this.groupB_AuthorDetails.Location = new System.Drawing.Point(12, 12);
            this.groupB_AuthorDetails.Name = "groupB_AuthorDetails";
            this.groupB_AuthorDetails.Size = new System.Drawing.Size(279, 188);
            this.groupB_AuthorDetails.TabIndex = 0;
            this.groupB_AuthorDetails.TabStop = false;
            this.groupB_AuthorDetails.Text = "Author Details";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 133);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 23);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2021, 5, 16, 0, 0, 0, 0);
            // 
            // label_Lastname
            // 
            this.label_Lastname.AutoSize = true;
            this.label_Lastname.Location = new System.Drawing.Point(7, 83);
            this.label_Lastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Lastname.Name = "label_Lastname";
            this.label_Lastname.Size = new System.Drawing.Size(58, 15);
            this.label_Lastname.TabIndex = 12;
            this.label_Lastname.Text = "Lastname";
            // 
            // label_Birthday
            // 
            this.label_Birthday.AutoSize = true;
            this.label_Birthday.Location = new System.Drawing.Point(7, 139);
            this.label_Birthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Birthday.Name = "label_Birthday";
            this.label_Birthday.Size = new System.Drawing.Size(51, 15);
            this.label_Birthday.TabIndex = 11;
            this.label_Birthday.Text = "Birthday";
            // 
            // texBox_Lastname
            // 
            this.texBox_Lastname.Location = new System.Drawing.Point(84, 75);
            this.texBox_Lastname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.texBox_Lastname.Name = "texBox_Lastname";
            this.texBox_Lastname.Size = new System.Drawing.Size(176, 23);
            this.texBox_Lastname.TabIndex = 9;
            // 
            // FirstnameTextBox
            // 
            this.FirstnameTextBox.Location = new System.Drawing.Point(84, 30);
            this.FirstnameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FirstnameTextBox.Name = "FirstnameTextBox";
            this.FirstnameTextBox.Size = new System.Drawing.Size(176, 23);
            this.FirstnameTextBox.TabIndex = 8;
            // 
            // Lb_Firstname
            // 
            this.Lb_Firstname.AutoSize = true;
            this.Lb_Firstname.Location = new System.Drawing.Point(7, 33);
            this.Lb_Firstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Firstname.Name = "Lb_Firstname";
            this.Lb_Firstname.Size = new System.Drawing.Size(59, 15);
            this.Lb_Firstname.TabIndex = 7;
            this.Lb_Firstname.Text = "Firstname";
            // 
            // bt_Summit
            // 
            this.bt_Summit.Location = new System.Drawing.Point(38, 209);
            this.bt_Summit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_Summit.Name = "bt_Summit";
            this.bt_Summit.Size = new System.Drawing.Size(107, 23);
            this.bt_Summit.TabIndex = 4;
            this.bt_Summit.Text = "Summit";
            this.bt_Summit.UseVisualStyleBackColor = true;
            this.bt_Summit.Click += new System.EventHandler(this.bt_Summit_Click);
            // 
            // button1_Cancel
            // 
            this.button1_Cancel.Location = new System.Drawing.Point(184, 209);
            this.button1_Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1_Cancel.Name = "button1_Cancel";
            this.button1_Cancel.Size = new System.Drawing.Size(107, 23);
            this.button1_Cancel.TabIndex = 5;
            this.button1_Cancel.Text = "Cancel";
            this.button1_Cancel.UseVisualStyleBackColor = true;
            // 
            // AddAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 244);
            this.Controls.Add(this.button1_Cancel);
            this.Controls.Add(this.bt_Summit);
            this.Controls.Add(this.groupB_AuthorDetails);
            this.Name = "AddAuthorForm";
            this.Text = "AddAuthorForm";
            this.groupB_AuthorDetails.ResumeLayout(false);
            this.groupB_AuthorDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupB_AuthorDetails;
        private System.Windows.Forms.Label Lb_Firstname;
        private System.Windows.Forms.Label label_Lastname;
        private System.Windows.Forms.Label label_Birthday;
        private System.Windows.Forms.TextBox texBox_Lastname;
        private System.Windows.Forms.TextBox FirstnameTextBox;
        private System.Windows.Forms.Button bt_Summit;
        private System.Windows.Forms.Button button1_Cancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}