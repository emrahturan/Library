﻿using MyLibrary.Business.Concrete;
using MyLibrary.DataAccess.Concrete.EntityFramework;
using System;
using System.Windows.Forms;
using MyLibrary.Business.Abstract;
using MyLibrary.Entities.Concrete;
using System.Collections.Generic;

namespace MyLibrary
{
    public partial class MainForm : Form
    {
        private readonly IAuthorService _authorService;
        private readonly ICategoryService _categoryService;
        private readonly IPublisherService _publisherService;
        private readonly IBookService _bookService;

        public MainForm()
        {
            InitializeComponent();
            _authorService = new AuthorManager(new EfAuthorDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
            _publisherService = new PublisherManager(new EfPublisherDal());
            _bookService = new BookManager(new EfBookDal());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillAuthorComboBox();
            FillCategoryComboBox();
            FillPublisherComboBox();
            FillBookGridView();
        }

        

        private void FillAuthorComboBox()
        {
            var authorList = new List<Author>();
            var addChoose = new Author() { Id = -1, FullName = "Add New Author" };

            cmbAuthors.DisplayMember = "FullName";
            cmbAuthors.ValueMember = "Id";
            authorList.Add(addChoose);
            authorList.AddRange(_authorService.GetAll());
            cmbAuthors.DataSource = authorList;

            cmbBookAuthor.DisplayMember = "FullName";
            cmbBookAuthor.ValueMember = "Id";
            authorList.Remove(addChoose);
            cmbBookAuthor.DataSource = authorList;

            cmbBookAuthor.Enabled = cmbBookAuthor.Items.Count != 0;
        }
        private void FillCategoryComboBox()
        {
            var categoryList = new List<Category>();
            var addChoose = new Category() { Id = -1, Name = "Add New Category" };

            cmbCategories.DisplayMember = "Name";
            cmbCategories.ValueMember = "Id";
            categoryList.Add(addChoose);
            categoryList.AddRange(_categoryService.GetAll());
            cmbCategories.DataSource = categoryList;

            cmbBookCategory.DisplayMember = "Name";
            cmbBookCategory.ValueMember = "Id";
            categoryList.Remove(addChoose);
            cmbBookCategory.DataSource = categoryList;

            cmbBookCategory.Enabled = cmbBookCategory.Items.Count != 0;
        }
        private void FillPublisherComboBox()
        {
            var publisherList = new List<Publisher>();
            var addChoose = new Publisher() { Id = -1, Name = "Add New Publisher" };

            cmbPublishers.DisplayMember = "Name";
            cmbPublishers.ValueMember = "Id";
            publisherList.Add(addChoose);
            publisherList.AddRange(_publisherService.GetAll());
            cmbPublishers.DataSource = publisherList;

            cmbBookPublisher.DisplayMember = "Name";
            cmbBookPublisher.ValueMember = "Id";
            publisherList.Remove(addChoose);
            cmbBookPublisher.DataSource = publisherList;

            cmbBookPublisher.Enabled = cmbBookPublisher.Items.Count != 0;
        }
        private void FillBookGridView()
        {
            grdBook.DataSource = _bookService.GetAll();
        }

        private void cmbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = ((Author)cmbAuthors.SelectedItem).Id;

            txtFirstName.Text = id < 0 ? "" : cmbAuthors.Text;
            btnAuthorSave.Text = id < 0 ? "Add" : "Save";
            btnAuthorDelete.Enabled = id >= 0;
        }
        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = ((Category)cmbCategories.SelectedItem).Id;

            txtCategory.Text = id < 0 ? "" : cmbCategories.Text;
            btnCategorySave.Text = id < 0 ? "Add" : "Save";
            btnCategoryDelete.Enabled = id >= 0;
        }
        private void cmbPublishers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = ((Publisher)cmbPublishers.SelectedItem).Id;

            txtPublisher.Text = id < 0 ? "" : cmbPublishers.Text;
            btnPublisherSave.Text = id < 0 ? "Add" : "Save";
            btnPublisherDelete.Enabled = id >= 0;
        }

        private void btnAuthorSave_Click(object sender, EventArgs e)
        {
            var id = ((Author)cmbAuthors.SelectedItem).Id;

            if (id < 0)
            {
                _authorService.Add(new Author() { FullName = txtFirstName.Text });
                MessageBox.Show(@"Author added!");
            }
            else
            {
                _authorService.Update(new Author() { Id = id, FullName = txtFirstName.Text });
                MessageBox.Show(@"Author updated!");
            }

            FillAuthorComboBox();
        }
        private void btnCategorySave_Click(object sender, EventArgs e)
        {
            var id = ((Category)cmbCategories.SelectedItem).Id;

            if (id < 0)
            {
                _categoryService.Add(new Category() { Name = txtCategory.Text });
                MessageBox.Show(@"Category added!");
            }
            else
            {
                _categoryService.Update(new Category() { Id = id, Name = txtCategory.Text });
                MessageBox.Show(@"Category updated!");
            }

            FillCategoryComboBox();
        }
        private void btnPublisherSave_Click(object sender, EventArgs e)
        {
            try
            {
                var id = ((Publisher)cmbPublishers.SelectedItem).Id;

                if (id < 0)
                {
                    _publisherService.Add(new Publisher() { Name = txtPublisher.Text });
                    MessageBox.Show(@"Publisher added!");
                }
                else
                {
                    _publisherService.Update(new Publisher() { Id = id, Name = txtPublisher.Text });
                    MessageBox.Show(@"Publisher updated!");
                }

                FillPublisherComboBox();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnAuthorDelete_Click(object sender, EventArgs e)
        {
            _authorService.Delete(new Author() { Id = ((Author)cmbAuthors.SelectedItem).Id });

            MessageBox.Show(@"Author deleted!");
            FillAuthorComboBox();
        }
        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            _categoryService.Delete(new Category() { Id = ((Category)cmbCategories.SelectedItem).Id });

            MessageBox.Show(@"Category deleted!");
            FillCategoryComboBox();
        }
        private void btnPublisherDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _publisherService.Delete(new Publisher() { Id = ((Publisher)cmbPublishers.SelectedItem).Id });

                MessageBox.Show(@"Publisher deleted!");
                FillPublisherComboBox();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}