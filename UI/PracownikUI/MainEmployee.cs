using SoftwareManagement.Database;
using SoftwareManagement.Models;
using SoftwareManagement.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareManagement.UserInterface.EmployeeForm
{
    public partial class MainEmployee : Form
    {
        ModelContext db = new ModelContext();
        public MainEmployee()
        {
            InitializeComponent();
        }


        private void MainEmployee_Load(object sender, EventArgs e)
        {
            dgvEmployee.FirstDisplayedCell = null;
            dgvEmployee.ClearSelection();
            LoadTheme();

            LoadData();
      
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
       
        }

            private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee frm = new AddEmployee(0);
            frm.ShowDialog();
            LoadData();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee(Convert.ToInt32(this.dgvEmployee.CurrentRow.Cells[0].Value));
             ae.ShowDialog();
            LoadData();
         }
       
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            EmailForm ef = new EmailForm(Convert.ToInt32(this.dgvEmployee.CurrentRow.Cells[0].Value));
            ef.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee(Convert.ToInt32(this.dgvEmployee.CurrentRow.Cells[0].Value));
            ae.ShowDialog();
            LoadData();
        }

        void Delete()
        {
            if (MessageBox.Show("Jesteś pewien że chcesz usunąć te dane", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int pracownikId = Convert.ToInt32(this.dgvEmployee.CurrentRow.Cells[0].Value);
                var pracownik = db.Pracownicy.FirstOrDefault(a => a.PracownikID == pracownikId);
                db.Pracownicy.Remove(pracownik);
                db.SaveChanges();
                LoadData();
            }
        }

        void LoadData()
        {
            int saveRow = 0;
            if (dgvEmployee.Rows.Count > 0)
                saveRow = dgvEmployee.FirstDisplayedCell.RowIndex;
            ModelContext db = new ModelContext();
            dgvEmployee.DataSource = db.Pracownicy.ToList();
            if (saveRow != 0 && saveRow < dgvEmployee.Rows.Count)
                dgvEmployee.FirstDisplayedScrollingRowIndex = saveRow;

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            InfoEmployee ae = new InfoEmployee(Convert.ToInt32(this.dgvEmployee.CurrentRow.Cells[0].Value));
            ae.ShowDialog();
            LoadData();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoEmployee ae = new InfoEmployee(Convert.ToInt32(this.dgvEmployee.CurrentRow.Cells[0].Value));
            ae.ShowDialog();
            LoadData();
        }

        private void Search(object sender, KeyPressEventArgs e)
        {
            if(tbSearch.Text.Trim().Length <1)
            {
                dgvEmployee.DataSource = db.Pracownicy.ToList();
            }
            else
            {
                dgvEmployee.DataSource = (from db in db.Pracownicy
                                          where
               db.Imie.Contains(tbSearch.Text.Trim()) ||
               db.Nazwisko.Contains(tbSearch.Text.Trim()) ||
               db.NumerTelefonu.Contains(tbSearch.Text.Trim()) ||
               db.Email.Contains(tbSearch.Text.Trim())
                                          select db).ToList();
            }
        }
    }
}
