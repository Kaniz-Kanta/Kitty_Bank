using BankManagementSystem.Business_Logic_Layer;
using System;
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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Minimizelabel1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximizelabel1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void Crosslabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUpbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void LogInbutton_Click(object sender, EventArgs e)
        {
            LogInService logInService = new LogInService();
            int result = logInService.LoginValidation(EmailtextBox.Text, PasswordtextBox.Text, UserTypeComboBox.Text);
            
            if (result == -1)
            {
                MessageBox.Show("Invalid username or password");
            }
            else if(result==1 && UserTypeComboBox.Text=="Admin")
            {
                PasswordtextBox.Text = String.Empty;
                AdminAccessForm adminAccessForm = new AdminAccessForm();
                AdminAccessForm.Email = EmailtextBox.Text;
                AdminAccessForm.Value = 1;
                this.Hide();
                adminAccessForm.Show();
            }
            else if (result == 1 && UserTypeComboBox.Text == "Employee")
            {
                PasswordtextBox.Text = String.Empty;
                EmployeeAccessForm employeeAccessForm = new EmployeeAccessForm();
                EmployeeAccessForm.Email = EmailtextBox.Text;
                EmployeeAccessForm.Value = 2;
                this.Hide();
                employeeAccessForm.Show();
            }
            else if (result == 1 && UserTypeComboBox.Text == "Customer")
            {
                PasswordtextBox.Text = String.Empty;
                CustomerAccessForm customerAccessForm = new CustomerAccessForm();
                CustomerAccessForm.Email = EmailtextBox.Text;
                CustomerAccessForm.Value = 3;
                this.Hide();
                customerAccessForm.Show();
            }
        }

    }
}
