using System;
using BankManagementSystem.Business_Logic_Layer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem.Presentation_Layer
{
    public partial class ShowUserOwn : Form
    {
        string Email;
        static int Value;
        public ShowUserOwn(string email,int value)
        {
            InitializeComponent();
            Email = email;
            Value = value;
            UserService userService = new UserService();
            UserdataGridView.DataSource = userService.GetUsersByEmail(Email);
        }
        public ShowUserOwn()
        {
            InitializeComponent();
        }

        private void Crosslabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizelabel1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void Minimizelabel1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BackpictureBox_Click(object sender, EventArgs e)
        {
            if(Value == 1)
            {
                AdminAccessForm adminAccessForm = new AdminAccessForm();
                this.Hide();
                adminAccessForm.Show();
            }

            else if (Value == 2)
            {
                EmployeeAccessForm employeeAccessForm = new EmployeeAccessForm();
                this.Hide();
                employeeAccessForm.Show();
            }
            else if (Value == 3)
            {
                CustomerAccessForm customerAccessForm = new CustomerAccessForm();
                this.Hide();
                customerAccessForm.Show();
            }
        }
    }
}
