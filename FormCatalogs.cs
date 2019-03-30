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
    public partial class FormCatalogs : Form
    {
        bool changed;
        int catalog_id;
        string catalog_name;

        public FormCatalogs()
        {
            InitializeComponent();
            changed = false;
        }

        public FormCatalogs(int id_catalog, string name_catalog)
        {
            InitializeComponent();
            Text = String.Concat(Text, " ", name_catalog);

            catalog_id = id_catalog;
            catalog_name = name_catalog;
            //find_Books();
            dtCatalogsOfBooksTableAdapter1.Fill(dataSetLibrary1.DTCatalogsOfBooks, catalog_id);
            changed = false;
        }

        private void find_Books()
        {
            int findLowerYear = (int)numericUpDownLowerYear.Value;
            int findUpperYear = (int)numericUpDownUpperYear.Value;
           

            if (textBoxAuthor.Text != "" && textBoxName.Text != "")
            {
                string findAuthor = "%" + textBoxAuthor.Text + "%";
                string findName = "%" + textBoxName.Text + "%";

                dtCatalogsOfBooksTableAdapter1.FillByNameAndAuthorAndYear(dataSetLibrary1.DTCatalogsOfBooks, catalog_id, findLowerYear, findUpperYear, findName, findAuthor);
            }
            else
            {
                if (textBoxAuthor.Text != "")
                {
                    string findAuthor = "%" + textBoxAuthor.Text + "%";
                    dtCatalogsOfBooksTableAdapter1.FillByAuthorAndYear(dataSetLibrary1.DTCatalogsOfBooks, catalog_id, findAuthor, findLowerYear, findUpperYear);
                }
                else
                {
                    if (textBoxName.Text != "")
                    {
                        string findName = "%" + textBoxName.Text + "%";
                        dtCatalogsOfBooksTableAdapter1.FillByNameAndYear(dataSetLibrary1.DTCatalogsOfBooks, catalog_id, findName, findLowerYear, findUpperYear);
                    }
                    else
                    {
                        dtCatalogsOfBooksTableAdapter1.FillByYear(dataSetLibrary1.DTCatalogsOfBooks, catalog_id, findLowerYear, findUpperYear);
                    }
                }

            }

        }
        private void FormCatalogs_Load(object sender, EventArgs e)
        {

        }

        private void dGVCatalogs_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                id = (int)dGVCatalogs.CurrentRow.Cells["cidDataGridViewTextBoxColumn"].Value;
                dtCatalogsOfBooksTableAdapter1.Fill(dataSetLibrary1.DTCatalogsOfBooks, id);
            }
            catch
            {
                MessageBox.Show("Помилка", "Помилка");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            find_Books();

        }

        private void dGVCatalogs_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                e.Row.Cells["bidDataGridViewTextBoxColumn"].Value = catalog_id;
                e.Row.Cells["bnameDataGridViewTextBoxColumn"].Value = catalog_name;
            }
            catch
            {
                MessageBox.Show("Помилка", "Помилка");
            }
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            find_Books();

        }

        private void dGVCatalogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
