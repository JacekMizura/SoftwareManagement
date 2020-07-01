using SoftwareManagement.Database;
using SoftwareManagement.Models;
using SoftwareManagement.Resources;
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
    public partial class MainEmployee : Form
    {
        Employee model = new Employee();
        public MainEmployee()
        {
            InitializeComponent();
        }


        private void MainEmployee_Load(object sender, EventArgs e)
        {
            dgvEmployee.FirstDisplayedCell = null;
            dgvEmployee.ClearSelection();
            LoadTheme();

            LoadData();
      
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
       
        }

            private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee frm = new AddEmployee();
            frm.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            if(dgvEmployee.CurrentRow.Index != -1)
            {
                model.EmpId = Convert.ToInt32(dgvEmployee.CurrentRow.Cells["dgvEmpId"].Value);
                using(ModelContext db = new ModelContext())
                {
                    model = db.EmployeeList.Where(x => x.EmpId == model.EmpId).FirstOrDefault();
                    ae.tbName.Text = model.FirstName;
                    ae.tbLastName.Text = model.LastName;
                    ae.tbEmail.Text = model.Email;
                    ae.tbPhoneNumber.Text = model.PhoneNumber;
                    ae.tbSalary.Text = model.Salary;
                  
                }
                LoadData();
                ae.ShowDialog();
            }
        }

        void LoadData()
        {
            using (ModelContext db = new ModelContext())
            {
                employeeBindingSource.DataSource = db.EmployeeList.ToList();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Jesteś pewien że chcesz usunąć te dane","Message", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                using(ModelContext db = new ModelContext())
                {

                    Employee employee = employeeBindingSource.Current as Employee;
                    if(employee != null)
                    {
                        if (db.Entry<Employee>(employee).State == EntityState.Detached)
                            db.Set<Employee>().Attach(employee);
                        db.Entry<Employee>(employee).State = EntityState.Deleted;
                        db.SaveChanges();
                        employeeBindingSource.RemoveCurrent();
                        
                    }
                    MessageBox.Show("Pomyślnie usunięto dane");
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvEmployee.Refresh();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            EmailForm ef = new EmailForm();
            ef.ShowDialog();
        }
    }
}
