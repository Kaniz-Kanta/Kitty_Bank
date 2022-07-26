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
    public partial class ShowAccountByAccountType : Form
    {
        public ShowAccountByAccountType()
        {
            InitializeComponent();
        }

        private void BackpictureBox_Click(object sender, EventArgs e)
        {
            AdminAccessForm adminAccessForm = new AdminAccessForm();
            this.Hide();
            adminAccessForm.Show();
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

        private void AccountTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccountService accountService = new AccountService();
            AccountsdataGridView.DataSource = accountService.GetAccountByAccountType(AccountTypecomboBox.Text);
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
