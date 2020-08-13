namespace SoftwareManagement.UserInterface.ContractorForm
{
    partial class MainContractor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvContractor = new System.Windows.Forms.DataGridView();
            this.kontrahentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kontrahentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REGON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlatNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziwskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerTelefonuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrahentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 32);
            this.panel1.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.Location = new System.Drawing.Point(273, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 32);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Modyfikuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInfo.Location = new System.Drawing.Point(182, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(91, 32);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "Informacje";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Location = new System.Drawing.Point(91, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Usun";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(428, 6);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(229, 20);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.Search);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szukaj";
            // 
            // dgvContractor
            // 
            this.dgvContractor.AllowUserToAddRows = false;
            this.dgvContractor.AllowUserToResizeRows = false;
            this.dgvContractor.AutoGenerateColumns = false;
            this.dgvContractor.BackgroundColor = System.Drawing.Color.White;
            this.dgvContractor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContractor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kontrahentIDDataGridViewTextBoxColumn,
            this.REGON,
            this.Street,
            this.HomeNr,
            this.FlatNr,
            this.ZipCode,
            this.City,
            this.nazwaDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.naziwskoDataGridViewTextBoxColumn,
            this.nIPDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.numerTelefonuDataGridViewTextBoxColumn,
            this.rEGONDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.zamowieniaDataGridViewTextBoxColumn});
            this.dgvContractor.DataSource = this.kontrahentBindingSource;
            this.dgvContractor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContractor.Location = new System.Drawing.Point(0, 32);
            this.dgvContractor.Name = "dgvContractor";
            this.dgvContractor.RowHeadersVisible = false;
            this.dgvContractor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContractor.Size = new System.Drawing.Size(800, 418);
            this.dgvContractor.TabIndex = 1;
            this.dgvContractor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContractor_CellClick);
            // 
            // kontrahentBindingSource
            // 
            this.kontrahentBindingSource.DataSource = typeof(SoftwareManagement.Models.Kontrahent);
            // 
            // kontrahentIDDataGridViewTextBoxColumn
            // 
            this.kontrahentIDDataGridViewTextBoxColumn.DataPropertyName = "KontrahentID";
            this.kontrahentIDDataGridViewTextBoxColumn.HeaderText = "KontrahentID";
            this.kontrahentIDDataGridViewTextBoxColumn.Name = "kontrahentIDDataGridViewTextBoxColumn";
            this.kontrahentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // REGON
            // 
            this.REGON.DataPropertyName = "REGON";
            this.REGON.HeaderText = "REGON";
            this.REGON.Name = "REGON";
            this.REGON.Visible = false;
            // 
            // Street
            // 
            this.Street.DataPropertyName = "ContractorID";
            this.Street.HeaderText = "Ulica";
            this.Street.Name = "Street";
            this.Street.Visible = false;
            // 
            // HomeNr
            // 
            this.HomeNr.DataPropertyName = "ContractorID";
            this.HomeNr.HeaderText = "Numer domu";
            this.HomeNr.Name = "HomeNr";
            this.HomeNr.Visible = false;
            // 
            // FlatNr
            // 
            this.FlatNr.DataPropertyName = "ContractorID";
            this.FlatNr.HeaderText = "Numer mieszkania";
            this.FlatNr.Name = "FlatNr";
            this.FlatNr.Visible = false;
            // 
            // ZipCode
            // 
            this.ZipCode.DataPropertyName = "ContractorID";
            this.ZipCode.HeaderText = "Kod pocztowy";
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.Visible = false;
            // 
            // City
            // 
            this.City.DataPropertyName = "ContractorID";
            this.City.HeaderText = "Miasto";
            this.City.Name = "City";
            this.City.Visible = false;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.Width = 120;
            // 
            // naziwskoDataGridViewTextBoxColumn
            // 
            this.naziwskoDataGridViewTextBoxColumn.DataPropertyName = "Naziwsko";
            this.naziwskoDataGridViewTextBoxColumn.HeaderText = "Naziwsko";
            this.naziwskoDataGridViewTextBoxColumn.Name = "naziwskoDataGridViewTextBoxColumn";
            this.naziwskoDataGridViewTextBoxColumn.Width = 120;
            // 
            // nIPDataGridViewTextBoxColumn
            // 
            this.nIPDataGridViewTextBoxColumn.DataPropertyName = "NIP";
            this.nIPDataGridViewTextBoxColumn.HeaderText = "NIP";
            this.nIPDataGridViewTextBoxColumn.Name = "nIPDataGridViewTextBoxColumn";
            this.nIPDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // numerTelefonuDataGridViewTextBoxColumn
            // 
            this.numerTelefonuDataGridViewTextBoxColumn.DataPropertyName = "NumerTelefonu";
            this.numerTelefonuDataGridViewTextBoxColumn.HeaderText = "Numer Telefonu";
            this.numerTelefonuDataGridViewTextBoxColumn.Name = "numerTelefonuDataGridViewTextBoxColumn";
            this.numerTelefonuDataGridViewTextBoxColumn.Width = 120;
            // 
            // rEGONDataGridViewTextBoxColumn
            // 
            this.rEGONDataGridViewTextBoxColumn.DataPropertyName = "REGON";
            this.rEGONDataGridViewTextBoxColumn.HeaderText = "REGON";
            this.rEGONDataGridViewTextBoxColumn.Name = "rEGONDataGridViewTextBoxColumn";
            this.rEGONDataGridViewTextBoxColumn.Visible = false;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Visible = false;
            // 
            // zamowieniaDataGridViewTextBoxColumn
            // 
            this.zamowieniaDataGridViewTextBoxColumn.DataPropertyName = "Zamowienia";
            this.zamowieniaDataGridViewTextBoxColumn.HeaderText = "Zamowienia";
            this.zamowieniaDataGridViewTextBoxColumn.Name = "zamowieniaDataGridViewTextBoxColumn";
            this.zamowieniaDataGridViewTextBoxColumn.Visible = false;
            // 
            // MainContractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvContractor);
            this.Controls.Add(this.panel1);
            this.Name = "MainContractor";
            this.Text = "Kontrahenci";
            this.Load += new System.EventHandler(this.MainContractor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrahentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvContractor;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.BindingSource kontrahentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontrahentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGON;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlatNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziwskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerTelefonuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zamowieniaDataGridViewTextBoxColumn;
    }
}