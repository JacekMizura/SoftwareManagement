using SoftwareManagement.Database;
using SoftwareManagement.Models;
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
    public partial class AddUpdate : Form
    {
        Product product = new Product();
        public AddUpdate()
        {
            InitializeComponent();
        }

        private void AddUpdate_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            product.Name = tbName.Text.Trim();
            product.Price = tbPrice.Text.Trim();
            product.Code = Int32.Parse(tbCode.Text.Trim());
            product.ExpireTime = tbDate.Text.Trim();

            using (ModelContext db = new ModelContext())
            {
                if (product.ProductID == 0)
                    db.ProductList.Add(product);
                db.SaveChanges();
                

            }
            MessageBox.Show("Pomyślnie dodano produkt");
            Close();
            

        }

        void PopDataGridView()
        {
            using (ModelContext db = new ModelContext())
            {
                productBindingSource.DataSource = db.ProductList.ToList<Product>();
            }
        }
        void Clear()
        {
            tbName.Text = tbPrice.Text = tbDate.Text = tbCode.Text = "";
            btnSave.Text = "Zapisz";
            product.ProductID = 0;
        }
    }
}
