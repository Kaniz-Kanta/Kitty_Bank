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
    public partial class Transfer : Form
    {
        public Transfer()
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
            AccountsdataGridView.DataSource = accountService.GetAccountByAccountNumber(Convert.ToInt32(SenderAccountNumbertextBox.Text));
        }

        private void Transferbutton_Click(object sender, EventArgs e)
        {
            Deposite deposite = new Deposite();
            AccountService accountService = new AccountService();
            TransactionService transactionService = new TransactionService();
            float balance1 = Convert.ToSingle(CurrentBalancetextBox.Text) - Convert.ToSingle(AmounttextBox.Text);
            float balance2 = Convert.ToSingle(CurrentBalancetextBox.Text) + Convert.ToSingle(AmounttextBox.Text);
            if (AccountTypecomboBox.Text == "Savings Account" && balance1 > 500 && Convert.ToSingle(AmounttextBox.Text) > 0)
            {
                int result1 = accountService.UpdateBalance(Convert.ToInt32(SenderAccountNumbertextBox.Text), balance1);
                int result2 = accountService.UpdateBalance(Convert.ToInt32(ReceiverAccountNumbertextBox.Text), balance2); ;
                int result3 = transactionService.AddTransaction(Transferlabel.Text, Convert.ToSingle(AmounttextBox.Text), TransactionDateTimePicker.Text, BranchNamecomboBox.Text, AccountTypecomboBox.Text, Convert.ToInt32(SenderAccountNumbertextBox.Text));
                int result4 = transactionService.AddTransaction(deposite.Depositlabel.Text, Convert.ToSingle(AmounttextBox.Text), TransactionDateTimePicker.Text, BranchNamecomboBox.Text, AccountTypecomboBox.Text, Convert.ToInt32(ReceiverAccountNumbertextBox.Text));
                if (result1 > 0 && result2 > 0 && result3>0 && result4>0)
                {
                    MessageBox.Show("Transaction Completed Successfully!!!");
                    UpdateAccountList(Convert.ToInt32(SenderAccountNumbertextBox.Text));
                }
                else
                {
                    MessageBox.Show("Transaction UnsuccessFull!!!");
                }
            }
            else if (AccountTypecomboBox.Text == "Checking Account" && balance1 > 100 && Convert.ToSingle(AmounttextBox.Text) > 0)
            {
                int result1 = accountService.UpdateBalance(Convert.ToInt32(SenderAccountNumbertextBox.Text), balance1);
                int result2 = accountService.UpdateBalance(Convert.ToInt32(ReceiverAccountNumbertextBox.Text), balance2); ;
                int result3 = transactionService.AddTransaction(Transferlabel.Text, Convert.ToSingle(AmounttextBox.Text), TransactionDateTimePicker.Text, BranchNamecomboBox.Text, AccountTypecomboBox.Text, Convert.ToInt32(SenderAccountNumbertextBox.Text));
                int result4 = transactionService.AddTransaction(deposite.Depositlabel.Text, Convert.ToSingle(AmounttextBox.Text), TransactionDateTimePicker.Text, BranchNamecomboBox.Text, AccountTypecomboBox.Text, Convert.ToInt32(ReceiverAccountNumbertextBox.Text));
                if (result1 > 0 && result2 > 0 && result3 > 0 && result4 > 0)
                {
                    MessageBox.Show("Transaction Completed Successfully!!!");
                    UpdateAccountList(Convert.ToInt32(SenderAccountNumbertextBox.Text));
                }
                else
                {
                    MessageBox.Show("Transaction Unsuccessfull!!!");
                }
            }
            else
            {
                MessageBox.Show("Transfer Unsuccessfull!!!");
            }
        }

        private void AccountsdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AccountsdataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                AccountTypecomboBox.Text = AccountsdataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                CurrentBalancetextBox.Text = AccountsdataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
    }
}
