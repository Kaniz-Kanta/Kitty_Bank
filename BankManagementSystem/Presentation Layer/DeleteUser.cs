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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
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
            AdminAccessForm adminAccessForm = new AdminAccessForm();
            this.Hide();
            adminAccessForm.Show();
        }

        void UpdateUserList()
        {
            UserService userService = new UserService();
            UserdataGridView.DataSource = userService.GetAllUsers();
        }
        private void Deletebutton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            int result = userService.DeleteUser(Convert.ToInt32(UserIdtextBox.Text));
            if (result > 0)
            {
                MessageBox.Show("User Deleted SuccessFully!!!");
                UpdateUserList();
            }
            else
            {
                MessageBox.Show("Delete UnsuccessFull!!!");
            }
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            UserdataGridView.DataSource = userService.GetAllUsers();
        }
    }
}
