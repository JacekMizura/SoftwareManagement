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


        static int id;
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
                var pType = new ProductType() { Name = tbProductType.Text.Trim() };
                db.ProductTypeList.Add(pType);
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
            dgvProductTypeList.DataSource = db.ProductTypeList.ToList();
            if (saveRow != 0 && saveRow < dgvProductTypeList.Rows.Count)
                dgvProductTypeList.FirstDisplayedScrollingRowIndex = saveRow;

            if (dgvUser.Rows.Count > 0)
                saveRow = dgvUser.FirstDisplayedCell.RowIndex;
            dgvUser.DataSource = db.UserList.ToList();
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
                var user = db.UserList.FirstOrDefault(a => a.UserID == userId);
                db.UserList.Remove(user);
                db.SaveChanges();
                LoadData();
            }
        }

    }
}
