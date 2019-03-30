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
    public partial class FormReadersInfo : Form
    {
        bool changed;
        int reader_id;
        public FormReadersInfo()
        {
            InitializeComponent();
            changed = false;
        }
        public FormReadersInfo(int id_reader)
        {
            InitializeComponent();
            reader_id = id_reader;
           
            dtReaderAllInfoTableAdapter1.FillByReader(dataSetLibrary1.DTReaderAllInfo, reader_id);
            changed = false;
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {

        }
    
    }
}
