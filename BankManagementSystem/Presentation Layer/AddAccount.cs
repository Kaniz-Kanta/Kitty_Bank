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
    public partial class AddAccount : Form
    {
        public AddAccount()
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

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (AccountNametextBox.Text == "" || AccountTypecomboBox.Text == "" || PhoneNumbertextBox.Text == "" || EmailtextBox.Text == "" || BalancetextBox.Text == "" || DateOfBirthDateTimePicker.Text == "" || AddresstextBox.Text == "" || OccupationcomboBox.Text=="" || AccountOpeningdateTimePicker.Text=="" || BranchNamecomboBox.Text=="")
            {
                MessageBox.Show("Information Missing!!!!");
            }
            else
            {
                AccountService accountService = new AccountService();
                int result = accountService.AddAccount(AccountNametextBox.Text, AccountTypecomboBox.Text, PhoneNumbertextBox.Text, EmailtextBox.Text, Convert.ToSingle(BalancetextBox.Text), DateOfBirthDateTimePicker.Text, AddresstextBox.Text, OccupationcomboBox.Text, AccountOpeningdateTimePicker.Text, BranchNamecomboBox.Text);
                if (result > 0)
                {
                    MessageBox.Show("Account Added SuccessFully!!!");

                }
                else
                {
                    MessageBox.Show("Added UnsuccessFull!!!");
                }
            }
        }

        private void BackpictureBox_Click(object sender, EventArgs e)
        {
            EmployeeAccessForm employeeAccessForm = new EmployeeAccessForm();
            this.Hide();
            employeeAccessForm.Show();
        }
    }
}
