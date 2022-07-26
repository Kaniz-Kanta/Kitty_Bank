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
    public partial class EmployeeAccessForm : Form
    {
        public static string Email;
        public static int Value;
      
        public EmployeeAccessForm()
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

        private void AddAccountbutton_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            this.Hide();
            addAccount.Show();
        }

        private void UpdateAccountbutton_Click(object sender, EventArgs e)
        {
            UpdateAccount updateAccount = new UpdateAccount();
            this.Hide();
            updateAccount.Show();
        }

        private void DeleteAccountbutton_Click(object sender, EventArgs e)
        {
            DeleteAccount deleteAccount = new DeleteAccount();
            this.Hide();
            deleteAccount.Show();
        }

        private void ShowAccountByBranchNamebutton_Click(object sender, EventArgs e)
        {
            ShowAccountByBranchName showAccountByBranchName = new ShowAccountByBranchName(Email,Value);
            this.Hide();
            showAccountByBranchName.Show();
        }

        private void ShowLoanByBranchNamebutton_Click(object sender, EventArgs e)
        {
            ShowLoansByBranchName showLoansByBranchName = new ShowLoansByBranchName();
            this.Hide();
            showLoansByBranchName.Show();
        }

        private void ShowTransactionsByBranchNamebutton_Click(object sender, EventArgs e)
        {
            ShowTransactionByBranchName showTransactionByBranchName = new ShowTransactionByBranchName(Email, Value);
            this.Hide();
            showTransactionByBranchName.Show();
        }

        private void Depositbutton_Click(object sender, EventArgs e)
        {
            Deposite deposite = new Deposite();
            this.Hide();
            deposite.Show();
        }

        private void Withdrawbutton_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            this.Hide();
            withdraw.Show();
        }

        private void Transferbutton_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer();
            this.Hide();
            transfer.Show();
        }

        private void AddLoanbutton_Click(object sender, EventArgs e)
        {
            AddLoan addLoan = new AddLoan();
            this.Hide();
            addLoan.Show();
        }

        private void DepositLoanbutton_Click(object sender, EventArgs e)
        {
            DepositeLoan depositeLoan = new DepositeLoan();
            this.Hide();
            depositeLoan.Show();
        }

        private void DeleteLoanbutton_Click(object sender, EventArgs e)
        {
            DeleteLoan deleteLoan = new DeleteLoan();
            this.Hide();
            deleteLoan.Show();
        }

        private void EmployeeInformationbutton_Click(object sender, EventArgs e)
        {
            ShowEmployeeByEmployeeId showEmployeeByEmployeeId = new ShowEmployeeByEmployeeId();
            this.Hide();
            showEmployeeByEmployeeId.Show();
        }

        private void UserInformationbutton_Click(object sender, EventArgs e)
        {
            ShowUserOwn showUserOwn = new ShowUserOwn(Email,Value);
            this.Hide();
            showUserOwn.Show();
        }

        private void UpdateUserbutton_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser(Email, Value);
            this.Hide();
            updateUser.Show();
        }

        private void DeleteTransactionbutton_Click(object sender, EventArgs e)
        {
            DeleteTransaction deleteTransaction = new DeleteTransaction();
            this.Hide();
            deleteTransaction.Show();
        }
    }
}
