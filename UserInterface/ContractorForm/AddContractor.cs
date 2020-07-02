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
    public partial class AddContractor : Form
    {
        Contractor contractor = new Contractor();
        public AddContractor()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            contractor.FirstName = tbFirstName.Text.Trim();
            contractor.LastName = tbLastName.Text.Trim();
            contractor.Email = tbEmail.Text.Trim();
            contractor.Name = tbName.Text.Trim();
            contractor.PhoneNumber = Int32.Parse(tbPhoneNumber.Text.Trim());
            contractor.NIP = Int32.Parse(tbNIP.Text.Trim());

            using (ModelContext db = new ModelContext())
            {
                if (contractor.ContractorID == 0)
                    db.ContractorList.Add(contractor);
                db.SaveChanges();

    }
            MessageBox.Show("Pomyślnie dodano kontrahenta");
            Close();
        }
    }
}
