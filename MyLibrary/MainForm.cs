using System;
using System.Windows.Forms;
using MyLibrary.Business.Abstract;
using MyLibrary.Entities.Concrete;
using System.Collections.Generic;
using MyLibrary.Business.DependencyResolvers.Ninject;

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

            _authorService = InstanceFactory.GetInstance<IAuthorService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _publisherService = InstanceFactory.GetInstance<IPublisherService>();
            _bookService = InstanceFactory.GetInstance<IBookService>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillAuthorComboBox();
            FillCategoryComboBox();
            FillPublisherComboBox();
            FillBookComboBox();
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
        private void FillBookComboBox()
        {
            var bookList = new List<Book>();
            var addChoose = new Book() { Id = -1, Name = "Add New Book" };

            cmbBooks.DisplayMember = "Name";
            cmbBooks.ValueMember = "Id";
            bookList.Add(addChoose);
            bookList.AddRange(_bookService.GetAll());
            cmbBooks.DataSource = bookList;
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
        private void cmbBooks_SelectedIndexChanged(object sender, EventArgs e) //Kontrol
        {
            var id = ((Book)cmbBooks.SelectedItem).Id;

            if (id >= 0)
            {
                var book = _bookService.GetBookById(id);

                txtBookName.Text = book[0].Name;
                txtBookISBN.Text = book[0].Isbn;
                txtBookPublishedYear.Text = Convert.ToString(book[0].PublishedYear);
                cmbBookAuthor.SelectedValue = book[0].AuthorId;
                cmbBookCategory.SelectedValue = book[0].CategoryId;
                cmbBookPublisher.SelectedValue = book[0].PublisherId;
                btnBookSave.Text = "Save";
                btnBookDelete.Enabled = true;
            }
            else
            {
                txtBookName.Text = "";
                txtBookISBN.Text = "";
                txtBookPublishedYear.Text = "";
                cmbBookAuthor.SelectedIndex = 0;
                cmbBookCategory.SelectedIndex = 0;
                cmbBookPublisher.SelectedIndex = 0;
                btnBookSave.Text = "Add";
                btnBookDelete.Enabled = false;
            }

        }

        private void btnAuthorSave_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void btnCategorySave_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
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
        private void btnBookSave_Click(object sender, EventArgs e)
        {
            try
            {
                var id = ((Book)cmbBooks.SelectedItem).Id;

                if (id < 0)
                {
                    _bookService.Add(new Book()
                    {
                        Name = txtBookName.Text,
                        Isbn = txtBookISBN.Text,
                        PublishedYear = Convert.ToInt16(txtBookPublishedYear.Text),
                        AuthorId = ((Author)cmbBookAuthor.SelectedItem).Id,
                        CategoryId = ((Category)cmbBookCategory.SelectedItem).Id,
                        PublisherId = ((Publisher)cmbBookPublisher.SelectedItem).Id
                    });
                    MessageBox.Show(@"Book added!");
                }
                else
                {
                    _bookService.Update(new Book()
                    {
                        Id = ((Book)cmbBooks.SelectedItem).Id,
                        Name = txtBookName.Text,
                        Isbn = txtBookISBN.Text,
                        PublishedYear = Convert.ToInt16(txtBookPublishedYear.Text),
                        AuthorId = ((Author)cmbBookAuthor.SelectedItem).Id,
                        CategoryId = ((Category)cmbBookCategory.SelectedItem).Id,
                        PublisherId = ((Publisher)cmbBookPublisher.SelectedItem).Id
                    });
                    MessageBox.Show(@"Book updated!");
                }

                FillBookComboBox();
                FillBookGridView();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnAuthorDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _authorService.Delete(new Author() { Id = ((Author)cmbAuthors.SelectedItem).Id });

                MessageBox.Show(@"Author deleted!");
                FillAuthorComboBox();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _categoryService.Delete(new Category() { Id = ((Category)cmbCategories.SelectedItem).Id });

                MessageBox.Show(@"Category deleted!");
                FillCategoryComboBox();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
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
        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _bookService.Delete(new Book() { Id = ((Book)cmbBooks.SelectedItem).Id });

                MessageBox.Show(@"Book deleted!");
                FillBookComboBox();
                FillBookGridView();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
