
namespace BankManagementSystem.Presentation_Layer
{
    partial class CustomerAccessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerAccessForm));
            this.Titlepanel = new System.Windows.Forms.Panel();
            this.LogOutpictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Minimizelabel1 = new System.Windows.Forms.Label();
            this.Maximizelabel1 = new System.Windows.Forms.Label();
            this.Crosslabel1 = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Menulabel = new System.Windows.Forms.Label();
            this.AccountInformationbutton = new System.Windows.Forms.Button();
            this.UserInformationbutton = new System.Windows.Forms.Button();
            this.LoanInformationbutton = new System.Windows.Forms.Button();
            this.Transactionsbutton = new System.Windows.Forms.Button();
            this.UpdateUserbutton = new System.Windows.Forms.Button();
            this.Titlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogOutpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Titlepanel
            // 
            this.Titlepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.Titlepanel.Controls.Add(this.LogOutpictureBox);
            this.Titlepanel.Controls.Add(this.pictureBox1);
            this.Titlepanel.Controls.Add(this.Minimizelabel1);
            this.Titlepanel.Controls.Add(this.Maximizelabel1);
            this.Titlepanel.Controls.Add(this.Crosslabel1);
            this.Titlepanel.Controls.Add(this.Titlelabel);
            this.Titlepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titlepanel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlepanel.ForeColor = System.Drawing.Color.White;
            this.Titlepanel.Location = new System.Drawing.Point(0, 0);
            this.Titlepanel.Name = "Titlepanel";
            this.Titlepanel.Size = new System.Drawing.Size(798, 71);
            this.Titlepanel.TabIndex = 52;
            // 
            // LogOutpictureBox
            // 
            this.LogOutpictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogOutpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogOutpictureBox.Image")));
            this.LogOutpictureBox.Location = new System.Drawing.Point(0, 0);
            this.LogOutpictureBox.Name = "LogOutpictureBox";
            this.LogOutpictureBox.Size = new System.Drawing.Size(33, 71);
            this.LogOutpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogOutpictureBox.TabIndex = 5;
            this.LogOutpictureBox.TabStop = false;
            this.LogOutpictureBox.Click += new System.EventHandler(this.LogOutpictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(251, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Minimizelabel1
            // 
            this.Minimizelabel1.AutoSize = true;
            this.Minimizelabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimizelabel1.ForeColor = System.Drawing.Color.Green;
            this.Minimizelabel1.Location = new System.Drawing.Point(738, 0);
            this.Minimizelabel1.Name = "Minimizelabel1";
            this.Minimizelabel1.Size = new System.Drawing.Size(20, 18);
            this.Minimizelabel1.TabIndex = 3;
            this.Minimizelabel1.Text = "O";
            this.Minimizelabel1.Click += new System.EventHandler(this.Minimizelabel1_Click);
            // 
            // Maximizelabel1
            // 
            this.Maximizelabel1.AutoSize = true;
            this.Maximizelabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Maximizelabel1.ForeColor = System.Drawing.Color.Goldenrod;
            this.Maximizelabel1.Location = new System.Drawing.Point(758, 0);
            this.Maximizelabel1.Name = "Maximizelabel1";
            this.Maximizelabel1.Size = new System.Drawing.Size(20, 18);
            this.Maximizelabel1.TabIndex = 2;
            this.Maximizelabel1.Text = "O";
            this.Maximizelabel1.Click += new System.EventHandler(this.Maximizelabel1_Click);
            // 
            // Crosslabel1
            // 
            this.Crosslabel1.AutoSize = true;
            this.Crosslabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Crosslabel1.ForeColor = System.Drawing.Color.Red;
            this.Crosslabel1.Location = new System.Drawing.Point(778, 0);
            this.Crosslabel1.Name = "Crosslabel1";
            this.Crosslabel1.Size = new System.Drawing.Size(20, 18);
            this.Crosslabel1.TabIndex = 1;
            this.Crosslabel1.Text = "O";
            this.Crosslabel1.Click += new System.EventHandler(this.Crosslabel1_Click);
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Lucida Bright", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.Location = new System.Drawing.Point(315, 20);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(235, 28);
            this.Titlelabel.TabIndex = 0;
            this.Titlelabel.Text = "Kitty Bank Limited";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(342, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // Menulabel
            // 
            this.Menulabel.AutoSize = true;
            this.Menulabel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menulabel.Location = new System.Drawing.Point(365, 85);
            this.Menulabel.Name = "Menulabel";
            this.Menulabel.Size = new System.Drawing.Size(62, 22);
            this.Menulabel.TabIndex = 61;
            this.Menulabel.Text = "Menu";
            // 
            // AccountInformationbutton
            // 
            this.AccountInformationbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.AccountInformationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountInformationbutton.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountInformationbutton.ForeColor = System.Drawing.Color.White;
            this.AccountInformationbutton.Location = new System.Drawing.Point(58, 159);
            this.AccountInformationbutton.Name = "AccountInformationbutton";
            this.AccountInformationbutton.Size = new System.Drawing.Size(261, 61);
            this.AccountInformationbutton.TabIndex = 80;
            this.AccountInformationbutton.Text = "Account Information";
            this.AccountInformationbutton.UseVisualStyleBackColor = false;
            this.AccountInformationbutton.Click += new System.EventHandler(this.AccountInformationbutton_Click);
            // 
            // UserInformationbutton
            // 
            this.UserInformationbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.UserInformationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserInformationbutton.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInformationbutton.ForeColor = System.Drawing.Color.White;
            this.UserInformationbutton.Location = new System.Drawing.Point(58, 284);
            this.UserInformationbutton.Name = "UserInformationbutton";
            this.UserInformationbutton.Size = new System.Drawing.Size(261, 60);
            this.UserInformationbutton.TabIndex = 81;
            this.UserInformationbutton.Text = "User Profile";
            this.UserInformationbutton.UseVisualStyleBackColor = false;
            this.UserInformationbutton.Click += new System.EventHandler(this.UserInformationbutton_Click);
            // 
            // LoanInformationbutton
            // 
            this.LoanInformationbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.LoanInformationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoanInformationbutton.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanInformationbutton.ForeColor = System.Drawing.Color.White;
            this.LoanInformationbutton.Location = new System.Drawing.Point(453, 159);
            this.LoanInformationbutton.Name = "LoanInformationbutton";
            this.LoanInformationbutton.Size = new System.Drawing.Size(289, 61);
            this.LoanInformationbutton.TabIndex = 82;
            this.LoanInformationbutton.Text = "Loan ";
            this.LoanInformationbutton.UseVisualStyleBackColor = false;
            this.LoanInformationbutton.Click += new System.EventHandler(this.LoanInformationbutton_Click);
            // 
            // Transactionsbutton
            // 
            this.Transactionsbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.Transactionsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transactionsbutton.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transactionsbutton.ForeColor = System.Drawing.Color.White;
            this.Transactionsbutton.Location = new System.Drawing.Point(453, 282);
            this.Transactionsbutton.Name = "Transactionsbutton";
            this.Transactionsbutton.Size = new System.Drawing.Size(289, 62);
            this.Transactionsbutton.TabIndex = 83;
            this.Transactionsbutton.Text = "Transactions";
            this.Transactionsbutton.UseVisualStyleBackColor = false;
            this.Transactionsbutton.Click += new System.EventHandler(this.Transactionsbutton_Click);
            // 
            // UpdateUserbutton
            // 
            this.UpdateUserbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.UpdateUserbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateUserbutton.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateUserbutton.ForeColor = System.Drawing.Color.White;
            this.UpdateUserbutton.Location = new System.Drawing.Point(58, 407);
            this.UpdateUserbutton.Name = "UpdateUserbutton";
            this.UpdateUserbutton.Size = new System.Drawing.Size(261, 55);
            this.UpdateUserbutton.TabIndex = 84;
            this.UpdateUserbutton.Text = "Update User Profile";
            this.UpdateUserbutton.UseVisualStyleBackColor = false;
            this.UpdateUserbutton.Click += new System.EventHandler(this.UpdateUserbutton_Click);
            // 
            // CustomerAccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(798, 541);
            this.Controls.Add(this.UpdateUserbutton);
            this.Controls.Add(this.Transactionsbutton);
            this.Controls.Add(this.LoanInformationbutton);
            this.Controls.Add(this.UserInformationbutton);
            this.Controls.Add(this.AccountInformationbutton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Menulabel);
            this.Controls.Add(this.Titlepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerAccessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerAccessForm";
            this.Titlepanel.ResumeLayout(false);
            this.Titlepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogOutpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Titlepanel;
        private System.Windows.Forms.PictureBox LogOutpictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Minimizelabel1;
        private System.Windows.Forms.Label Maximizelabel1;
        private System.Windows.Forms.Label Crosslabel1;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Menulabel;
        private System.Windows.Forms.Button AccountInformationbutton;
        private System.Windows.Forms.Button UserInformationbutton;
        private System.Windows.Forms.Button LoanInformationbutton;
        private System.Windows.Forms.Button Transactionsbutton;
        private System.Windows.Forms.Button UpdateUserbutton;
    }
}