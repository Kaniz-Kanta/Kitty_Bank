﻿using System;
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
    public partial class ShowLoansByBranchName : Form
    {
        public ShowLoansByBranchName()
        {
            InitializeComponent();
        }

        private void BranchNamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoanService loanService = new LoanService();
            LoandataGridView.DataSource = loanService.GetLoanByBranchName(BranchNamecomboBox.Text);
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
