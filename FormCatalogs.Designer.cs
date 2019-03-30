namespace WFLibrary
{
    partial class FormCatalogs
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
            this.dGVCatalogs = new System.Windows.Forms.DataGridView();
            this.bindingSourceDTCatalogsOfBooks = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLibrary1 = new LibraryData.DataSetLibrary();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownUpperYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLowerYear = new System.Windows.Forms.NumericUpDown();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dtCatalogsOfBooksTableAdapter1 = new LibraryData.DataSetLibraryTableAdapters.DTCatalogsOfBooksTableAdapter();
            this.bnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.byearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCatalogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDTCatalogsOfBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLibrary1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpperYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowerYear)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVCatalogs
            // 
            this.dGVCatalogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVCatalogs.AutoGenerateColumns = false;
            this.dGVCatalogs.BackgroundColor = System.Drawing.Color.Maroon;
            this.dGVCatalogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCatalogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bnameDataGridViewTextBoxColumn,
            this.byearDataGridViewTextBoxColumn,
            this.bidDataGridViewTextBoxColumn,
            this.cidDataGridViewTextBoxColumn});
            this.dGVCatalogs.DataSource = this.bindingSourceDTCatalogsOfBooks;
            this.dGVCatalogs.Location = new System.Drawing.Point(12, 207);
            this.dGVCatalogs.Name = "dGVCatalogs";
            this.dGVCatalogs.Size = new System.Drawing.Size(581, 100);
            this.dGVCatalogs.TabIndex = 0;
            this.dGVCatalogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVCatalogs_CellContentClick);
            this.dGVCatalogs.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVCatalogs_CellMouseEnter);
            this.dGVCatalogs.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dGVCatalogs_DefaultValuesNeeded);
            // 
            // bindingSourceDTCatalogsOfBooks
            // 
            this.bindingSourceDTCatalogsOfBooks.DataMember = "DTCatalogsOfBooks";
            this.bindingSourceDTCatalogsOfBooks.DataSource = this.dataSetLibrary1;
            // 
            // dataSetLibrary1
            // 
            this.dataSetLibrary1.DataSetName = "DataSetLibrary";
            this.dataSetLibrary1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Pink;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSearch.Location = new System.Drawing.Point(352, 15);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 38);
            this.buttonSearch.TabIndex = 40;
            this.buttonSearch.Text = "Пошук";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(270, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "до";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Рік написання";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Автор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Назва книги";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Параметри пошуку";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDownUpperYear
            // 
            this.numericUpDownUpperYear.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownUpperYear.Location = new System.Drawing.Point(307, 158);
            this.numericUpDownUpperYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownUpperYear.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDownUpperYear.Name = "numericUpDownUpperYear";
            this.numericUpDownUpperYear.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownUpperYear.TabIndex = 34;
            this.numericUpDownUpperYear.Value = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            // 
            // numericUpDownLowerYear
            // 
            this.numericUpDownLowerYear.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownLowerYear.Location = new System.Drawing.Point(133, 158);
            this.numericUpDownLowerYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownLowerYear.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDownLowerYear.Name = "numericUpDownLowerYear";
            this.numericUpDownLowerYear.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLowerYear.TabIndex = 33;
            this.numericUpDownLowerYear.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(133, 107);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(294, 20);
            this.textBoxAuthor.TabIndex = 32;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(133, 65);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(294, 20);
            this.textBoxName.TabIndex = 31;
            // 
            // dtCatalogsOfBooksTableAdapter1
            // 
            this.dtCatalogsOfBooksTableAdapter1.ClearBeforeFill = true;
            // 
            // bnameDataGridViewTextBoxColumn
            // 
            this.bnameDataGridViewTextBoxColumn.DataPropertyName = "b_name";
            this.bnameDataGridViewTextBoxColumn.HeaderText = "Назва книги";
            this.bnameDataGridViewTextBoxColumn.Name = "bnameDataGridViewTextBoxColumn";
            // 
            // byearDataGridViewTextBoxColumn
            // 
            this.byearDataGridViewTextBoxColumn.DataPropertyName = "b_year";
            this.byearDataGridViewTextBoxColumn.HeaderText = "Рік написання";
            this.byearDataGridViewTextBoxColumn.Name = "byearDataGridViewTextBoxColumn";
            // 
            // bidDataGridViewTextBoxColumn
            // 
            this.bidDataGridViewTextBoxColumn.DataPropertyName = "b_id";
            this.bidDataGridViewTextBoxColumn.HeaderText = "b_id";
            this.bidDataGridViewTextBoxColumn.Name = "bidDataGridViewTextBoxColumn";
            this.bidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bidDataGridViewTextBoxColumn.Visible = false;
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "c_id";
            this.cidDataGridViewTextBoxColumn.HeaderText = "c_id";
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormCatalogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(605, 319);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownUpperYear);
            this.Controls.Add(this.numericUpDownLowerYear);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dGVCatalogs);
            this.Name = "FormCatalogs";
            this.Text = "Пошук";
            this.Load += new System.EventHandler(this.FormCatalogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCatalogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDTCatalogsOfBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLibrary1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpperYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowerYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVCatalogs;
        private LibraryData.DataSetLibrary dataSetLibrary1;
        private LibraryData.DataSetLibraryTableAdapters.DTCatalogsOfBooksTableAdapter dtCatalogsOfBooksTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSourceDTCatalogsOfBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn anameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownUpperYear;
        private System.Windows.Forms.NumericUpDown numericUpDownLowerYear;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn byearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
    }
}