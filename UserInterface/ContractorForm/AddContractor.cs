using SoftwareManagement.Database;
using SoftwareManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareManagement.UserInterface.ContractorForm
{
    public partial class AddContractor : Form
    {
        ModelContext db = new ModelContext();

        public AddContractor()
        {
            InitializeComponent();
            tbNIP.MaxLength = 10;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (db = new ModelContext())
            {
                var contractor = new Contractor
                {
                    Name = tbName.Text.ToString(),
                    FirstName = tbFirstName.Text.ToString(),
                    LastName = tbLastName.Text.ToString(),
                    REGON = tbREGON.Text.ToString(),
                    NIP = tbNIP.Text.Length.ToString(),
                    PhoneNumber = tbPhoneNumber.Text.ToString(),
                    Email = tbEmail.Text.ToString(),
                    Addresses = new List<Address>
                    {
                        new Address
                        {
                            Street = tbStreet.Text.ToString(),
                            City = tbCity.Text.ToString(),
                            StreetNumber = tbHomeNr.Text.ToString(),
                            BuildingNumber = tbFlatNr.Text.ToString(),
                            ZipCode = Int32.Parse(tbPostCode.Text),
                        }
                    }
                };
                db.ContractorList.Add(contractor);
                db.SaveChanges();
                Close();
            }
        }

            private void AddContractor_Load(object sender, EventArgs e)
            {

            }
        }
    }

