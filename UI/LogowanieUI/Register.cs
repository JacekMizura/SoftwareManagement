using SoftwareManagement.Database;
using SoftwareManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareManagement.UserInterface.LoginForm
{
    public partial class Register : Form
    {
        ModelContext db = new ModelContext();
        static int id;
        public Register(int recordId)
        {
            InitializeComponent();
            id = recordId;

        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                var user = db.Uzytkownicy.FirstOrDefault(a => a.UzytkownikID == id);
                user.NazwaUzytkownika = tbUsername.Text.Trim();
                user.Imie = tbName.Text.Trim();
                user.Nazwisko = tbLastName.Text.Trim();
                user.Haslo = tbPassword.Text.Trim();
                user.Rola = comboBox1.Text.Trim();
                db.SaveChanges();
            }
            else
            {
                db.Uzytkownicy.Add(new Uzytkownik { NazwaUzytkownika = tbUsername.Text.Trim(), Imie = tbName.Text.Trim(), Nazwisko = tbLastName.Text.Trim(), Haslo = tbPassword.Text.Trim(), Rola = comboBox1.Text.Trim() });
                db.SaveChanges();
            }
            MessageBox.Show("Pomyślnie dodano pracownika");
            Close();
            }
    


        private void NextForm()
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                var uzytkownik = db.Uzytkownicy.FirstOrDefault(a => a.UzytkownikID == id);
                if (uzytkownik != null)
                {
                    tbUsername.Text = uzytkownik.NazwaUzytkownika;
                    tbName.Text = uzytkownik.Imie;
                    tbLastName.Text = uzytkownik.Nazwisko;
                    tbPassword.Text = uzytkownik.Haslo;
                    comboBox1.Text = uzytkownik.Rola.ToString();
                }
            }
        }
    }
        
}
