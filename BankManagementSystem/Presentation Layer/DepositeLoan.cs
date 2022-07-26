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
    public partial class DepositeLoan : Form
    {
        public DepositeLoan()
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
            LoanService loanService = new LoanService();
            LoandataGridView.DataSource = loanService.GetLoanByAccountNumber(Convert.ToInt32(AccountNumbertextBox.Text));
        }
        void UpdateLoanList(int accountNumber)
        {
            LoanService loanService = new LoanService();
            LoandataGridView.DataSource = loanService.GetLoanByAccountNumber(accountNumber);
        }

        private void Depositbutton_Click(object sender, EventArgs e)
        {
            float amount = Convert.ToSingle(PaidAmounttextBox.Text) + Convert.ToSingle(AmounttextBox.Text);
            LoanService loanService = new LoanService();
            TransactionService transactionService = new TransactionService();
            int result = loanService.UpdateLoan(amount, TransactionDateTimePicker.Text, Convert.ToInt32(AccountNumbertextBox.Text));
            int result1 = transactionService.AddTransaction(LoanPaymentlabel.Text, Convert.ToSingle(AmounttextBox.Text), TransactionDateTimePicker.Text, BranchNamecomboBox.Text, AccountTypecomboBox.Text, Convert.ToInt32(AccountNumbertextBox.Text));
            if(result>0 && result1 > 0)
            {
                MessageBox.Show("Transaction Completed Successfully!!!");
                UpdateLoanList(Convert.ToInt32(AccountNumbertextBox.Text));
            }
            else
            {
                MessageBox.Show("Transaction Unsuccessfull!!!");
            }
        }

        private void LoandataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (LoandataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                PaidAmounttextBox.Text = LoandataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
    }
}
