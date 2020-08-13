namespace SoftwareManagement.UserInterface.SettingForm
{
    partial class SettingMain
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
            this.gbSetting = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbProductType = new System.Windows.Forms.TextBox();
            this.dgvProductTypeList = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzytkownikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaUzytkownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzytkownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rodzajProduktuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rodzajProduktuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductTypeList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzytkownikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodzajProduktuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSetting
            // 
            this.gbSetting.Location = new System.Drawing.Point(12, 12);
            this.gbSetting.Name = "gbSetting";
            this.gbSetting.Size = new System.Drawing.Size(200, 153);
            this.gbSetting.TabIndex = 0;
            this.gbSetting.TabStop = false;
            this.gbSetting.Text = "Ogólne";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tbProductType);
            this.groupBox1.Controls.Add(this.dgvProductTypeList);
            this.groupBox1.Location = new System.Drawing.Point(892, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 277);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rodzaje produktow";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dodaj nowy typ produktu";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(61, 76);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbProductType
            // 
            this.tbProductType.Location = new System.Drawing.Point(44, 50);
            this.tbProductType.Name = "tbProductType";
            this.tbProductType.Size = new System.Drawing.Size(112, 20);
            this.tbProductType.TabIndex = 1;
            // 
            // dgvProductTypeList
            // 
            this.dgvProductTypeList.AutoGenerateColumns = false;
            this.dgvProductTypeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductTypeList.ColumnHeadersVisible = false;
            this.dgvProductTypeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rodzajProduktuIDDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.produktDataGridViewTextBoxColumn});
            this.dgvProductTypeList.DataSource = this.rodzajProduktuBindingSource;
            this.dgvProductTypeList.Location = new System.Drawing.Point(0, 121);
            this.dgvProductTypeList.Name = "dgvProductTypeList";
            this.dgvProductTypeList.RowHeadersVisible = false;
            this.dgvProductTypeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductTypeList.Size = new System.Drawing.Size(200, 150);
            this.dgvProductTypeList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAddUser);
            this.groupBox2.Controls.Add(this.dgvUser);
            this.groupBox2.Location = new System.Drawing.Point(362, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 365);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uzytkownicy";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(119, 38);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Usun";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(6, 38);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Dodaj";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.AutoGenerateColumns = false;
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.ColumnHeadersVisible = false;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uzytkownikIDDataGridViewTextBoxColumn,
            this.nazwaUzytkownikaDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.hasloDataGridViewTextBoxColumn,
            this.rolaDataGridViewTextBoxColumn,
            this.UserID,
            this.Rola});
            this.dgvUser.DataSource = this.uzytkownikBindingSource;
            this.dgvUser.Location = new System.Drawing.Point(0, 89);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(396, 275);
            this.dgvUser.TabIndex = 0;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "UserId";
            this.UserID.Name = "UserID";
            this.UserID.Visible = false;
            // 
            // Rola
            // 
            this.Rola.DataPropertyName = "Rola";
            this.Rola.HeaderText = "Status";
            this.Rola.Name = "Rola";
            this.Rola.Visible = false;
            // 
            // uzytkownikIDDataGridViewTextBoxColumn
            // 
            this.uzytkownikIDDataGridViewTextBoxColumn.DataPropertyName = "UzytkownikID";
            this.uzytkownikIDDataGridViewTextBoxColumn.HeaderText = "UzytkownikID";
            this.uzytkownikIDDataGridViewTextBoxColumn.Name = "uzytkownikIDDataGridViewTextBoxColumn";
            this.uzytkownikIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazwaUzytkownikaDataGridViewTextBoxColumn
            // 
            this.nazwaUzytkownikaDataGridViewTextBoxColumn.DataPropertyName = "NazwaUzytkownika";
            this.nazwaUzytkownikaDataGridViewTextBoxColumn.HeaderText = "NazwaUzytkownika";
            this.nazwaUzytkownikaDataGridViewTextBoxColumn.Name = "nazwaUzytkownikaDataGridViewTextBoxColumn";
            this.nazwaUzytkownikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.Width = 150;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.Width = 150;
            // 
            // hasloDataGridViewTextBoxColumn
            // 
            this.hasloDataGridViewTextBoxColumn.DataPropertyName = "Haslo";
            this.hasloDataGridViewTextBoxColumn.HeaderText = "Haslo";
            this.hasloDataGridViewTextBoxColumn.Name = "hasloDataGridViewTextBoxColumn";
            this.hasloDataGridViewTextBoxColumn.Visible = false;
            // 
            // rolaDataGridViewTextBoxColumn
            // 
            this.rolaDataGridViewTextBoxColumn.DataPropertyName = "Rola";
            this.rolaDataGridViewTextBoxColumn.HeaderText = "Rola";
            this.rolaDataGridViewTextBoxColumn.Name = "rolaDataGridViewTextBoxColumn";
            // 
            // uzytkownikBindingSource
            // 
            this.uzytkownikBindingSource.DataSource = typeof(SoftwareManagement.Models.Uzytkownik);
            // 
            // rodzajProduktuBindingSource
            // 
            this.rodzajProduktuBindingSource.DataSource = typeof(SoftwareManagement.Models.RodzajProduktu);
            // 
            // rodzajProduktuIDDataGridViewTextBoxColumn
            // 
            this.rodzajProduktuIDDataGridViewTextBoxColumn.DataPropertyName = "RodzajProduktuID";
            this.rodzajProduktuIDDataGridViewTextBoxColumn.HeaderText = "RodzajProduktuID";
            this.rodzajProduktuIDDataGridViewTextBoxColumn.Name = "rodzajProduktuIDDataGridViewTextBoxColumn";
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            // 
            // produktDataGridViewTextBoxColumn
            // 
            this.produktDataGridViewTextBoxColumn.DataPropertyName = "Produkt";
            this.produktDataGridViewTextBoxColumn.HeaderText = "Produkt";
            this.produktDataGridViewTextBoxColumn.Name = "produktDataGridViewTextBoxColumn";
            this.produktDataGridViewTextBoxColumn.ReadOnly = true;
            this.produktDataGridViewTextBoxColumn.Visible = false;
            // 
            // SettingMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 613);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSetting);
            this.Name = "SettingMain";
            this.Text = "Ustawienia";
            this.Load += new System.EventHandler(this.SettingMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductTypeList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzytkownikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodzajProduktuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSetting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvProductTypeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox tbProductType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn uzytkownikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaUzytkownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.BindingSource uzytkownikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rola;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzajProduktuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produktDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rodzajProduktuBindingSource;
    }
}