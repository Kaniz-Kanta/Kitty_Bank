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
    public partial class ShowAccountByBranchName : Form
    {
        static int Value;
        string Email;
        public ShowAccountByBranchName(string email, int value)
        {
            InitializeComponent();
            Email = email;
            Value = value;
        }

        private void BackpictureBox_Click(object sender, EventArgs e)
        {
            if (Value == 1)
            {
                AdminAccessForm adminAccessForm = new AdminAccessForm();
                this.Hide();
                adminAccessForm.Show();
            }
            else if (Value == 2)
            {
                EmployeeAccessForm employeeAccessForm = new EmployeeAccessForm();
                this.Hide();
                employeeAccessForm.Show();
            }
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

        private void BranchNamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccountService accountService = new AccountService();
            AccountsdataGridView.DataSource = accountService.GetAccountByBranchName(BranchNamecomboBox.Text);
        }

        private void AccountsdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AccountsdataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                AccountNametextBox.Text = AccountsdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                BalancetextBox.Text = AccountsdataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
    }
}
