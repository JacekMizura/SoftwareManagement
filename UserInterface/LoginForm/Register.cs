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
                var user = db.UserList.FirstOrDefault(a => a.UserID == id);
                user.UserName = tbUsername.Text.Trim();
                user.Name = tbName.Text.Trim();
                user.LastName = tbLastName.Text.Trim();
                user.Password = tbPassword.Text.Trim();
                user.Role = comboBox1.Text.Trim();
                db.SaveChanges();
            }
            else
            {
                db.UserList.Add(new User { UserName = tbUsername.Text.Trim(), Name = tbName.Text.Trim(), LastName = tbLastName.Text.Trim(), Password = tbPassword.Text.Trim(), Role = comboBox1.Text.Trim() });
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
                var user = db.UserList.FirstOrDefault(a => a.UserID == id);
                if (user != null)
                {
                    tbUsername.Text = user.UserName;
                    tbName.Text = user.Name;
                    tbLastName.Text = user.LastName;
                    tbPassword.Text = user.Password;
                    comboBox1.Text = user.Role.ToString();
                }
            }
        }
    }
        
}
