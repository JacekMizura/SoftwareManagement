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
                var product = db.ProductList.FirstOrDefault(a => a.ProductID == id);
                if (product != null)
                {
                    tbName.Text = product.Name;
                    tbCode.Text = product.Code.ToString();
                    tbPrice.Text = product.Price.ToString();
                }
            }
        }
    }
}
