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
    public partial class DeleteLoan : Form
    {
        public DeleteLoan()
        {
            InitializeComponent();
            LoanService loanService = new LoanService();
            LoandataGridView.DataSource = loanService.GetAllLoans();
        }
        void UpdateLoanList()
        {
            LoanService loanService = new LoanService();
            LoandataGridView.DataSource = loanService.GetAllLoans();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            LoanService loanService = new LoanService();
            int result = loanService.DeleteLoan(Convert.ToInt32(AccountNumbertextBox.Text));
            if (result > 0)
            {
                MessageBox.Show("Information Deleted Successfully!!!");
                UpdateLoanList();
            }
            else
            {
                MessageBox.Show("Information Delete Unsuccessfull!!!");
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

        private void BackpictureBox_Click(object sender, EventArgs e)
        {
            EmployeeAccessForm employeeAccessForm = new EmployeeAccessForm();
            this.Hide();
            employeeAccessForm.Show();
        }
    }
}
