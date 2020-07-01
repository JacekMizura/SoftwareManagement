using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareManagement.UserInterface.EmployeeForm
{
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            MailMessage mm = new MailMessage("jmizurka@gmail.com", tbTo.Text);
            mm.Subject = tbSubject.Text;
            mm.Body = tbText.Text;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            NetworkCredential nc = new NetworkCredential("jmizurka@gmail.com", "nowehaslo1234");
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Send(mm);
            MessageBox.Show("Pomyślnie wysłano e-mail");
            Close();
        }
    }
}
