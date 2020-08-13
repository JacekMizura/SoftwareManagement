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
    public partial class InfoProduct : Form
    {
        ModelContext db = new ModelContext();
        static int id;
        public InfoProduct(int recordId)
        {
            InitializeComponent();
            id = recordId;
        }

        private void InfoProduct_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                var product = db.Produkty.FirstOrDefault(a => a.ProduktID == id);
                if (product != null)
                {
                    tbName.Text = product.Nazwa;
                    tbCode.Text = product.Kod.ToString();
                    tbPrice.Text = product.Cena.ToString();
                    tbValidTime.Text = product.TerminWaznosci;
                    tbType.Text = product.Rodzaj;
                }
            } 
        }
    }
}
