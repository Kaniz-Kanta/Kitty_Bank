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
    public partial class CustomerAccessForm : Form
    {
        public static string Email;
        public static int Value;
        public CustomerAccessForm()
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

        private void LogOutpictureBox_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.Show();
        }

        private void AccountInformationbutton_Click(object sender, EventArgs e)
        {
            ShowAccountByAccountNumber showAccountByAccountNumber = new ShowAccountByAccountNumber();
            this.Hide();
            showAccountByAccountNumber.Show();

        }

        private void UserInformationbutton_Click(object sender, EventArgs e)
        {
            ShowUserOwn showUserOwn = new ShowUserOwn(Email,Value);
            this.Hide();
            showUserOwn.Show();
        }

        private void LoanInformationbutton_Click(object sender, EventArgs e)
        {
            ShowLoanByAccountNumber showLoanByAccountNumber = new ShowLoanByAccountNumber();
            this.Hide();
            showLoanByAccountNumber.Show();
        }

        private void UpdateUserbutton_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser(Email,Value);
            this.Hide();
            updateUser.Show();
        }

        private void Transactionsbutton_Click(object sender, EventArgs e)
        {
            ShowTransactionByAccountNumber showTransactionByAccountNumber = new ShowTransactionByAccountNumber();
            this.Hide();
            showTransactionByAccountNumber.Show();
        }
    }
}
