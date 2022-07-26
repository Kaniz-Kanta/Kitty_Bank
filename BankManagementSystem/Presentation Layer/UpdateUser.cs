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
    public partial class UpdateUser : Form
    {
        static int Value;
        string Email;
        public UpdateUser(string email,int value)
        {
            InitializeComponent();
            Email = email;
            Value = value;
            UserService userService = new UserService();
            UserdataGridView.DataSource = userService.GetUsersByEmail(Email);
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
            else if (Value == 3)
            {
                CustomerAccessForm customerAccessForm = new CustomerAccessForm();
                this.Hide();
                customerAccessForm.Show();
            }
        }
        void UpdateUserList(int userId)
        {
            UserService userService = new UserService();
            UserdataGridView.DataSource = userService.GetUsersByUserId(userId);
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if(PasswordtextBox.Text== ConfirmPasswordtextBox.Text)
            {
                UserService userService = new UserService();
                int result = userService.UpdateUser(Convert.ToInt32(UserIdtextBox.Text), UserNametextBox.Text, PasswordtextBox.Text, EmailtextBox.Text, PhoneNumbertextBox.Text, UserTypeComboBox.Text, UpdateDateTimePicker.Text);
                if (result > 0)
                {
                    MessageBox.Show("User Information Updated!!!");
                    UpdateUserList(Convert.ToInt32(UserIdtextBox.Text));
                }
                else
                {
                    MessageBox.Show("Unsuccessfull To Update!!!");
                }
            }
            else
            {
                MessageBox.Show("Password and Confirm Password Are Not Same!!!!");
            }
            
        }

        private void UserdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UserdataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                UserIdtextBox.Text = UserdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                UserNametextBox.Text = UserdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                PasswordtextBox.Text = UserdataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                EmailtextBox.Text = UserdataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                UpdateDateTimePicker.Text= UserdataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                PhoneNumbertextBox.Text = UserdataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                UserTypeComboBox.Text = UserdataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }
    }
}
