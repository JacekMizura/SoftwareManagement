using SoftwareManagement.Database;
using SoftwareManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareManagement.UserInterface.EmployeeForm
{
    public partial class AddEmployee : Form 
    {
        ModelContext db = new ModelContext();
        static int id;
        public AddEmployee(int recordId)
        {
            InitializeComponent();
            id = recordId;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(id>0)
            {
                var pracownik = db.Pracownicy.FirstOrDefault(a => a.PracownikID == id);
                pracownik.Imie = tbName.Text.Trim();
                pracownik.Nazwisko = tbLastName.Text.Trim();
                pracownik.Email = tbEmail.Text.Trim();
                pracownik.NumerTelefonu = tbPhoneNumber.Text.Trim();
                pracownik.Wynagrodzenie = Int32.Parse(tbSalary.Text.Trim());
                db.SaveChanges();
            }
            else
            {
                db.Pracownicy.Add(new Pracownik
                { 
                    Imie = tbName.Text.Trim(),
                    Nazwisko = tbLastName.Text.Trim(),
                    Email = tbEmail.Text.Trim(),
                    NumerTelefonu = tbPhoneNumber.Text.Trim(),
                    Wynagrodzenie = Int32.Parse(tbSalary.Text.Trim()) 
                });
                db.SaveChanges();
            }
            MessageBox.Show("Pomyślnie dodano pracownika");
            Close();
        }
            private void btnCancel_Click(object sender, EventArgs e)
        {
           
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                var pracownik = db.Pracownicy.FirstOrDefault(a => a.PracownikID == id);
                if (pracownik != null)
                {
                    tbName.Text = pracownik.Imie;
                    tbLastName.Text = pracownik.Nazwisko;
                    tbEmail.Text = pracownik.Email;
                    tbPhoneNumber.Text = pracownik.NumerTelefonu;
                    tbSalary.Text = pracownik.Wynagrodzenie.ToString();
                }
            }
        }
    }
}
