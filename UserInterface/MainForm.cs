using SoftwareManagement.Models;
using SoftwareManagement.Resources;
using SoftwareManagement.UserInterface.ContractorForm;
using SoftwareManagement.UserInterface.EmployeeForm;
using SoftwareManagement.UserInterface.LoginForm;
using SoftwareManagement.UserInterface.OrderForm;
using SoftwareManagement.UserInterface.ProductForm;
using SoftwareManagement.UserInterface.SettingForm;
using SoftwareManagement.UserInterface.WarehouseForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SoftwareManagement.UserInterface
{

    public partial class MainForm : Form
    {
        public string currentUser = Login.UserInformation.CurrentLoggedInUser;
        private Button currentButton;
        private Form activeForm;
        private Random random;
        private int tempIndex;

        public MainForm()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainProduct(), sender);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainEmployee(), sender);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainOrders(), sender);
        }

        private void btnContractor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainContractor(), sender);
        }
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseChildForm_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SettingMain(), sender);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainWarehouse(), sender);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tsslUsername.Text = currentUser;
        }
    }
}
