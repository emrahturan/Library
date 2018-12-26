namespace MyLibrary
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAuthorDelete = new System.Windows.Forms.Button();
            this.btnAuthorSave = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cmbAuthors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnCategorySave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPublisherDelete = new System.Windows.Forms.Button();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.btnPublisherSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPublishers = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBookSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookPublishedYear = new System.Windows.Forms.TextBox();
            this.cmbBookPublisher = new System.Windows.Forms.ComboBox();
            this.cmbBookCategory = new System.Windows.Forms.ComboBox();
            this.cmbBookAuthor = new System.Windows.Forms.ComboBox();
            this.txtBookISBN = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.grdBook = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBook)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAuthorDelete);
            this.groupBox1.Controls.Add(this.btnAuthorSave);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.cmbAuthors);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Author Operations";
            // 
            // btnAuthorDelete
            // 
            this.btnAuthorDelete.Location = new System.Drawing.Point(72, 91);
            this.btnAuthorDelete.Name = "btnAuthorDelete";
            this.btnAuthorDelete.Size = new System.Drawing.Size(85, 23);
            this.btnAuthorDelete.TabIndex = 1;
            this.btnAuthorDelete.Text = "Delete";
            this.btnAuthorDelete.UseVisualStyleBackColor = true;
            this.btnAuthorDelete.Click += new System.EventHandler(this.btnAuthorDelete_Click);
            // 
            // btnAuthorSave
            // 
            this.btnAuthorSave.Location = new System.Drawing.Point(159, 91);
            this.btnAuthorSave.Name = "btnAuthorSave";
            this.btnAuthorSave.Size = new System.Drawing.Size(85, 23);
            this.btnAuthorSave.TabIndex = 1;
            this.btnAuthorSave.Text = "Save";
            this.btnAuthorSave.UseVisualStyleBackColor = true;
            this.btnAuthorSave.Click += new System.EventHandler(this.btnAuthorSave_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(72, 57);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(172, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // cmbAuthors
            // 
            this.cmbAuthors.FormattingEnabled = true;
            this.cmbAuthors.Location = new System.Drawing.Point(6, 19);
            this.cmbAuthors.Name = "cmbAuthors";
            this.cmbAuthors.Size = new System.Drawing.Size(238, 21);
            this.cmbAuthors.TabIndex = 0;
            this.cmbAuthors.SelectedIndexChanged += new System.EventHandler(this.cmbAuthors_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCategoryDelete);
            this.groupBox2.Controls.Add(this.txtCategory);
            this.groupBox2.Controls.Add(this.btnCategorySave);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbCategories);
            this.groupBox2.Location = new System.Drawing.Point(268, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Category Operations";
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Location = new System.Drawing.Point(72, 91);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(85, 23);
            this.btnCategoryDelete.TabIndex = 3;
            this.btnCategoryDelete.Text = "Delete";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(72, 57);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(172, 20);
            this.txtCategory.TabIndex = 2;
            // 
            // btnCategorySave
            // 
            this.btnCategorySave.Location = new System.Drawing.Point(159, 91);
            this.btnCategorySave.Name = "btnCategorySave";
            this.btnCategorySave.Size = new System.Drawing.Size(85, 23);
            this.btnCategorySave.TabIndex = 4;
            this.btnCategorySave.Text = "Save";
            this.btnCategorySave.UseVisualStyleBackColor = true;
            this.btnCategorySave.Click += new System.EventHandler(this.btnCategorySave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category:";
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(6, 19);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(238, 21);
            this.cmbCategories.TabIndex = 2;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPublisherDelete);
            this.groupBox3.Controls.Add(this.txtPublisher);
            this.groupBox3.Controls.Add(this.btnPublisherSave);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cmbPublishers);
            this.groupBox3.Location = new System.Drawing.Point(524, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 132);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Publisher Operations";
            // 
            // btnPublisherDelete
            // 
            this.btnPublisherDelete.Location = new System.Drawing.Point(72, 91);
            this.btnPublisherDelete.Name = "btnPublisherDelete";
            this.btnPublisherDelete.Size = new System.Drawing.Size(85, 23);
            this.btnPublisherDelete.TabIndex = 3;
            this.btnPublisherDelete.Text = "Delete";
            this.btnPublisherDelete.UseVisualStyleBackColor = true;
            this.btnPublisherDelete.Click += new System.EventHandler(this.btnPublisherDelete_Click);
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(72, 57);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(172, 20);
            this.txtPublisher.TabIndex = 2;
            // 
            // btnPublisherSave
            // 
            this.btnPublisherSave.Location = new System.Drawing.Point(159, 91);
            this.btnPublisherSave.Name = "btnPublisherSave";
            this.btnPublisherSave.Size = new System.Drawing.Size(85, 23);
            this.btnPublisherSave.TabIndex = 4;
            this.btnPublisherSave.Text = "Save";
            this.btnPublisherSave.UseVisualStyleBackColor = true;
            this.btnPublisherSave.Click += new System.EventHandler(this.btnPublisherSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Publisher:";
            // 
            // cmbPublishers
            // 
            this.cmbPublishers.FormattingEnabled = true;
            this.cmbPublishers.Location = new System.Drawing.Point(6, 19);
            this.cmbPublishers.Name = "cmbPublishers";
            this.cmbPublishers.Size = new System.Drawing.Size(238, 21);
            this.cmbPublishers.TabIndex = 2;
            this.cmbPublishers.SelectedIndexChanged += new System.EventHandler(this.cmbPublishers_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBookDelete);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnBookSave);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtBookPublishedYear);
            this.groupBox4.Controls.Add(this.cmbBookPublisher);
            this.groupBox4.Controls.Add(this.cmbBookCategory);
            this.groupBox4.Controls.Add(this.cmbBookAuthor);
            this.groupBox4.Controls.Add(this.txtBookISBN);
            this.groupBox4.Controls.Add(this.txtBookName);
            this.groupBox4.Location = new System.Drawing.Point(12, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(762, 134);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Book Operations";
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.Location = new System.Drawing.Point(578, 98);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(88, 23);
            this.btnBookDelete.TabIndex = 2;
            this.btnBookDelete.Text = "Delete";
            this.btnBookDelete.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(518, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Publisher:";
            // 
            // btnBookSave
            // 
            this.btnBookSave.Location = new System.Drawing.Point(668, 98);
            this.btnBookSave.Name = "btnBookSave";
            this.btnBookSave.Size = new System.Drawing.Size(88, 23);
            this.btnBookSave.TabIndex = 3;
            this.btnBookSave.Text = "Save";
            this.btnBookSave.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Category:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Author:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // txtBookPublishedYear
            // 
            this.txtBookPublishedYear.Location = new System.Drawing.Point(578, 21);
            this.txtBookPublishedYear.Name = "txtBookPublishedYear";
            this.txtBookPublishedYear.Size = new System.Drawing.Size(178, 20);
            this.txtBookPublishedYear.TabIndex = 5;
            // 
            // cmbBookPublisher
            // 
            this.cmbBookPublisher.FormattingEnabled = true;
            this.cmbBookPublisher.Location = new System.Drawing.Point(578, 60);
            this.cmbBookPublisher.Name = "cmbBookPublisher";
            this.cmbBookPublisher.Size = new System.Drawing.Size(178, 21);
            this.cmbBookPublisher.TabIndex = 4;
            // 
            // cmbBookCategory
            // 
            this.cmbBookCategory.FormattingEnabled = true;
            this.cmbBookCategory.Location = new System.Drawing.Point(322, 60);
            this.cmbBookCategory.Name = "cmbBookCategory";
            this.cmbBookCategory.Size = new System.Drawing.Size(178, 21);
            this.cmbBookCategory.TabIndex = 3;
            // 
            // cmbBookAuthor
            // 
            this.cmbBookAuthor.FormattingEnabled = true;
            this.cmbBookAuthor.Location = new System.Drawing.Point(66, 60);
            this.cmbBookAuthor.Name = "cmbBookAuthor";
            this.cmbBookAuthor.Size = new System.Drawing.Size(178, 21);
            this.cmbBookAuthor.TabIndex = 2;
            // 
            // txtBookISBN
            // 
            this.txtBookISBN.Location = new System.Drawing.Point(322, 21);
            this.txtBookISBN.Name = "txtBookISBN";
            this.txtBookISBN.Size = new System.Drawing.Size(178, 20);
            this.txtBookISBN.TabIndex = 1;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(66, 21);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(178, 20);
            this.txtBookName.TabIndex = 0;
            // 
            // grdBook
            // 
            this.grdBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBook.Location = new System.Drawing.Point(10, 19);
            this.grdBook.Name = "grdBook";
            this.grdBook.Size = new System.Drawing.Size(746, 219);
            this.grdBook.TabIndex = 7;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.grdBook);
            this.groupBox5.Location = new System.Drawing.Point(12, 290);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(762, 244);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Book List";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 546);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBook)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAuthorSave;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cmbAuthors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAuthorDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.Button btnCategorySave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPublisherDelete;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Button btnPublisherSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPublishers;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookPublishedYear;
        private System.Windows.Forms.ComboBox cmbBookPublisher;
        private System.Windows.Forms.ComboBox cmbBookCategory;
        private System.Windows.Forms.ComboBox cmbBookAuthor;
        private System.Windows.Forms.TextBox txtBookISBN;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button btnBookDelete;
        private System.Windows.Forms.Button btnBookSave;
        private System.Windows.Forms.DataGridView grdBook;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

