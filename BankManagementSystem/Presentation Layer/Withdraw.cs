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
    public partial class Withdraw : Form
    {
        public Withdraw()
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
            EmployeeAccessForm employeeAccessForm = new EmployeeAccessForm();
            this.Hide();
            employeeAccessForm.Show();
        }
        void UpdateAccountList(int accountNumber)
        {
            AccountService accountService = new AccountService();
            AccountsdataGridView.DataSource = accountService.GetAccountByAccountNumber(accountNumber);
        }
        private void SearchpictureBox_Click(object sender, EventArgs e)
        {
            AccountService accountService = new AccountService();
            AccountsdataGridView.DataSource = accountService.GetAccountByAccountNumber(Convert.ToInt32(AccountNumbertextBox.Text));
        }

        private void AccountsdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AccountsdataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                AccountTypecomboBox.Text = AccountsdataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                CurrentBalancetextBox.Text = AccountsdataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void WithDrawbutton_Click(object sender, EventArgs e)
        {
            TransactionService transactionService = new TransactionService();
            AccountService accountService = new AccountService();
            float balance = Convert.ToSingle(CurrentBalancetextBox.Text) - Convert.ToSingle(AmounttextBox.Text);

            if (AccountTypecomboBox.Text == "Savings Account" && balance> 500 && Convert.ToSingle(AmounttextBox.Text)>0 )
            {
                int result1 = accountService.UpdateBalance(Convert.ToInt32(AccountNumbertextBox.Text), balance);
                int result = transactionService.AddTransaction(Withdrawlabel.Text, Convert.ToSingle(AmounttextBox.Text), TransactionDateTimePicker.Text, BranchNamecomboBox.Text, AccountTypecomboBox.Text, Convert.ToInt32(AccountNumbertextBox.Text));               
                if (result1 > 0 && result>0)
                {
                    MessageBox.Show("Transaction Completed Successfully!!!");
                    UpdateAccountList(Convert.ToInt32(AccountNumbertextBox.Text));
                }
                else
                {
                    MessageBox.Show("Transaction UnsuccessFull!!!");
                }
            }
            else if(AccountTypecomboBox.Text == "Checking Account" && balance > 100 && Convert.ToSingle(AmounttextBox.Text)>0)
            {
                int result1 = accountService.UpdateBalance(Convert.ToInt32(AccountNumbertextBox.Text), balance);
                int result = transactionService.AddTransaction(Withdrawlabel.Text, Convert.ToSingle(AmounttextBox.Text), TransactionDateTimePicker.Text, BranchNamecomboBox.Text, AccountTypecomboBox.Text, Convert.ToInt32(AccountNumbertextBox.Text));
                if (result1 > 0 && result > 0)
                {
                    MessageBox.Show("Transaction Completed Successfully!!!");
                    UpdateAccountList(Convert.ToInt32(AccountNumbertextBox.Text));
                }
                else
                {
                    MessageBox.Show("Transaction UnsuccessFull!!!");
                }
            }
            else
            {
                MessageBox.Show("Withdraw UnsuccessFull!!!");
            }
        }
    }
}
