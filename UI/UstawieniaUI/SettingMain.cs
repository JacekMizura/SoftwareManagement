using SoftwareManagement.Database;
using SoftwareManagement.Models;
using SoftwareManagement.UserInterface.LoginForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareManagement.UserInterface.SettingForm
{
    public partial class SettingMain : Form
    {

        ModelContext db = new ModelContext();
        public SettingMain()
        {
            InitializeComponent();
        }

        private void SettingMain_Load(object sender, EventArgs e)
        {
            dgvProductTypeList.FirstDisplayedCell = null;
            dgvProductTypeList.ClearSelection();
            dgvUser.FirstDisplayedCell = null;
            dgvUser.ClearSelection();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var db = new ModelContext())
            {
                var pType = new RodzajProduktu() { Nazwa = tbProductType.Text.Trim() };
                db.RodzajeProduktow.Add(pType);
                MessageBox.Show("Pomyślnie dodano typ produktu");
                db.SaveChanges();
                LoadData();
            }
        }
        void LoadData()
        {
            int saveRow = 0;

            if (dgvProductTypeList.Rows.Count > 0)
                saveRow = dgvProductTypeList.FirstDisplayedCell.RowIndex;
            dgvProductTypeList.DataSource = db.RodzajeProduktow.ToList();
            if (saveRow != 0 && saveRow < dgvProductTypeList.Rows.Count)
                dgvProductTypeList.FirstDisplayedScrollingRowIndex = saveRow;

            if (dgvUser.Rows.Count > 0)
                saveRow = dgvUser.FirstDisplayedCell.RowIndex;
            dgvUser.DataSource = db.Uzytkownicy.ToList();
            if (saveRow != 0 && saveRow < dgvUser.Rows.Count)
                dgvUser.FirstDisplayedScrollingRowIndex = saveRow;



        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Register register = new Register(0);
            register.ShowDialog();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jesteś pewien że chcesz usunąć te dane", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int userId = Convert.ToInt32(this.dgvUser.CurrentRow.Cells[0].Value);
                var user = db.Uzytkownicy.FirstOrDefault(a => a.UzytkownikID == userId);
                db.Uzytkownicy.Remove(user);
                db.SaveChanges();
                LoadData();
            }
        }
    }
}
