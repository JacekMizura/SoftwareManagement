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
        public AddEmployee()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            using(ModelContext db = new ModelContext())
            {
                Employee model = employeeBindingSource.Current as Employee;
                if(model != null)
                {
                    if (model.EmpId == 0)
                        db.Entry<Employee>(model).State = System.Data.Entity.EntityState.Added;
                    else
                        db.Entry<Employee>(model).State = EntityState.Modified;
                    db.SaveChanges();
                    pContainer.Enabled = false;
                }
            }
            pContainer.Enabled = true;
            employeeBindingSource.Add(new Employee());
            employeeBindingSource.MoveLast();
            tbName.Focus();
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
