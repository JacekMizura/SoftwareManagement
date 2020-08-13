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
        static int id;
        public InfoUpdateContractor(int recordId)
        {
            InitializeComponent();
            id = recordId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        
        }

        private void InfoUpdateContractor_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                var kontrahent = db.Kontrahenci.FirstOrDefault(a => a.KontrahentID == id);
                var adres = db.Adresy.FirstOrDefault(ad => ad.AdresID == id);
                if (kontrahent != null && adres !=null)
                {
                    tbName.Text = kontrahent.Nazwa;
                    tbFirstName.Text = kontrahent.Imie;
                    tbLastName.Text = kontrahent.Naziwsko;
                    tbEmail.Text = kontrahent.Email;
                    tbPhoneNumber.Text = kontrahent.NumerTelefonu;
                    tbNIP.Text = kontrahent.NIP;
                    tbREGON.Text = kontrahent.REGON;
                    tbStreet.Text = adres.Ulica;
                    tbHomeNr.Text = adres.NumerDomu;
                    tbFlatNr.Text = adres.NumerMieszkania;
                    tbCity.Text = adres.Miasto;
                    tbPostCode.Text = Convert.ToInt32(adres.KodPocztowy).ToString();
                }
            }
        }
    }

    
}
