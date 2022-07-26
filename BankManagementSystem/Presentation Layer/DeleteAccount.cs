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
    public partial class DeleteAccount : Form
    {
        public DeleteAccount()
        {
            InitializeComponent();
        }

        private void BackpictureBox_Click(object sender, EventArgs e)
        {
            EmployeeAccessForm employeeAccessForm = new EmployeeAccessForm();
            this.Hide();
            employeeAccessForm.Show();
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

        private void DeleteAccount_Load(object sender, EventArgs e)
        {
            AccountService accountService = new AccountService();
            AccountsdataGridView.DataSource = accountService.GetAllAccounts();
        }
        void UpdateAccountList()
        {
            AccountService accountService = new AccountService();
            AccountsdataGridView.DataSource = accountService.GetAllAccounts();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            AccountService accountService = new AccountService();
            int result = accountService.DeleteAccount(Convert.ToInt32(AccountNumbertextBox.Text));
            if (result > 0)
            {
                MessageBox.Show("Account Deleted SuccessFully!!!");
                UpdateAccountList();
            }
            else
            {
                MessageBox.Show("Delete UnsuccessFull!!!");
            }
        }
    }
}
