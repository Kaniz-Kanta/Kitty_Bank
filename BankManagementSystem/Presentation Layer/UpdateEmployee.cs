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
    public partial class UpdateEmployee : Form
    {
        public UpdateEmployee()
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

        private void SearchpictureBox_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            EmployeesdataGridView.DataSource = employeeService.GetEmployeeByEmployeeId(Convert.ToInt32(EmployeeIdtextBox.Text));
        }
        void UpdateEmployeeList(int employeeId)
        {
            EmployeeService employeeService = new EmployeeService();
            EmployeesdataGridView.DataSource = employeeService.GetEmployeeByEmployeeId(employeeId);
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            int result = employeeService.UpdateEmployee(Convert.ToInt32(EmployeeIdtextBox.Text), EmployeeNametextBox.Text, PhoneNumbertextBox.Text, EmailtextBox.Text, DateOfBirthDateTimePicker.Text, EducationcomboBox.Text, AddresstextBox.Text, Convert.ToSingle(SalarytextBox.Text), DesignationcomboBox.Text, BranchNamecomboBox.Text);
            if (result > 0)
            {
                MessageBox.Show("Information Updated Successfully!!!!");
                UpdateEmployeeList(Convert.ToInt32(EmployeeIdtextBox.Text));
            }
            else
            {
                MessageBox.Show("Information Update Unsuccessfull!!!!");
            }
        }

        private void EmployeesdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EmployeesdataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                EmployeeNametextBox.Text = EmployeesdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                EmailtextBox.Text = EmployeesdataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                PhoneNumbertextBox.Text = EmployeesdataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                DateOfBirthDateTimePicker.Text = EmployeesdataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                EducationcomboBox.Text= EmployeesdataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                AddresstextBox.Text = EmployeesdataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                SalarytextBox.Text =EmployeesdataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                DesignationcomboBox.Text =EmployeesdataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                BranchNamecomboBox.Text = EmployeesdataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
        }
    }
}
