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

namespace SoftwareManagement.UserInterface.LoginForm
{
    public partial class Register : Form
    {
        User user = new User();
        public Register()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            user.UserName = tbUsername.Text.Trim();
            user.Name = tbName.Text.Trim();
            user.LastName = tbLastName.Text.Trim();
            user.Password = tbPassword.Text.Trim();
            user.Role = comboBox1.Text.Trim();
            using(ModelContext db = new ModelContext())
            {
                if (user.UserID == 0)
                    db.UserList.Add(user);
                db.SaveChanges();
            }
            NextForm();
            Close();
            
            
           
        }

        private void NextForm()
        {
            Login login = new Login();
            login.ShowDialog();
        }
    }
        
}
