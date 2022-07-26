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
    public partial class UpdateAccount : Form
    {
        public UpdateAccount()
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
        private void SearchpictureBox_Click(object sender, EventArgs e)
        {
            AccountService accountService = new AccountService();
            AccountsdataGridView.DataSource = accountService.GetAccountByAccountNumber(Convert.ToInt32(AccountNumbertextBox.Text));
        }
        void UpdateAccountList(int accountNumber)
        {
            AccountService accountService = new AccountService();
            AccountsdataGridView.DataSource = accountService.GetAccountByAccountNumber(accountNumber);
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            AccountService accountService = new AccountService();
            int result = accountService.UpdateAccount(Convert.ToInt32(AccountNumbertextBox.Text), AccountNametextBox.Text, PhoneNumbertextBox.Text, EmailtextBox.Text, DateOfBirthDateTimePicker.Text, AddresstextBox.Text, OccupationcomboBox.Text, BranchNamecomboBox.Text);
            if (result > 0)
            {
                MessageBox.Show("Account Updated Successfully!!!");
                UpdateAccountList(Convert.ToInt32(AccountNumbertextBox.Text));
            }
            else
            {
                MessageBox.Show("Update Unsuccessfull!!!");
            }
        }

        private void AccountsdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AccountsdataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                AccountNametextBox.Text = AccountsdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                PhoneNumbertextBox.Text = AccountsdataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                EmailtextBox.Text = AccountsdataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                AddresstextBox.Text = AccountsdataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                DateOfBirthDateTimePicker.Text= AccountsdataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                OccupationcomboBox.Text = AccountsdataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                BranchNamecomboBox.Text= AccountsdataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
        }
    }
}
