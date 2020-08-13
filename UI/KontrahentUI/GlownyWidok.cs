using SoftwareManagement.Database;
using SoftwareManagement.Models;
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

namespace SoftwareManagement.UserInterface.ContractorForm
{
    public partial class MainContractor : Form
    {
        ModelContext db = new ModelContext();
        public MainContractor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddContractor ac = new AddContractor(0);
            ac.ShowDialog();
            LoadData();
        }
        void LoadData()
        {
            int saveRow = 0;
            if (dgvContractor.Rows.Count > 0)
                saveRow = dgvContractor.FirstDisplayedCell.RowIndex;
            ModelContext db = new ModelContext();
            dgvContractor.DataSource = db.Kontrahenci.ToList();
            if (saveRow != 0 && saveRow < dgvContractor.Rows.Count)
                dgvContractor.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void MainContractor_Load(object sender, EventArgs e)
        {
            dgvContractor.FirstDisplayedCell = null;
            dgvContractor.ClearSelection();
            LoadData();
        }



        private void Search(object sender, EventArgs e)
        {
            if (tbSearch.Text.Trim().Length < 1)
            {
                dgvContractor.DataSource = db.Kontrahenci.ToList();
            }
            else
            {
                dgvContractor.DataSource = (from db in db.Kontrahenci
                                         where
              db.Nazwa.Contains(tbSearch.Text.Trim()) ||
              db.NIP.ToString().Contains(tbSearch.Text.Trim()) ||
              db.NumerTelefonu.ToString().Contains(tbSearch.Text.Trim())
                                         select db).ToList();
            }
        }

        void Delete()
        {
            if (MessageBox.Show("Jesteś pewien że chcesz usunąć te dane", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int kontrahentId = Convert.ToInt32(this.dgvContractor.CurrentRow.Cells[0].Value);
                var kontrahent = db.Kontrahenci.FirstOrDefault(a => a.KontrahentID == kontrahentId);
                db.Kontrahenci.Remove(kontrahent);
                db.SaveChanges();
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            InfoUpdateContractor ae = new InfoUpdateContractor(Convert.ToInt32(this.dgvContractor.CurrentRow.Cells[0].Value));
            ae.ShowDialog();
            LoadData();
        }

        private void dgvContractor_CellClick(object sender, DataGridViewCellEventArgs e)
        {

               
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddContractor ae = new AddContractor(Convert.ToInt32(this.dgvContractor.CurrentRow.Cells[0].Value));
            ae.ShowDialog();
            LoadData();
        }
    }
}
