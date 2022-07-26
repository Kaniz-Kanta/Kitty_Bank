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
    public partial class AdminAccessForm : Form
    {
        public static string Email;
        public static int Value;
        public AdminAccessForm()
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

        private void AddEmployeebutton_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            this.Hide();
            addEmployee.Show();
        }

        private void UpdateEmployeebutton_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmployee = new UpdateEmployee();
            this.Hide();
            updateEmployee.Show();
        }

        private void DeleteEmployeebutton_Click(object sender, EventArgs e)
        {
            DeleteEmployee deleteEmployee = new DeleteEmployee();
            this.Hide();
            deleteEmployee.Show();
        }

        private void ShowAllEmployeesbutton_Click(object sender, EventArgs e)
        {
            ShowAllEmployees showAllEmployees = new ShowAllEmployees();
            this.Hide();
            showAllEmployees.Show();
        }

        private void ShowEmployeesByBranchNamebutton_Click(object sender, EventArgs e)
        {
            ShowEmployeeByBranchName showEmployeeByBranchName = new ShowEmployeeByBranchName();
            this.Hide();
            showEmployeeByBranchName.Show();
        }

        private void ShowEmployeesByDesignationbutton_Click(object sender, EventArgs e)
        {
            ShowEmployeeByDesignation showEmployeeByDesignation = new ShowEmployeeByDesignation();
            this.Hide();
            showEmployeeByDesignation.Show();
        }

        private void AllAccountsbutton_Click(object sender, EventArgs e)
        {
            ShowAllAccounts showAllAccounts = new ShowAllAccounts();
            this.Hide();
            showAllAccounts.Show();
        }
        private void AllTransactionsbutton_Click(object sender, EventArgs e)
        {
            ShowAllTransaction showAllTransaction = new ShowAllTransaction();
            this.Hide();
            showAllTransaction.Show();
        }

        private void TransactionByDatebutton_Click(object sender, EventArgs e)
        {
            ShowTransactionByTransactionDate showTransaction = new ShowTransactionByTransactionDate();
            this.Hide();
            showTransaction.Show();
        }

        private void AllLoansbutton_Click(object sender, EventArgs e)
        {
            ShowAllLoans showAllLoans = new ShowAllLoans();
            this.Hide();
            showAllLoans.Show();
        }

        private void AllUsersbutton_Click(object sender, EventArgs e)
        {
            ShowAllUser showAllUser = new ShowAllUser();
            this.Hide();
            showAllUser.Show();
        }

        private void UserInformationbutton_Click(object sender, EventArgs e)
        {
            ShowUserOwn showUserOwn = new ShowUserOwn(Email,Value);
            this.Hide();
            showUserOwn.Show();
        }

        private void UpdateUserbutton_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser(Email,Value);
            this.Hide();
            updateUser.Show();
        }

        private void DeleteUserbutton_Click(object sender, EventArgs e)
        {
            DeleteUser deleteUser = new DeleteUser();
            this.Hide();
            deleteUser.Show();
        }

        private void AccountsByAccountTypebutton_Click(object sender, EventArgs e)
        {
            ShowAccountByAccountType showAccountByAccountType = new ShowAccountByAccountType();
            this.Hide();
            showAccountByAccountType.Show();
        }

        private void AccountByBranchbutton_Click(object sender, EventArgs e)
        {
            ShowAccountByBranchName showAccountByBranchName = new ShowAccountByBranchName(Email, Value);
            this.Hide();
            showAccountByBranchName.Show();
        }

        private void TransactionByBranchbutton_Click(object sender, EventArgs e)
        {
            ShowTransactionByBranchName showTransactionByBranchName = new ShowTransactionByBranchName(Email, Value);
            this.Hide();
            showTransactionByBranchName.Show();
        }
    }
}
