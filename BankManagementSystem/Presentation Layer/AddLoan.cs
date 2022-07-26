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
    public partial class AddLoan : Form
    {
        public AddLoan()
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

        private void Addbutton_Click(object sender, EventArgs e)
        {
            LoanService loanService = new LoanService();
            int result = loanService.AddLoan(LoanTypecomboBox.Text, Convert.ToSingle(AmounttextBox.Text), LoanTakingDateTimePicker.Text, LoanEnddateTimePicker.Text, Convert.ToSingle(PayAmounttextBox.Text), PaymentdateTimePicker.Text, BranchNamecomboBox.Text, Convert.ToInt32(AccountNumbertextBox.Text));
            if (result > 0)
            {
                MessageBox.Show("Loan Added Successfully!!!");
            }
            else
            {
                MessageBox.Show("Loan Add Unsuccessfull!!!");
            }
        }
    }
}
