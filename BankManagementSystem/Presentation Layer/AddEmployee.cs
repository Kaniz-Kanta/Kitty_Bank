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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
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

        private void Addbutton_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            int result = employeeService.AddEmployee(EmployeeNametextBox.Text, PhoneNumbertextBox.Text, EmailtextBox.Text, DateOfBirthDateTimePicker.Text, EducationcomboBox.Text, AddresstextBox.Text, Convert.ToSingle(SalarytextBox.Text), DesignationcomboBox.Text, JoiningdateTimePicker.Text, BranchNamecomboBox.Text);
            if (result > 0)
            {
                MessageBox.Show("Employee Added Successfully!!!");
            }
            else
            {
                MessageBox.Show("Employee Added Unsuccessfull!!!");
            }
        }
    }
}
