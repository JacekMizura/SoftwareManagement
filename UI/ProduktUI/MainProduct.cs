using SoftwareManagement.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareManagement.UserInterface.ProductForm
{
    public partial class MainProduct : Form
    {
        ModelContext db = new ModelContext();
        public MainProduct()
        {
            InitializeComponent();
            dgvProduct.FirstDisplayedCell = null;
            dgvProduct.ClearSelection();

            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdateForm auf = new AddUpdateForm(0);
            auf.ShowDialog();
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddUpdateForm auf = new AddUpdateForm(Convert.ToInt32(this.dgvProduct.CurrentRow.Cells[0].Value));
            auf.ShowDialog();
            LoadData();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            InfoProduct auf = new InfoProduct(Convert.ToInt32(this.dgvProduct.CurrentRow.Cells[0].Value));
            auf.ShowDialog();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void MainProduct_Load(object sender, EventArgs e)
        {

        }

       
        private void Search(object sender, KeyPressEventArgs e)
        {
            if (tbSearch.Text.Trim().Length < 1)
            {
                dgvProduct.DataSource = db.Produkty.ToList();
            }
            else
            {
                dgvProduct.DataSource = (from db in db.Produkty
                                          where
               db.Nazwa.Contains(tbSearch.Text.Trim()) ||
               db.Kod.ToString().Contains(tbSearch.Text.Trim()) ||
               db.Cena.ToString().Contains(tbSearch.Text.Trim())
                                          select db).ToList();
            }
        }
        void LoadData()
        {
            int saveRow = 0;
            if (dgvProduct.Rows.Count > 0)
                saveRow = dgvProduct.FirstDisplayedCell.RowIndex;
            ModelContext db = new ModelContext();
            dgvProduct.DataSource = db.Produkty.ToList();
            if (saveRow != 0 && saveRow < dgvProduct.Rows.Count)
                dgvProduct.FirstDisplayedScrollingRowIndex = saveRow;


        }
        void Delete()
        {
            if (MessageBox.Show("Jesteś pewien że chcesz usunąć te dane", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int productId = Convert.ToInt32(this.dgvProduct.CurrentRow.Cells[0].Value);
                var product = db.Produkty.FirstOrDefault(a => a.ProduktID == productId);
                db.Produkty.Remove(product);
                db.SaveChanges();
                LoadData();
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
