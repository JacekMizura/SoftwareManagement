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
                var employee = db.EmployeeList.FirstOrDefault(a => a.EmpID == id);
                employee.FirstName = tbName.Text.Trim();
                employee.LastName = tbLastName.Text.Trim();
                employee.Email = tbEmail.Text.Trim();
                employee.PhoneNumber = tbPhoneNumber.Text.Trim();
                employee.Salary = Int32.Parse(tbSalary.Text.Trim());
                db.SaveChanges();
            }
            else
            {
                db.EmployeeList.Add(new Employee { FirstName = tbName.Text.Trim(), LastName = tbLastName.Text.Trim(), Email = tbEmail.Text.Trim(), PhoneNumber = tbPhoneNumber.Text.Trim(), Salary = Int32.Parse(tbSalary.Text.Trim()) });
                db.SaveChanges();
            }
            MessageBox.Show("Pomyślnie dodano pracownika");
            Close();
        }
            private void btnCancel_Click(object sender, EventArgs e)
        {
            employeeBindingSource.ResetBindings(false);
            AddEmployee_Load(sender, e);
            Close();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                var employee = db.EmployeeList.FirstOrDefault(a => a.EmpID == id);
                if (employee != null)
                {
                    tbName.Text = employee.FirstName;
                    tbLastName.Text = employee.LastName;
                    tbEmail.Text = employee.Email;
                    tbPhoneNumber.Text = employee.PhoneNumber;
                    tbSalary.Text = employee.Salary.ToString();
                }
            }
        }
    }
}
