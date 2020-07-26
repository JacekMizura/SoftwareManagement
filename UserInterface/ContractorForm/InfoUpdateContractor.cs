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

namespace SoftwareManagement.UserInterface.ContractorForm
{
    public partial class InfoUpdateContractor : Form
    {
        ModelContext db = new ModelContext();
        public InfoUpdateContractor()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void InfoUpdateContractor_Load(object sender, EventArgs e)
        {
            
        }
    }

    
}
