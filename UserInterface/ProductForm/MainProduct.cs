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

namespace SoftwareManagement.UserInterface.ProductForm
{
    public partial class MainProduct : Form
    {
        Product model = new Product();
        public MainProduct()
        {
            InitializeComponent();
        }

        private void MainProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddUpdate au = new AddUpdate();
            au.ShowDialog();
        }
        void LoadData()
        {           
            using (ModelContext db = new ModelContext())
            {
                productBindingSource.DataSource = db.ProductList.ToList();
            }
        }

        private void updateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddUpdate auf = new AddUpdate();
      
                using (ModelContext db = new ModelContext())
                {
                    model = db.ProductList.Where(x => x.ProductID == model.ProductID).FirstOrDefault();
                    auf.tbName.Text = model.Name;
                    auf.tbDate.Text = model.ExpireTime;
                    auf.tbPrice.Text = model.Price;

                }
                LoadData();
                auf.ShowDialog();
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jesteś pewien że chcesz usunąć te dane", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {

                    Product product = productBindingSource.Current as Product;
                    if (product != null)
                    {
                        if (db.Entry<Product>(product).State == EntityState.Detached)
                            db.Set<Product>().Attach(product);
                        db.Entry<Product>(product).State = EntityState.Deleted;
                        db.SaveChanges();
                        productBindingSource.RemoveCurrent();

                    }
                    MessageBox.Show("Pomyślnie usunięto dane");
                }
            }
        }
    }
}
