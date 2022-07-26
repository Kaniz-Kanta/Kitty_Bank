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
    public partial class Deposite : Form
    {
        public Deposite()
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
        void UpdateAccountList(int accountNumber)
        {
            AccountService accountService = new AccountService();
            AccountsdataGridView.DataSource= accountService.GetAccountByAccountNumber(accountNumber);
        }

        private void Depositbutton_Click(object sender, EventArgs e)
        {
            TransactionService transactionService = new TransactionService();
            AccountService accountService = new AccountService();
            //Balance Update
            float balance = Convert.ToSingle(CurrentBalancetextBox.Text) + Convert.ToSingle(AmounttextBox.Text);
            int result1 = accountService.UpdateBalance(Convert.ToInt32(AccountNumbertextBox.Text), balance);
            int result = transactionService.AddTransaction(Depositlabel.Text, Convert.ToSingle(AmounttextBox.Text), TransactionDateTimePicker.Text, BranchNamecomboBox.Text,AccountTypecomboBox.Text, Convert.ToInt32(AccountNumbertextBox.Text));
            if (result1 > 0 && result>0)
            {
                MessageBox.Show("Transaction Completed SuccessFull!!!");
                UpdateAccountList(Convert.ToInt32(AccountNumbertextBox.Text));
            }
            else
            {
                MessageBox.Show("Transaction UnsuccessFull!!!");
            }
        }
    }
}
