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
    public partial class ShowLoanByAccountNumber : Form
    {
        public ShowLoanByAccountNumber()
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
            CustomerAccessForm customerAccessForm = new CustomerAccessForm();
            this.Hide();
            customerAccessForm.Show();
        }

        private void SearchpictureBox_Click(object sender, EventArgs e)
        {
            LoanService loanService = new LoanService();
            LoandataGridView.DataSource = loanService.GetLoanByAccountNumber(Convert.ToInt32(AccountNumbertextBox.Text));
        }
    }
}
