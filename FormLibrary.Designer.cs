namespace WFLibrary
{
    partial class FormLibrary
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLibrary));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonCheckAvailability = new System.Windows.Forms.Button();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonBookSafe = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.bidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.byearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLibrary1 = new LibraryData.DataSetLibrary();
            this.tabReaders = new System.Windows.Forms.TabPage();
            this.buttonCheckDebts = new System.Windows.Forms.Button();
            this.buttonDeleteReaders = new System.Windows.Forms.Button();
            this.buttonSafeReaders = new System.Windows.Forms.Button();
            this.dataGridViewReaders = new System.Windows.Forms.DataGridView();
            this.rdidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rddateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdtelefonnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabCatalogs = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteCatalogs = new System.Windows.Forms.Button();
            this.buttonSafeCatalogs = new System.Windows.Forms.Button();
            this.dataGridViewCatalogs = new System.Windows.Forms.DataGridView();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabAuthors = new System.Windows.Forms.TabPage();
            this.buttonDeleteAuthors = new System.Windows.Forms.Button();
            this.buttonSafeAuthors = new System.Windows.Forms.Button();
            this.dataGridViewAuthors = new System.Windows.Forms.DataGridView();
            this.aidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adateofdeathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter1 = new LibraryData.DataSetLibraryTableAdapters.BooksTableAdapter();
            this.readersTableAdapter1 = new LibraryData.DataSetLibraryTableAdapters.ReadersTableAdapter();
            this.catalogsTableAdapter1 = new LibraryData.DataSetLibraryTableAdapters.CatalogsTableAdapter();
            this.authorsTableAdapter1 = new LibraryData.DataSetLibraryTableAdapters.AuthorsTableAdapter();
            this.queriesTableAdapter1 = new LibraryData.DataSetLibraryTableAdapters.QueriesTableAdapter();
            this.book_authorsTableAdapter1 = new LibraryData.DataSetLibraryTableAdapters.Book_authorsTableAdapter();
            this.book_catalogsTableAdapter1 = new LibraryData.DataSetLibraryTableAdapters.Book_catalogsTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLibrary1)).BeginInit();
            this.tabReaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).BeginInit();
            this.tabCatalogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogsBindingSource)).BeginInit();
            this.tabAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabBooks);
            this.tabControl1.Controls.Add(this.tabReaders);
            this.tabControl1.Controls.Add(this.tabCatalogs);
            this.tabControl1.Controls.Add(this.tabAuthors);
            this.tabControl1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 87);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 276);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBooks
            // 
            this.tabBooks.BackColor = System.Drawing.Color.OldLace;
            this.tabBooks.Controls.Add(this.buttonAddBook);
            this.tabBooks.Controls.Add(this.buttonCheckAvailability);
            this.tabBooks.Controls.Add(this.buttonDeleteBook);
            this.tabBooks.Controls.Add(this.buttonBookSafe);
            this.tabBooks.Controls.Add(this.dataGridViewBooks);
            this.tabBooks.Location = new System.Drawing.Point(4, 25);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooks.Size = new System.Drawing.Size(646, 247);
            this.tabBooks.TabIndex = 0;
            this.tabBooks.Text = "Книги";
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddBook.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonAddBook.Location = new System.Drawing.Point(271, 18);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(157, 66);
            this.buttonAddBook.TabIndex = 4;
            this.buttonAddBook.Text = "Додати авторів і категорію до обраної книги";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonCheckAvailability
            // 
            this.buttonCheckAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCheckAvailability.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonCheckAvailability.Location = new System.Drawing.Point(459, 29);
            this.buttonCheckAvailability.Name = "buttonCheckAvailability";
            this.buttonCheckAvailability.Size = new System.Drawing.Size(149, 44);
            this.buttonCheckAvailability.TabIndex = 3;
            this.buttonCheckAvailability.Text = "Перевірити книгу на наявність";
            this.buttonCheckAvailability.UseVisualStyleBackColor = true;
            this.buttonCheckAvailability.Click += new System.EventHandler(this.buttonCheckAvailability_Click);
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteBook.ForeColor = System.Drawing.Color.Maroon;
            this.buttonDeleteBook.Location = new System.Drawing.Point(6, 40);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteBook.TabIndex = 2;
            this.buttonDeleteBook.Text = "Видалити";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // buttonBookSafe
            // 
            this.buttonBookSafe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBookSafe.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookSafe.ForeColor = System.Drawing.Color.Green;
            this.buttonBookSafe.Location = new System.Drawing.Point(124, 39);
            this.buttonBookSafe.Name = "buttonBookSafe";
            this.buttonBookSafe.Size = new System.Drawing.Size(88, 23);
            this.buttonBookSafe.TabIndex = 1;
            this.buttonBookSafe.Text = "Зберегти";
            this.buttonBookSafe.UseVisualStyleBackColor = true;
            this.buttonBookSafe.Click += new System.EventHandler(this.buttonBookSafe_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBooks.AutoGenerateColumns = false;
            this.dataGridViewBooks.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bidDataGridViewTextBoxColumn,
            this.bnameDataGridViewTextBoxColumn,
            this.byearDataGridViewTextBoxColumn});
            this.dataGridViewBooks.DataSource = this.booksBindingSource;
            this.dataGridViewBooks.Location = new System.Drawing.Point(6, 90);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(634, 151);
            this.dataGridViewBooks.TabIndex = 0;
            this.dataGridViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bidDataGridViewTextBoxColumn
            // 
            this.bidDataGridViewTextBoxColumn.DataPropertyName = "b_id";
            this.bidDataGridViewTextBoxColumn.HeaderText = "b_id";
            this.bidDataGridViewTextBoxColumn.Name = "bidDataGridViewTextBoxColumn";
            this.bidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bidDataGridViewTextBoxColumn.Visible = false;
            // 
            // bnameDataGridViewTextBoxColumn
            // 
            this.bnameDataGridViewTextBoxColumn.DataPropertyName = "b_name";
            this.bnameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.bnameDataGridViewTextBoxColumn.Name = "bnameDataGridViewTextBoxColumn";
            // 
            // byearDataGridViewTextBoxColumn
            // 
            this.byearDataGridViewTextBoxColumn.DataPropertyName = "b_year";
            this.byearDataGridViewTextBoxColumn.HeaderText = "Рік";
            this.byearDataGridViewTextBoxColumn.Name = "byearDataGridViewTextBoxColumn";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.dataSetLibrary1;
            // 
            // dataSetLibrary1
            // 
            this.dataSetLibrary1.DataSetName = "DataSetLibrary";
            this.dataSetLibrary1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabReaders
            // 
            this.tabReaders.BackColor = System.Drawing.Color.OldLace;
            this.tabReaders.Controls.Add(this.buttonCheckDebts);
            this.tabReaders.Controls.Add(this.buttonDeleteReaders);
            this.tabReaders.Controls.Add(this.buttonSafeReaders);
            this.tabReaders.Controls.Add(this.dataGridViewReaders);
            this.tabReaders.Location = new System.Drawing.Point(4, 25);
            this.tabReaders.Name = "tabReaders";
            this.tabReaders.Padding = new System.Windows.Forms.Padding(3);
            this.tabReaders.Size = new System.Drawing.Size(646, 247);
            this.tabReaders.TabIndex = 1;
            this.tabReaders.Text = "Читачі";
            // 
            // buttonCheckDebts
            // 
            this.buttonCheckDebts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCheckDebts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonCheckDebts.Location = new System.Drawing.Point(465, 15);
            this.buttonCheckDebts.Name = "buttonCheckDebts";
            this.buttonCheckDebts.Size = new System.Drawing.Size(175, 23);
            this.buttonCheckDebts.TabIndex = 3;
            this.buttonCheckDebts.Text = "Перевірити заборгованість";
            this.buttonCheckDebts.UseVisualStyleBackColor = true;
            this.buttonCheckDebts.Click += new System.EventHandler(this.buttonCheckDebts_Click);
            // 
            // buttonDeleteReaders
            // 
            this.buttonDeleteReaders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteReaders.ForeColor = System.Drawing.Color.Maroon;
            this.buttonDeleteReaders.Location = new System.Drawing.Point(6, 16);
            this.buttonDeleteReaders.Name = "buttonDeleteReaders";
            this.buttonDeleteReaders.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteReaders.TabIndex = 2;
            this.buttonDeleteReaders.Text = "Видалити";
            this.buttonDeleteReaders.UseVisualStyleBackColor = true;
            this.buttonDeleteReaders.Click += new System.EventHandler(this.buttonDeleteReaders_Click);
            // 
            // buttonSafeReaders
            // 
            this.buttonSafeReaders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSafeReaders.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSafeReaders.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonSafeReaders.Location = new System.Drawing.Point(111, 16);
            this.buttonSafeReaders.Name = "buttonSafeReaders";
            this.buttonSafeReaders.Size = new System.Drawing.Size(93, 23);
            this.buttonSafeReaders.TabIndex = 1;
            this.buttonSafeReaders.Text = "Зберегти";
            this.buttonSafeReaders.UseVisualStyleBackColor = true;
            this.buttonSafeReaders.Click += new System.EventHandler(this.buttonSafeReaders_Click);
            // 
            // dataGridViewReaders
            // 
            this.dataGridViewReaders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReaders.AutoGenerateColumns = false;
            this.dataGridViewReaders.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridViewReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rdidDataGridViewTextBoxColumn,
            this.rdnameDataGridViewTextBoxColumn,
            this.rddateofbirthDataGridViewTextBoxColumn,
            this.rdtelefonnumberDataGridViewTextBoxColumn});
            this.dataGridViewReaders.DataSource = this.readersBindingSource;
            this.dataGridViewReaders.Location = new System.Drawing.Point(6, 44);
            this.dataGridViewReaders.Name = "dataGridViewReaders";
            this.dataGridViewReaders.Size = new System.Drawing.Size(634, 197);
            this.dataGridViewReaders.TabIndex = 0;
            this.dataGridViewReaders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReaders_CellContentClick);
            this.dataGridViewReaders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReaders_CellDoubleClick);
            // 
            // rdidDataGridViewTextBoxColumn
            // 
            this.rdidDataGridViewTextBoxColumn.DataPropertyName = "rd_id";
            this.rdidDataGridViewTextBoxColumn.HeaderText = "rd_id";
            this.rdidDataGridViewTextBoxColumn.Name = "rdidDataGridViewTextBoxColumn";
            this.rdidDataGridViewTextBoxColumn.ReadOnly = true;
            this.rdidDataGridViewTextBoxColumn.Visible = false;
            // 
            // rdnameDataGridViewTextBoxColumn
            // 
            this.rdnameDataGridViewTextBoxColumn.DataPropertyName = "rd_name";
            this.rdnameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.rdnameDataGridViewTextBoxColumn.Name = "rdnameDataGridViewTextBoxColumn";
            // 
            // rddateofbirthDataGridViewTextBoxColumn
            // 
            this.rddateofbirthDataGridViewTextBoxColumn.DataPropertyName = "rd_date_of_birth";
            this.rddateofbirthDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.rddateofbirthDataGridViewTextBoxColumn.Name = "rddateofbirthDataGridViewTextBoxColumn";
            // 
            // rdtelefonnumberDataGridViewTextBoxColumn
            // 
            this.rdtelefonnumberDataGridViewTextBoxColumn.DataPropertyName = "rd_telefon_number";
            this.rdtelefonnumberDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.rdtelefonnumberDataGridViewTextBoxColumn.Name = "rdtelefonnumberDataGridViewTextBoxColumn";
            // 
            // readersBindingSource
            // 
            this.readersBindingSource.DataMember = "Readers";
            this.readersBindingSource.DataSource = this.dataSetLibrary1;
            // 
            // tabCatalogs
            // 
            this.tabCatalogs.BackColor = System.Drawing.Color.Wheat;
            this.tabCatalogs.Controls.Add(this.label1);
            this.tabCatalogs.Controls.Add(this.buttonDeleteCatalogs);
            this.tabCatalogs.Controls.Add(this.buttonSafeCatalogs);
            this.tabCatalogs.Controls.Add(this.dataGridViewCatalogs);
            this.tabCatalogs.Location = new System.Drawing.Point(4, 25);
            this.tabCatalogs.Name = "tabCatalogs";
            this.tabCatalogs.Size = new System.Drawing.Size(646, 247);
            this.tabCatalogs.TabIndex = 2;
            this.tabCatalogs.Text = "Каталог";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(260, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Натисніть по категорії, щоб перейти до пошуку";
            // 
            // buttonDeleteCatalogs
            // 
            this.buttonDeleteCatalogs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteCatalogs.ForeColor = System.Drawing.Color.Maroon;
            this.buttonDeleteCatalogs.Location = new System.Drawing.Point(277, 66);
            this.buttonDeleteCatalogs.Name = "buttonDeleteCatalogs";
            this.buttonDeleteCatalogs.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteCatalogs.TabIndex = 2;
            this.buttonDeleteCatalogs.Text = "Видалити";
            this.buttonDeleteCatalogs.UseVisualStyleBackColor = true;
            this.buttonDeleteCatalogs.Click += new System.EventHandler(this.buttonDeleteCatalogs_Click);
            // 
            // buttonSafeCatalogs
            // 
            this.buttonSafeCatalogs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSafeCatalogs.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSafeCatalogs.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonSafeCatalogs.Location = new System.Drawing.Point(277, 16);
            this.buttonSafeCatalogs.Name = "buttonSafeCatalogs";
            this.buttonSafeCatalogs.Size = new System.Drawing.Size(75, 23);
            this.buttonSafeCatalogs.TabIndex = 1;
            this.buttonSafeCatalogs.Text = "Зберегти";
            this.buttonSafeCatalogs.UseVisualStyleBackColor = true;
            this.buttonSafeCatalogs.Click += new System.EventHandler(this.buttonSafeCatalogs_Click);
            // 
            // dataGridViewCatalogs
            // 
            this.dataGridViewCatalogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewCatalogs.AutoGenerateColumns = false;
            this.dataGridViewCatalogs.BackgroundColor = System.Drawing.Color.Olive;
            this.dataGridViewCatalogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatalogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn});
            this.dataGridViewCatalogs.DataSource = this.catalogsBindingSource;
            this.dataGridViewCatalogs.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewCatalogs.Name = "dataGridViewCatalogs";
            this.dataGridViewCatalogs.Size = new System.Drawing.Size(239, 228);
            this.dataGridViewCatalogs.TabIndex = 0;
            this.dataGridViewCatalogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCatalogs_CellContentClick);
            this.dataGridViewCatalogs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCatalogs_CellDoubleClick);
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "c_id";
            this.cidDataGridViewTextBoxColumn.HeaderText = "c_id";
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidDataGridViewTextBoxColumn.Visible = false;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "c_name";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            // 
            // catalogsBindingSource
            // 
            this.catalogsBindingSource.DataMember = "Catalogs";
            this.catalogsBindingSource.DataSource = this.dataSetLibrary1;
            // 
            // tabAuthors
            // 
            this.tabAuthors.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabAuthors.Controls.Add(this.buttonDeleteAuthors);
            this.tabAuthors.Controls.Add(this.buttonSafeAuthors);
            this.tabAuthors.Controls.Add(this.dataGridViewAuthors);
            this.tabAuthors.Location = new System.Drawing.Point(4, 25);
            this.tabAuthors.Name = "tabAuthors";
            this.tabAuthors.Size = new System.Drawing.Size(646, 247);
            this.tabAuthors.TabIndex = 3;
            this.tabAuthors.Text = "Автори";
            // 
            // buttonDeleteAuthors
            // 
            this.buttonDeleteAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteAuthors.ForeColor = System.Drawing.Color.Maroon;
            this.buttonDeleteAuthors.Location = new System.Drawing.Point(128, 13);
            this.buttonDeleteAuthors.Name = "buttonDeleteAuthors";
            this.buttonDeleteAuthors.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAuthors.TabIndex = 2;
            this.buttonDeleteAuthors.Text = "Видалити";
            this.buttonDeleteAuthors.UseVisualStyleBackColor = true;
            this.buttonDeleteAuthors.Click += new System.EventHandler(this.buttonDeleteAuthors_Click);
            // 
            // buttonSafeAuthors
            // 
            this.buttonSafeAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSafeAuthors.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSafeAuthors.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonSafeAuthors.Location = new System.Drawing.Point(255, 13);
            this.buttonSafeAuthors.Name = "buttonSafeAuthors";
            this.buttonSafeAuthors.Size = new System.Drawing.Size(75, 23);
            this.buttonSafeAuthors.TabIndex = 1;
            this.buttonSafeAuthors.Text = "Зберегти";
            this.buttonSafeAuthors.UseVisualStyleBackColor = true;
            this.buttonSafeAuthors.Click += new System.EventHandler(this.buttonSafeAuthors_Click);
            // 
            // dataGridViewAuthors
            // 
            this.dataGridViewAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAuthors.AutoGenerateColumns = false;
            this.dataGridViewAuthors.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aidDataGridViewTextBoxColumn,
            this.anameDataGridViewTextBoxColumn,
            this.acountryDataGridViewTextBoxColumn,
            this.adateofbirthDataGridViewTextBoxColumn,
            this.adateofdeathDataGridViewTextBoxColumn});
            this.dataGridViewAuthors.DataSource = this.authorsBindingSource;
            this.dataGridViewAuthors.Location = new System.Drawing.Point(3, 52);
            this.dataGridViewAuthors.Name = "dataGridViewAuthors";
            this.dataGridViewAuthors.Size = new System.Drawing.Size(640, 192);
            this.dataGridViewAuthors.TabIndex = 0;
            // 
            // aidDataGridViewTextBoxColumn
            // 
            this.aidDataGridViewTextBoxColumn.DataPropertyName = "a_id";
            this.aidDataGridViewTextBoxColumn.HeaderText = "a_id";
            this.aidDataGridViewTextBoxColumn.Name = "aidDataGridViewTextBoxColumn";
            this.aidDataGridViewTextBoxColumn.ReadOnly = true;
            this.aidDataGridViewTextBoxColumn.Visible = false;
            // 
            // anameDataGridViewTextBoxColumn
            // 
            this.anameDataGridViewTextBoxColumn.DataPropertyName = "a_name";
            this.anameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.anameDataGridViewTextBoxColumn.Name = "anameDataGridViewTextBoxColumn";
            // 
            // acountryDataGridViewTextBoxColumn
            // 
            this.acountryDataGridViewTextBoxColumn.DataPropertyName = "a_country";
            this.acountryDataGridViewTextBoxColumn.HeaderText = "Країна";
            this.acountryDataGridViewTextBoxColumn.Name = "acountryDataGridViewTextBoxColumn";
            // 
            // adateofbirthDataGridViewTextBoxColumn
            // 
            this.adateofbirthDataGridViewTextBoxColumn.DataPropertyName = "a_date_of_birth";
            this.adateofbirthDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.adateofbirthDataGridViewTextBoxColumn.Name = "adateofbirthDataGridViewTextBoxColumn";
            // 
            // adateofdeathDataGridViewTextBoxColumn
            // 
            this.adateofdeathDataGridViewTextBoxColumn.DataPropertyName = "a_date_of_death";
            this.adateofdeathDataGridViewTextBoxColumn.HeaderText = "Дата смерті";
            this.adateofdeathDataGridViewTextBoxColumn.Name = "adateofdeathDataGridViewTextBoxColumn";
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.dataSetLibrary1;
            // 
            // booksTableAdapter1
            // 
            this.booksTableAdapter1.ClearBeforeFill = true;
            // 
            // readersTableAdapter1
            // 
            this.readersTableAdapter1.ClearBeforeFill = true;
            // 
            // catalogsTableAdapter1
            // 
            this.catalogsTableAdapter1.ClearBeforeFill = true;
            // 
            // authorsTableAdapter1
            // 
            this.authorsTableAdapter1.ClearBeforeFill = true;
            // 
            // book_authorsTableAdapter1
            // 
            this.book_authorsTableAdapter1.ClearBeforeFill = true;
            // 
            // book_catalogsTableAdapter1
            // 
            this.book_catalogsTableAdapter1.ClearBeforeFill = true;
            // 
            // FormLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(678, 375);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormLibrary";
            this.Text = "Бібліотека";
            this.Load += new System.EventHandler(this.FormLibrary_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLibrary1)).EndInit();
            this.tabReaders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).EndInit();
            this.tabCatalogs.ResumeLayout(false);
            this.tabCatalogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogsBindingSource)).EndInit();
            this.tabAuthors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.TabPage tabReaders;
        private System.Windows.Forms.DataGridView dataGridViewReaders;
        private System.Windows.Forms.TabPage tabCatalogs;
        private System.Windows.Forms.DataGridView dataGridViewCatalogs;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryData.DataSetLibraryTableAdapters.BooksTableAdapter booksTableAdapter1;
        private LibraryData.DataSetLibrary dataSetLibrary1;
        private System.Windows.Forms.Button buttonBookSafe;
        private System.Windows.Forms.Button buttonCheckAvailability;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonCheckDebts;
        private System.Windows.Forms.Button buttonDeleteReaders;
        private System.Windows.Forms.Button buttonSafeReaders;
        private System.Windows.Forms.BindingSource readersBindingSource;
        private LibraryData.DataSetLibraryTableAdapters.ReadersTableAdapter readersTableAdapter1;
        private System.Windows.Forms.Button buttonDeleteCatalogs;
        private System.Windows.Forms.Button buttonSafeCatalogs;
        private System.Windows.Forms.BindingSource catalogsBindingSource;
        private LibraryData.DataSetLibraryTableAdapters.CatalogsTableAdapter catalogsTableAdapter1;
        private System.Windows.Forms.TabPage tabAuthors;
        private System.Windows.Forms.DataGridView dataGridViewAuthors;
        private System.Windows.Forms.Button buttonDeleteAuthors;
        private System.Windows.Forms.Button buttonSafeAuthors;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private LibraryData.DataSetLibraryTableAdapters.AuthorsTableAdapter authorsTableAdapter1;
        private LibraryData.DataSetLibraryTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn byearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rddateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdtelefonnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adateofdeathDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Label label1;
        private LibraryData.DataSetLibraryTableAdapters.Book_authorsTableAdapter book_authorsTableAdapter1;
        private LibraryData.DataSetLibraryTableAdapters.Book_catalogsTableAdapter book_catalogsTableAdapter1;
    }
}

