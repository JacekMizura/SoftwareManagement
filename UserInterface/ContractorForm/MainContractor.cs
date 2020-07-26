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
            AddContractor ac = new AddContractor();
            ac.ShowDialog();
            LoadData();
        }
        void LoadData()
        {
            int saveRow = 0;
            if (dgvContractor.Rows.Count > 0)
                saveRow = dgvContractor.FirstDisplayedCell.RowIndex;
            ModelContext db = new ModelContext();
            dgvContractor.DataSource = db.ContractorList.ToList();
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
                dgvContractor.DataSource = db.ContractorList.ToList();
            }
            else
            {
                dgvContractor.DataSource = (from db in db.ContractorList
                                         where
              db.Name.Contains(tbSearch.Text.Trim()) ||
              db.NIP.ToString().Contains(tbSearch.Text.Trim()) ||
              db.PhoneNumber.ToString().Contains(tbSearch.Text.Trim())
                                         select db).ToList();
            }
        }

        void Delete()
        {
            if (MessageBox.Show("Jesteś pewien że chcesz usunąć te dane", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int contractorId = Convert.ToInt32(this.dgvContractor.CurrentRow.Cells[0].Value);
                var contractor = db.ContractorList.FirstOrDefault(a => a.ContractorID == contractorId);
                db.ContractorList.Remove(contractor);
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
            InfoUpdateContractor ae = new InfoUpdateContractor();
            ae.ShowDialog();
            LoadData();
        }

        private void dgvContractor_CellClick(object sender, DataGridViewCellEventArgs e)
        {

               
        }
    }
}
