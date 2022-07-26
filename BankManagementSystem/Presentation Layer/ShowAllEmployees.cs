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
    public partial class ShowAllEmployees : Form
    {
        public ShowAllEmployees()
        {
            InitializeComponent();
            EmployeeService employeeService = new EmployeeService();
            EmployeesdataGridView.DataSource = employeeService.GetAllEmployees();
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

        private void EmployeesdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EmployeesdataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                EmployeeNametextBox.Text = EmployeesdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                SalarytextBox.Text = EmployeesdataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }
    }
}
