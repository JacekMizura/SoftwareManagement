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

namespace SoftwareManagement.UserInterface.LoginForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        internal class UserInformation
        {
            public static string CurrentLoggedInUser
            {
                get;
                set;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(cbUser.Text))
            {
                MessageBox.Show("Wybierz użytkownika.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbUser.Focus();
                return;
            }
            try
            {
                using (ModelContext db = new ModelContext())
                {
                    //using linq to query data
                    var query = from o in db.Uzytkownicy
                                where o.NazwaUzytkownika == cbUser.Text && o.Haslo == tbPassword.Text
                                select o;
                    //check if user exists
                    if (query.SingleOrDefault() != null)
                    {
                        UserInformation.CurrentLoggedInUser = cbUser.Text.Trim();
                        MainForm mf = new MainForm();
                        mf.ShowDialog();
                       
                        
                    }
                    else
                    {
                        MessageBox.Show("Złe hasło.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                cbUser.DataSource = db.Uzytkownicy.ToList();
                cbUser.DisplayMember = "NazwaUzytkownika";
                cbUser.Invalidate();
            }
        }
    }
}
