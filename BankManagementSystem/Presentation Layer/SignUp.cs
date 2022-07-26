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
    public partial class SignUp : Form
    {
        public SignUp()
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

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            if(UserNametextBox.Text=="" || PasswordtextBox.Text=="" || ConfirmPasswordtextBox.Text=="" || EmailtextBox.Text=="" || PhoneNumbertextBox.Text=="" || UserTypeComboBox.Text=="" || RegistrationDateTimePicker.Text == "")
            {
                MessageBox.Show("Information Missing");
            }
            else if(PasswordtextBox.Text == ConfirmPasswordtextBox.Text)
            {
                UserService userService = new UserService();
                int result = userService.AddUser(UserNametextBox.Text, PasswordtextBox.Text, EmailtextBox.Text, PhoneNumbertextBox.Text,UserTypeComboBox.Text, RegistrationDateTimePicker.Text);
                if (result > 0)
                {
                    MessageBox.Show("User Added SuccessFully!!!");

                }
                else
                {
                    MessageBox.Show("Added UnsuccessFull!!!");
                }
            }
        }

        private void BackpictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.Show();
        }
    }
}
