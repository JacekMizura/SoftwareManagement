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
        Employee employee = new Employee();
        public AddEmployee()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            employee.FirstName = tbName.Text.Trim();
            employee.LastName = tbLastName.Text.Trim();
            employee.Salary = Int32.Parse(tbSalary.Text.Trim());
            employee.PhoneNumber = Int32.Parse(tbPhoneNumber.Text.Trim());
            employee.Email = tbEmail.Text.Trim();

            using (ModelContext db = new ModelContext())
            {
                if (employee.EmpId == 0)
                {
                    db.EmployeeList.Add(employee);
                }

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
            using(ModelContext db = new ModelContext())
            {
                employeeBindingSource.DataSource = db.EmployeeList.ToList();

            }
        }
    }
}
