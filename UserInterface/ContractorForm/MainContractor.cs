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

namespace SoftwareManagement.UserInterface.ContractorForm
{
    public partial class MainContractor : Form
    {
        public MainContractor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddContractor ac = new AddContractor();
            ac.ShowDialog();
        }
        void LoadData()
        {
            using (ModelContext db = new ModelContext())
            {
                contractorBindingSource1.DataSource = db.ContractorList.ToList();
            }
        }

        private void MainContractor_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
