using SoftwareManagement.Database;
using SoftwareManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.EntitySql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareManagement.UserInterface.OrderForm
{
    public partial class MainOrders : Form
    {
        ModelContext db = new ModelContext();
        public static int id;
        public MainOrders()
        {

            InitializeComponent();

        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FillCombobox();
        }

        public void FillCombobox()
        {
            using (ModelContext db = new ModelContext())
            {

                cbProductType.DataSource = db.RodzajeProduktow.ToList();
                cbProductType.ValueMember = "Produkt";
                cbProductType.DisplayMember = "Nazwa";

                cbContractor.DataSource = db.Kontrahenci.ToList();
                cbContractor.DisplayMember = "Nazwa";
            }
        }

        

        private void MainOrders_Load(object sender, EventArgs e)
        {
            FillCombobox();
        }

        private void cbProductType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RodzajProduktu obj = cbProductType.SelectedItem as RodzajProduktu;
            if(obj != null)
            {
                try
                {
                    using (ModelContext db = new ModelContext())
                    {
                        var query = from o in db.Produkty
                                    where o.Rodzaj == obj.Nazwa
                                    select o;
                        listBoxProduct.DataSource = query.ToList();
                        listBoxProduct.DisplayMember = "Nazwa";
                       
                    }
                }
                catch(Exception ex)
                {

                }
                
            }
        }


       
        private void listBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

            Produkt obj = listBoxProduct.SelectedItem as Produkt;

            nudQuantity.ResetText();
            txtAmount.Clear();

            String text = listBoxProduct.GetItemText(listBoxProduct.SelectedItem);
            txtName.Text = text;
            if (obj != null)
            {
                var product = (from o in db.Produkty where o.Nazwa == txtName.Text select o).First();
                txtPrice.Text = product.Cena.ToString();
            }

        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            Int64 qud = Int64.Parse(nudQuantity.Value.ToString());
            Int64 price = Int64.Parse(txtPrice.Text);
            txtAmount.Text = (qud * price).ToString();
        }

        protected int n, total = 0;

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                dgvShopOrder.Rows.RemoveAt(this.dgvShopOrder.SelectedRows[0].Index);
            }
            catch { }
            total -= amount;
            lblAmount.Text = "Zł. " + total;
        }
        int amount;
        private void dgvShopOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
                amount = int.Parse(dgvShopOrder.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text != "0" && txtAmount.Text != "")
            {
                n = dgvShopOrder.Rows.Add();
                dgvShopOrder.Rows[n].Cells[0].Value = txtName.Text;
                dgvShopOrder.Rows[n].Cells[1].Value = txtPrice.Text;
                dgvShopOrder.Rows[n].Cells[2].Value = nudQuantity.Text;
                dgvShopOrder.Rows[n].Cells[3].Value = txtAmount.Text;

                total += int.Parse(txtAmount.Text);
                lblAmount.Text = "Zł. " + total;
            }
            else
            {
                MessageBox.Show("Minimalna ilość musi być większa niż 1", "Informacja", MessageBoxButtons.OK);
            }
        }
    }
    }
 
    


