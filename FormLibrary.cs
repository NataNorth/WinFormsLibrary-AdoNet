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
    public partial class FormLibrary : Form
    {
        private bool сhanged = false;

        public FormLibrary()
        {
            InitializeComponent();
            booksTableAdapter1.Fill(dataSetLibrary1.Books);
            readersTableAdapter1.Fill(dataSetLibrary1.Readers);
            catalogsTableAdapter1.Fill(dataSetLibrary1.Catalogs);
            authorsTableAdapter1.Fill(dataSetLibrary1.Authors);
           // dataGridViewReaders.Co


        }

        private void FormLibrary_Load(object sender, EventArgs e)
        {
            booksTableAdapter1.Fill(dataSetLibrary1.Books);
            readersTableAdapter1.Fill(dataSetLibrary1.Readers);
            catalogsTableAdapter1.Fill(dataSetLibrary1.Catalogs);
            authorsTableAdapter1.Fill(dataSetLibrary1.Authors);

            dataGridViewBooks.Columns[0].Visible = false;
            dataGridViewCatalogs.Columns[0].Visible = false;
            dataGridViewReaders.Columns[0].Visible = false;
            dataGridViewAuthors.Columns["aidDataGridViewTextBoxColumn"].Visible = false;
        }

        private void buttonBookSafe_Click(object sender, EventArgs e)
        {
            booksTableAdapter1.Update(dataSetLibrary1.Books);
            сhanged = false;
        }

        private void buttonSafeReaders_Click(object sender, EventArgs e)
        {
            readersTableAdapter1.Update(dataSetLibrary1.Readers);
            сhanged = false;
        }

        private void buttonSafeCatalogs_Click(object sender, EventArgs e)
        {
            catalogsTableAdapter1.Update(dataSetLibrary1.Catalogs);
            сhanged = false;
        }

        private void buttonSafeAuthors_Click(object sender, EventArgs e)
        {
            authorsTableAdapter1.Update(dataSetLibrary1.Authors);
            сhanged = false;
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
           
            int id = (int)dataGridViewBooks.CurrentRow.Cells[0].Value;
            book_authorsTableAdapter1.DeleteByBook(id);
            book_catalogsTableAdapter1.DeleteByBook(id);
            booksBindingSource.RemoveCurrent();
            сhanged = true;
        }

        private void buttonDeleteReaders_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewReaders.CurrentRow.Cells[0].Value;
                Nullable<int> return_count = queriesTableAdapter1.SQCountOfReadersInList(id);
                if (return_count == 0)
                {
                    readersBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Видалення заборонено, читач активно користується бібліотекою", "Помилка видалення!");
                }

            }
            catch
            {
                MessageBox.Show("Помилка видалення інформації про читачів", "Помилка видалення!");
            }
            сhanged = true;

        }

        private void buttonDeleteCatalogs_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewCatalogs.CurrentRow.Cells[0].Value;
                global::System.Nullable<int> catalog_count = queriesTableAdapter1.SQCountOfBooksInCategory(id);

                if (catalog_count == 0)
                {
                    catalogsBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Видалення заборонено, у каталозі є книги", "Помилка видалення!");
                }

            }
            catch
            {
                MessageBox.Show("Помилка видалення інформації про каталоги", "Помилка видалення!");
            }
            сhanged = true;
        }

        private void buttonDeleteAuthors_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewAuthors.CurrentRow.Cells[0].Value;
                global::System.Nullable<int> author_count = queriesTableAdapter1.SQCountOfBooksWithAuthors(id);
                if (author_count == 0)
                {
                    authorsBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Видалення заборонено, у автора є книги", "Помилка видалення!");
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення інформації про автора", "Помилка видалення!");
            }
            сhanged = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCatalogs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (сhanged)
            {
                MessageBox.Show("Необхідно зберегти зміни", "Перегляд книг за категорією");
            }
            else
            {
                try
                {
                    int id = (int)dataGridViewCatalogs.CurrentRow.Cells["cidDataGridViewTextBoxColumn"].Value;
                    string name = (string)dataGridViewCatalogs.CurrentRow.Cells["cnameDataGridViewTextBoxColumn"].Value;

                    FormCatalogs catalogsDialog = new FormCatalogs(id, name);

                    catalogsDialog.ShowDialog(this);

                    catalogsDialog.Dispose();
                }
                catch
                {
                    MessageBox.Show("Помилка переходу до іншого вікна", "Перехід до списку книг");
                }
            }
        }

        private void buttonSearchBook_Click(object sender, EventArgs e)
        {

        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            //if (сhanged)
            //{
            //    MessageBox.Show("Необхідно зберегти зміни", "Перегляд книг за категорією");
            //}
            //else
            //{
            //    try
            //    {
            
            //        FormReadersInfo addBookDialog = new FormReadersInfo();

            //        addBookDialog.ShowDialog(this);

            //        addBookDialog.Dispose();
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Помилка переходу до іншого вікна", "Перехід до додавання");
            //    }
            //}
        }

        private void buttonCheckAvailability_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewBooks.CurrentRow.Cells["bidDataGridViewTextBoxColumn"].Value;
                Nullable<int> copies_count = queriesTableAdapter1.SQCountOfAvailableCopiesOfBooks(id);

                string message = "Дана книга є у наявності у такій кількості екземплярів: " + copies_count.ToString();
                MessageBox.Show(message, "Наявність книги");
            }
            catch
            {
                MessageBox.Show("Помилка");
            }
        }

        private void dataGridViewCatalogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCheckDebts_Click(object sender, EventArgs e)
        {
            if (сhanged)
            {
                MessageBox.Show("Необхідно зберегти зміни", "Перегляд книг за категорією");
            }
            else
            {
                try
                {
                    int id = (int)dataGridViewReaders.CurrentRow.Cells["rdidDataGridViewTextBoxColumn"].Value;

                    Nullable<int> readers_count = queriesTableAdapter1.SQCountActivityOfReaders(id);

                    if(readers_count == 0)
                    {
                        MessageBox.Show("Читач неактивний", "Інформація");
                    }
                    else
                    {
                        FormReadersInfo formReadersInfo = new FormReadersInfo(id);

                        formReadersInfo.ShowDialog(this);

                        formReadersInfo.Dispose();
                    }
                   
                }

                catch
                {
                    MessageBox.Show("Помилка");
                }
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            if (сhanged)
            {
                MessageBox.Show("Необхідно зберегти зміни", "Перегляд книг за категорією");
            }
            else
            {
                //try
                {
                    int id = (int)dataGridViewBooks.CurrentRow.Cells["bidDataGridViewTextBoxColumn"].Value;
                    string name = (string)dataGridViewBooks.CurrentRow.Cells["bnameDataGridViewTextBoxColumn"].Value;

                    FormCatalogAuthorBook dialogCA = new FormCatalogAuthorBook(id, name);

                    dialogCA.ShowDialog(this);

                    dialogCA.Dispose();
                }
                //catch
                //{
                //    MessageBox.Show("Помилка переходу");
                //}
            }
        }

        private void dataGridViewReaders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewReaders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (сhanged)
            {
                MessageBox.Show("Необхідно зберегти зміни", "Перегляд інформації про читача");
            }
            else
            {
                try
                {
                    int id = (int)dataGridViewReaders.CurrentRow.Cells["ridDataGridViewTextBoxColumn"].Value;
                    

                    FormReadersInfo dialog = new FormReadersInfo(id);

                    dialog.ShowDialog(this);

                    dialog.Dispose();
                }
                catch
                {
                    MessageBox.Show("Помилка переходу до іншого вікна", "Перехід до списку читачів");
                }
            }
        }
    }
}
