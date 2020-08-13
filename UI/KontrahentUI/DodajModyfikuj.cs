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
        static int id;
        public AddContractor(int rekordId)
        {
            InitializeComponent();
            tbNIP.MaxLength = 10;
            id = rekordId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                var kontrahent = db.Kontrahenci.FirstOrDefault(a => a.KontrahentID == id);
                kontrahent.Imie = tbName.Text.Trim();
                kontrahent.Naziwsko = tbLastName.Text.Trim();
                kontrahent.Email = tbEmail.Text.Trim();
                kontrahent.NumerTelefonu = tbPhoneNumber.Text.Trim();
                var adres = db.Adresy.FirstOrDefault(ad => ad.AdresID == id);
                adres.Ulica = tbStreet.Text.Trim();
                adres.Miasto = tbCity.Text.Trim();
                adres.KodPocztowy = Convert.ToInt32(tbPostCode.Text.Trim());
                adres.NumerDomu = tbHomeNr.Text.Trim();
                adres.NumerMieszkania = tbFlatNr.Text.Trim();
                db.SaveChanges();
            }
            else
            {
                db.Kontrahenci.Add(new Kontrahent 
                { 
                    Nazwa = tbName.Text.Trim(), 
                    Imie = tbFirstName.Text.Trim(), 
                    Naziwsko = tbLastName.Text.Trim(), 
                    Email = tbEmail.Text.Trim(), 
                    NumerTelefonu = tbPhoneNumber.Text.Trim() 
                });
                db.Adresy.Add(new Adres 
                { 
                    Ulica = tbStreet.Text.Trim(), 
                    NumerDomu = tbHomeNr.Text.Trim(), 
                    NumerMieszkania = tbFlatNr.Text.Trim(), 
                    KodPocztowy = Convert.ToInt32(tbPostCode.Text.Trim()),
                    Miasto = tbCity.Text.Trim() 
                });
                db.SaveChanges();
            }
            MessageBox.Show("Pomyślnie dodano pracownika");
            Close();
        }

    private void AddContractor_Load(object sender, EventArgs e)
            {
            if (id > 0)
            {
                var kontrahent = db.Kontrahenci.FirstOrDefault(a => a.KontrahentID == id);
                var adres = db.Adresy.FirstOrDefault(ad => ad.AdresID == id);
                if (kontrahent != null && adres != null)
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

