namespace WFLibrary
{
    partial class FormCatalogAuthorBook
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
            this.comboBoxCatalog = new System.Windows.Forms.ComboBox();
            this.notCatalogsBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLibrary1 = new LibraryData.DataSetLibrary();
            this.buttonAddCatalog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.notAuthorsBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.notCatalogsBooksTableAdapter1 = new LibraryData.DataSetLibraryTableAdapters.NotCatalogsBooksTableAdapter();
            this.notAuthorsBookTableAdapter1 = new LibraryData.DataSetLibraryTableAdapters.NotAuthorsBookTableAdapter();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notCatalogsBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLibrary1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notAuthorsBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCatalog
            // 
            this.comboBoxCatalog.AllowDrop = true;
            this.comboBoxCatalog.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.notCatalogsBooksBindingSource, "c_id", true));
            this.comboBoxCatalog.DataSource = this.notCatalogsBooksBindingSource;
            this.comboBoxCatalog.DisplayMember = "c_name";
            this.comboBoxCatalog.FormattingEnabled = true;
            this.comboBoxCatalog.Location = new System.Drawing.Point(161, 30);
            this.comboBoxCatalog.Name = "comboBoxCatalog";
            this.comboBoxCatalog.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCatalog.TabIndex = 0;
            this.comboBoxCatalog.ValueMember = "c_id";
            // 
            // notCatalogsBooksBindingSource
            // 
            this.notCatalogsBooksBindingSource.DataMember = "NotCatalogsBooks";
            this.notCatalogsBooksBindingSource.DataSource = this.dataSetLibrary1;
            // 
            // dataSetLibrary1
            // 
            this.dataSetLibrary1.DataSetName = "DataSetLibrary";
            this.dataSetLibrary1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAddCatalog
            // 
            this.buttonAddCatalog.Location = new System.Drawing.Point(296, 30);
            this.buttonAddCatalog.Name = "buttonAddCatalog";
            this.buttonAddCatalog.Size = new System.Drawing.Size(121, 21);
            this.buttonAddCatalog.TabIndex = 1;
            this.buttonAddCatalog.Text = "Додати категорію";
            this.buttonAddCatalog.UseVisualStyleBackColor = true;
            this.buttonAddCatalog.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Виберіть категорію";
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.notAuthorsBookBindingSource, "a_id", true));
            this.comboBoxAuthor.DataSource = this.notAuthorsBookBindingSource;
            this.comboBoxAuthor.DisplayMember = "a_name";
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(161, 90);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAuthor.TabIndex = 3;
            this.comboBoxAuthor.ValueMember = "a_id";
            // 
            // notAuthorsBookBindingSource
            // 
            this.notAuthorsBookBindingSource.DataMember = "NotAuthorsBook";
            this.notAuthorsBookBindingSource.DataSource = this.dataSetLibrary1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Виберіть автора";
            // 
            // notCatalogsBooksTableAdapter1
            // 
            this.notCatalogsBooksTableAdapter1.ClearBeforeFill = true;
            // 
            // notAuthorsBookTableAdapter1
            // 
            this.notAuthorsBookTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(296, 90);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(121, 23);
            this.buttonAddAuthor.TabIndex = 5;
            this.buttonAddAuthor.Text = "Додати автора";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // FormCatalogAuthorBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(458, 153);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddCatalog);
            this.Controls.Add(this.comboBoxCatalog);
            this.Name = "FormCatalogAuthorBook";
            this.Text = "Додавання до";
            this.Load += new System.EventHandler(this.FormCatalogAuthorBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notCatalogsBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLibrary1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notAuthorsBookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCatalog;
        private System.Windows.Forms.Button buttonAddCatalog;
        private LibraryData.DataSetLibrary dataSetLibrary1;
        private System.Windows.Forms.BindingSource notCatalogsBooksBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource notAuthorsBookBindingSource;
        private LibraryData.DataSetLibraryTableAdapters.NotCatalogsBooksTableAdapter notCatalogsBooksTableAdapter1;
        private LibraryData.DataSetLibraryTableAdapters.NotAuthorsBookTableAdapter notAuthorsBookTableAdapter1;
        private System.Windows.Forms.Button buttonAddAuthor;
    }
}