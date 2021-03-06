﻿using SoftwareManagement.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareManagement.UserInterface.EmployeeForm
{
    public partial class InfoEmployee : Form
    {
        ModelContext db = new ModelContext();
        static int id;
        public InfoEmployee(int recordId)
        {
            InitializeComponent();
            id = recordId;
        }

        private void InfoEmployee_Load(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
