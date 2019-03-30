namespace WFLibrary
{
    partial class FormReadersInfo
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bcyearofpublicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbcdateoftakeningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbcexpectedreturndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbcfactreturnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbcinfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTReaderAllInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLibrary1 = new LibraryData.DataSetLibrary();
            this.dtReaderAllInfoTableAdapter1 = new LibraryData.DataSetLibraryTableAdapters.DTReaderAllInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTReaderAllInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLibrary1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rdnameDataGridViewTextBoxColumn,
            this.bnameDataGridViewTextBoxColumn,
            this.bcyearofpublicationDataGridViewTextBoxColumn,
            this.rbcdateoftakeningDataGridViewTextBoxColumn,
            this.rbcexpectedreturndateDataGridViewTextBoxColumn,
            this.rbcfactreturnDataGridViewTextBoxColumn,
            this.rbcinfoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dTReaderAllInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(672, 252);
            this.dataGridView1.TabIndex = 0;
            // 
            // rdnameDataGridViewTextBoxColumn
            // 
            this.rdnameDataGridViewTextBoxColumn.DataPropertyName = "rd_name";
            this.rdnameDataGridViewTextBoxColumn.HeaderText = "Ім\'я читача";
            this.rdnameDataGridViewTextBoxColumn.Name = "rdnameDataGridViewTextBoxColumn";
            // 
            // bnameDataGridViewTextBoxColumn
            // 
            this.bnameDataGridViewTextBoxColumn.DataPropertyName = "b_name";
            this.bnameDataGridViewTextBoxColumn.HeaderText = "Назва книги";
            this.bnameDataGridViewTextBoxColumn.Name = "bnameDataGridViewTextBoxColumn";
            // 
            // bcyearofpublicationDataGridViewTextBoxColumn
            // 
            this.bcyearofpublicationDataGridViewTextBoxColumn.DataPropertyName = "bc_year_of_publication";
            this.bcyearofpublicationDataGridViewTextBoxColumn.HeaderText = "Рік публікації";
            this.bcyearofpublicationDataGridViewTextBoxColumn.Name = "bcyearofpublicationDataGridViewTextBoxColumn";
            // 
            // rbcdateoftakeningDataGridViewTextBoxColumn
            // 
            this.rbcdateoftakeningDataGridViewTextBoxColumn.DataPropertyName = "rbc_date_of_takening";
            this.rbcdateoftakeningDataGridViewTextBoxColumn.HeaderText = "Дата отримання";
            this.rbcdateoftakeningDataGridViewTextBoxColumn.Name = "rbcdateoftakeningDataGridViewTextBoxColumn";
            // 
            // rbcexpectedreturndateDataGridViewTextBoxColumn
            // 
            this.rbcexpectedreturndateDataGridViewTextBoxColumn.DataPropertyName = "rbc_expected_return_date";
            this.rbcexpectedreturndateDataGridViewTextBoxColumn.HeaderText = "Очікуєма дата повернення";
            this.rbcexpectedreturndateDataGridViewTextBoxColumn.Name = "rbcexpectedreturndateDataGridViewTextBoxColumn";
            // 
            // rbcfactreturnDataGridViewTextBoxColumn
            // 
            this.rbcfactreturnDataGridViewTextBoxColumn.DataPropertyName = "rbc_fact_return";
            this.rbcfactreturnDataGridViewTextBoxColumn.HeaderText = "Реальна дата повернення";
            this.rbcfactreturnDataGridViewTextBoxColumn.Name = "rbcfactreturnDataGridViewTextBoxColumn";
            // 
            // rbcinfoDataGridViewTextBoxColumn
            // 
            this.rbcinfoDataGridViewTextBoxColumn.DataPropertyName = "rbc_info";
            this.rbcinfoDataGridViewTextBoxColumn.HeaderText = "Додадкова інформація";
            this.rbcinfoDataGridViewTextBoxColumn.Name = "rbcinfoDataGridViewTextBoxColumn";
            // 
            // dTReaderAllInfoBindingSource
            // 
            this.dTReaderAllInfoBindingSource.DataMember = "DTReaderAllInfo";
            this.dTReaderAllInfoBindingSource.DataSource = this.dataSetLibrary1;
            // 
            // dataSetLibrary1
            // 
            this.dataSetLibrary1.DataSetName = "DataSetLibrary";
            this.dataSetLibrary1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtReaderAllInfoTableAdapter1
            // 
            this.dtReaderAllInfoTableAdapter1.ClearBeforeFill = true;
            // 
            // FormReadersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(696, 286);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormReadersInfo";
            this.Text = "Інформація про читача";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTReaderAllInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLibrary1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LibraryData.DataSetLibrary dataSetLibrary1;
        private LibraryData.DataSetLibraryTableAdapters.DTReaderAllInfoTableAdapter dtReaderAllInfoTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcyearofpublicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rbcdateoftakeningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rbcexpectedreturndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rbcfactreturnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rbcinfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dTReaderAllInfoBindingSource;
    }
}