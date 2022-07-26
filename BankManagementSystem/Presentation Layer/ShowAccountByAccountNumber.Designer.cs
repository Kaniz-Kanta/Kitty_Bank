
namespace BankManagementSystem.Presentation_Layer
{
    partial class ShowAccountByAccountNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAccountByAccountNumber));
            this.Titlepanel = new System.Windows.Forms.Panel();
            this.BackpictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Minimizelabel1 = new System.Windows.Forms.Label();
            this.Maximizelabel1 = new System.Windows.Forms.Label();
            this.Crosslabel1 = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ShowAllAccountlabel = new System.Windows.Forms.Label();
            this.AccountNumbertextBox = new System.Windows.Forms.TextBox();
            this.AccountNumberlabel = new System.Windows.Forms.Label();
            this.AccountsdataGridView = new System.Windows.Forms.DataGridView();
            this.SearchpictureBox = new System.Windows.Forms.PictureBox();
            this.AccountNametextBox = new System.Windows.Forms.TextBox();
            this.AccountNamelabel = new System.Windows.Forms.Label();
            this.BalancetextBox = new System.Windows.Forms.TextBox();
            this.Balancelabel = new System.Windows.Forms.Label();
            this.Titlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Titlepanel
            // 
            this.Titlepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.Titlepanel.Controls.Add(this.BackpictureBox);
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
            this.Titlepanel.TabIndex = 48;
            // 
            // BackpictureBox
            // 
            this.BackpictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BackpictureBox.Image")));
            this.BackpictureBox.Location = new System.Drawing.Point(0, 0);
            this.BackpictureBox.Name = "BackpictureBox";
            this.BackpictureBox.Size = new System.Drawing.Size(33, 71);
            this.BackpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackpictureBox.TabIndex = 5;
            this.BackpictureBox.TabStop = false;
            this.BackpictureBox.Click += new System.EventHandler(this.BackpictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(230, 3);
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
            this.Titlelabel.Location = new System.Drawing.Point(294, 20);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(235, 28);
            this.Titlelabel.TabIndex = 0;
            this.Titlelabel.Text = "Kitty Bank Limited";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(251, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // ShowAllAccountlabel
            // 
            this.ShowAllAccountlabel.AutoSize = true;
            this.ShowAllAccountlabel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllAccountlabel.Location = new System.Drawing.Point(274, 83);
            this.ShowAllAccountlabel.Name = "ShowAllAccountlabel";
            this.ShowAllAccountlabel.Size = new System.Drawing.Size(245, 22);
            this.ShowAllAccountlabel.TabIndex = 50;
            this.ShowAllAccountlabel.Text = "My Account Information";
            // 
            // AccountNumbertextBox
            // 
            this.AccountNumbertextBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumbertextBox.Location = new System.Drawing.Point(336, 125);
            this.AccountNumbertextBox.Name = "AccountNumbertextBox";
            this.AccountNumbertextBox.Size = new System.Drawing.Size(233, 27);
            this.AccountNumbertextBox.TabIndex = 53;
            // 
            // AccountNumberlabel
            // 
            this.AccountNumberlabel.AutoSize = true;
            this.AccountNumberlabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumberlabel.Location = new System.Drawing.Point(176, 130);
            this.AccountNumberlabel.Name = "AccountNumberlabel";
            this.AccountNumberlabel.Size = new System.Drawing.Size(154, 22);
            this.AccountNumberlabel.TabIndex = 52;
            this.AccountNumberlabel.Text = "Account Number:";
            // 
            // AccountsdataGridView
            // 
            this.AccountsdataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.AccountsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountsdataGridView.Location = new System.Drawing.Point(16, 176);
            this.AccountsdataGridView.Name = "AccountsdataGridView";
            this.AccountsdataGridView.Size = new System.Drawing.Size(762, 128);
            this.AccountsdataGridView.TabIndex = 54;
            this.AccountsdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountsdataGridView_CellClick);
            // 
            // SearchpictureBox
            // 
            this.SearchpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SearchpictureBox.Image")));
            this.SearchpictureBox.Location = new System.Drawing.Point(565, 125);
            this.SearchpictureBox.Name = "SearchpictureBox";
            this.SearchpictureBox.Size = new System.Drawing.Size(33, 27);
            this.SearchpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchpictureBox.TabIndex = 55;
            this.SearchpictureBox.TabStop = false;
            this.SearchpictureBox.Click += new System.EventHandler(this.SearchpictureBox_Click);
            // 
            // AccountNametextBox
            // 
            this.AccountNametextBox.BackColor = System.Drawing.Color.Silver;
            this.AccountNametextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountNametextBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNametextBox.Location = new System.Drawing.Point(171, 337);
            this.AccountNametextBox.Multiline = true;
            this.AccountNametextBox.Name = "AccountNametextBox";
            this.AccountNametextBox.Size = new System.Drawing.Size(233, 20);
            this.AccountNametextBox.TabIndex = 57;
            // 
            // AccountNamelabel
            // 
            this.AccountNamelabel.AutoSize = true;
            this.AccountNamelabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNamelabel.Location = new System.Drawing.Point(30, 335);
            this.AccountNamelabel.Name = "AccountNamelabel";
            this.AccountNamelabel.Size = new System.Drawing.Size(135, 22);
            this.AccountNamelabel.TabIndex = 56;
            this.AccountNamelabel.Text = "Account Name:";
            // 
            // BalancetextBox
            // 
            this.BalancetextBox.BackColor = System.Drawing.Color.Silver;
            this.BalancetextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BalancetextBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalancetextBox.Location = new System.Drawing.Point(118, 374);
            this.BalancetextBox.Multiline = true;
            this.BalancetextBox.Name = "BalancetextBox";
            this.BalancetextBox.Size = new System.Drawing.Size(233, 20);
            this.BalancetextBox.TabIndex = 59;
            // 
            // Balancelabel
            // 
            this.Balancelabel.AutoSize = true;
            this.Balancelabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balancelabel.Location = new System.Drawing.Point(30, 371);
            this.Balancelabel.Name = "Balancelabel";
            this.Balancelabel.Size = new System.Drawing.Size(82, 22);
            this.Balancelabel.TabIndex = 58;
            this.Balancelabel.Text = "Balance:";
            // 
            // ShowAccountByAccountNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(798, 415);
            this.Controls.Add(this.BalancetextBox);
            this.Controls.Add(this.Balancelabel);
            this.Controls.Add(this.AccountNametextBox);
            this.Controls.Add(this.AccountNamelabel);
            this.Controls.Add(this.SearchpictureBox);
            this.Controls.Add(this.AccountsdataGridView);
            this.Controls.Add(this.AccountNumbertextBox);
            this.Controls.Add(this.AccountNumberlabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ShowAllAccountlabel);
            this.Controls.Add(this.Titlepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowAccountByAccountNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowAccountByAccountNumber";
            this.Titlepanel.ResumeLayout(false);
            this.Titlepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Titlepanel;
        private System.Windows.Forms.PictureBox BackpictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Minimizelabel1;
        private System.Windows.Forms.Label Maximizelabel1;
        private System.Windows.Forms.Label Crosslabel1;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label ShowAllAccountlabel;
        private System.Windows.Forms.TextBox AccountNumbertextBox;
        private System.Windows.Forms.Label AccountNumberlabel;
        private System.Windows.Forms.DataGridView AccountsdataGridView;
        private System.Windows.Forms.PictureBox SearchpictureBox;
        private System.Windows.Forms.TextBox AccountNametextBox;
        private System.Windows.Forms.Label AccountNamelabel;
        private System.Windows.Forms.TextBox BalancetextBox;
        private System.Windows.Forms.Label Balancelabel;
    }
}