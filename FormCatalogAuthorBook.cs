using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFLibrary
{
    public partial class FormCatalogAuthorBook : Form
    {
        int book_id;
        string book_name;

        public FormCatalogAuthorBook()
        {
            InitializeComponent();
        }

        public FormCatalogAuthorBook(int id_book, string name_book)
        {
            InitializeComponent();
            Text = String.Concat(Text, " ", name_book);

            notCatalogsBooksTableAdapter1.Fill(dataSetLibrary1.NotCatalogsBooks, id_book);

            notAuthorsBookTableAdapter1.Fill(dataSetLibrary1.NotAuthorsBook, id_book);

            book_id = id_book;
            book_name = name_book;
        }

        private void FormCatalogAuthorBook_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int catalog_id = (int)(notCatalogsBooksBindingSource.Current as DataRowView)["c_id"];

                notCatalogsBooksTableAdapter1.Insert(book_id, catalog_id);

                MessageBox.Show("Додано");

            }
            catch
            {
                MessageBox.Show("Помилка додавання інформації до книги", "Помилка");
            }
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                int author_id = (int)(notAuthorsBookBindingSource.Current as DataRowView)["a_id"];

                notAuthorsBookTableAdapter1.Insert(book_id, author_id);

                MessageBox.Show("Додано");
            }
            catch
            {
                MessageBox.Show("Помилка додавання інформації до книги", "Помилка");
            }

        }
    }
}
