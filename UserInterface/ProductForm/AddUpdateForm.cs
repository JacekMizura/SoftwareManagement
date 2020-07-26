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
    public partial class AddUpdateForm : Form
    {
        ModelContext db = new ModelContext();
        
        static int id;
        public AddUpdateForm(int recordId)
        {
            InitializeComponent();
            id = recordId;
            FillCombobox();
            
        }

        private void AddUpdateForm_Load(object sender, EventArgs e)
        {
            FillCombobox();

            if (id > 0)
            {
                var product = db.ProductList.FirstOrDefault(a => a.ProductID == id);
                if (product != null)
                {
                    tbName.Text = product.Name;
                    tbCode.Text = product.Code.ToString();
                    tbPrice.Text = product.Price.ToString();
                    
                    
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                
                var product = db.ProductList.FirstOrDefault(a => a.ProductID == id);
                product.Name = tbName.Text.Trim();
                product.Code = Int32.Parse(tbCode.Text.Trim());
                product.Price = Int32.Parse(tbPrice.Text.Trim());

                db.SaveChanges();
            }
            else
            {
                db.ProductList.Add(new Product { Name = tbName.Text.Trim(), Code = Int32.Parse(tbCode.Text.Trim()), Price = Int32.Parse(tbPrice.Text.Trim()) });
                db.SaveChanges();
            }
            MessageBox.Show("Pomyślnie dodano produkt");
            Close();
        }

        public void FillCombobox()
        {
            using (ModelContext db = new ModelContext())
            {
                cbType.DataSource = db.ProductTypeList.ToList();
                cbType.DisplayMember = "Name";
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {

        }
    }
}
