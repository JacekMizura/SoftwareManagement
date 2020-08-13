using SoftwareManagement.Database;
using SoftwareManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Configuration;
using System.Drawing.Imaging;
using System.IO;
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
        string fileName;
        public AddUpdateForm(int recordId)
        {
            InitializeComponent();
            id = recordId;
            FillCombobox();
            
        }

        private void AddUpdateForm_Load(object sender, EventArgs e)
        {
           

            if (id > 0)
            {
                var product = db.Produkty.FirstOrDefault(a => a.ProduktID == id);
                if (product != null)
                {
                    tbName.Text = product.Nazwa;
                    tbCode.Text = product.Kod.ToString();
                    tbPrice.Text = product.Cena.ToString();
                    tbValidity.Text = product.TerminWaznosci;
                    cbType.SelectedText = product.Rodzaj;
                    tbAmount.Text = product.Ilosc;
                    
                    
                }
            }
            FillCombobox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CreateProduct();
           
            MessageBox.Show("Pomyślnie dodano produkt");
            Close();
        }

        public void FillCombobox()
        {
            using (ModelContext db = new ModelContext())
            {
                var type = (from o in db.RodzajeProduktow select o.Nazwa).ToList();
                List < RodzajProduktu > pType = db.RodzajeProduktow.ToList();
                cbType.DataSource = type;
                cbType.DisplayMember = "Nazwa";
                
            }
        }

        public void CreateProduct()
        {
            var product = new Produkt
            {
                Nazwa = tbName.Text,
                Kod = Int32.Parse(tbCode.Text),
                Cena = Int32.Parse(tbPrice.Text),
                TerminWaznosci = tbValidity.Text,
                Ilosc = tbAmount.Text,
                Rodzaj = cbType.SelectedItem.ToString()

            };
            db.Produkty.Add(product);
            db.SaveChanges();

        }
    }
}
