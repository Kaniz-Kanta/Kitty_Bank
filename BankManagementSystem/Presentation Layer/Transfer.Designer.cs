
namespace BankManagementSystem.Presentation_Layer
{
    partial class Transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfer));
            this.Titlepanel = new System.Windows.Forms.Panel();
            this.BackpictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Minimizelabel1 = new System.Windows.Forms.Label();
            this.Maximizelabel1 = new System.Windows.Forms.Label();
            this.Crosslabel1 = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.AccountTypecomboBox = new System.Windows.Forms.ComboBox();
            this.AccountTypelabel = new System.Windows.Forms.Label();
            this.Transferbutton = new System.Windows.Forms.Button();
            this.BranchNamecomboBox = new System.Windows.Forms.ComboBox();
            this.BranchNamelabel = new System.Windows.Forms.Label();
            this.AmounttextBox = new System.Windows.Forms.TextBox();
            this.Amountlabel = new System.Windows.Forms.Label();
            this.TransactionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Datelabel = new System.Windows.Forms.Label();
            this.CurrentBalancetextBox = new System.Windows.Forms.TextBox();
            this.Balancelabel = new System.Windows.Forms.Label();
            this.AccountsdataGridView = new System.Windows.Forms.DataGridView();
            this.SearchpictureBox = new System.Windows.Forms.PictureBox();
            this.SenderAccountNumbertextBox = new System.Windows.Forms.TextBox();
            this.SenderAccountNumberlabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Transferlabel = new System.Windows.Forms.Label();
            this.ReceiverAccountNumbertextBox = new System.Windows.Forms.TextBox();
            this.ReceiverAccountNumberlabel = new System.Windows.Forms.Label();
            this.Titlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.Titlepanel.TabIndex = 52;
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
            this.pictureBox1.Location = new System.Drawing.Point(255, 3);
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
            this.Titlelabel.Location = new System.Drawing.Point(319, 20);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(235, 28);
            this.Titlelabel.TabIndex = 0;
            this.Titlelabel.Text = "Kitty Bank Limited";
            // 
            // AccountTypecomboBox
            // 
            this.AccountTypecomboBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTypecomboBox.FormattingEnabled = true;
            this.AccountTypecomboBox.Items.AddRange(new object[] {
            "Savings Account",
            "Checking Account"});
            this.AccountTypecomboBox.Location = new System.Drawing.Point(282, 324);
            this.AccountTypecomboBox.Name = "AccountTypecomboBox";
            this.AccountTypecomboBox.Size = new System.Drawing.Size(233, 27);
            this.AccountTypecomboBox.TabIndex = 102;
            // 
            // AccountTypelabel
            // 
            this.AccountTypelabel.AutoSize = true;
            this.AccountTypelabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTypelabel.Location = new System.Drawing.Point(46, 329);
            this.AccountTypelabel.Name = "AccountTypelabel";
            this.AccountTypelabel.Size = new System.Drawing.Size(126, 22);
            this.AccountTypelabel.TabIndex = 101;
            this.AccountTypelabel.Text = "Account Type:";
            // 
            // Transferbutton
            // 
            this.Transferbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.Transferbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transferbutton.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transferbutton.ForeColor = System.Drawing.Color.White;
            this.Transferbutton.Location = new System.Drawing.Point(549, 494);
            this.Transferbutton.Name = "Transferbutton";
            this.Transferbutton.Size = new System.Drawing.Size(209, 35);
            this.Transferbutton.TabIndex = 100;
            this.Transferbutton.Text = "Transfer";
            this.Transferbutton.UseVisualStyleBackColor = false;
            this.Transferbutton.Click += new System.EventHandler(this.Transferbutton_Click);
            // 
            // BranchNamecomboBox
            // 
            this.BranchNamecomboBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchNamecomboBox.FormattingEnabled = true;
            this.BranchNamecomboBox.Items.AddRange(new object[] {
            "Chawrasta",
            "Joydeppur",
            "Boardbazar",
            "Uttara",
            "Badda",
            "Tongi",
            "Bashundhara"});
            this.BranchNamecomboBox.Location = new System.Drawing.Point(282, 461);
            this.BranchNamecomboBox.Name = "BranchNamecomboBox";
            this.BranchNamecomboBox.Size = new System.Drawing.Size(233, 27);
            this.BranchNamecomboBox.TabIndex = 99;
            // 
            // BranchNamelabel
            // 
            this.BranchNamelabel.AutoSize = true;
            this.BranchNamelabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchNamelabel.Location = new System.Drawing.Point(46, 466);
            this.BranchNamelabel.Name = "BranchNamelabel";
            this.BranchNamelabel.Size = new System.Drawing.Size(130, 22);
            this.BranchNamelabel.TabIndex = 98;
            this.BranchNamelabel.Text = "Branch Name:";
            // 
            // AmounttextBox
            // 
            this.AmounttextBox.Font = new System.Drawing.Font("Dutch801 Rm BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmounttextBox.Location = new System.Drawing.Point(282, 390);
            this.AmounttextBox.Name = "AmounttextBox";
            this.AmounttextBox.Size = new System.Drawing.Size(233, 27);
            this.AmounttextBox.TabIndex = 97;
            // 
            // Amountlabel
            // 
            this.Amountlabel.AutoSize = true;
            this.Amountlabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountlabel.Location = new System.Drawing.Point(46, 395);
            this.Amountlabel.Name = "Amountlabel";
            this.Amountlabel.Size = new System.Drawing.Size(81, 22);
            this.Amountlabel.TabIndex = 96;
            this.Amountlabel.Text = "Amount:";
            // 
            // TransactionDateTimePicker
            // 
            this.TransactionDateTimePicker.Font = new System.Drawing.Font("Dutch801 Rm BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionDateTimePicker.Location = new System.Drawing.Point(282, 428);
            this.TransactionDateTimePicker.MaxDate = new System.DateTime(2030, 2, 28, 0, 0, 0, 0);
            this.TransactionDateTimePicker.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.TransactionDateTimePicker.Name = "TransactionDateTimePicker";
            this.TransactionDateTimePicker.Size = new System.Drawing.Size(233, 27);
            this.TransactionDateTimePicker.TabIndex = 95;
            this.TransactionDateTimePicker.Value = new System.DateTime(2021, 4, 25, 0, 0, 0, 0);
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.Location = new System.Drawing.Point(46, 431);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(159, 22);
            this.Datelabel.TabIndex = 94;
            this.Datelabel.Text = "Transaction Date:";
            // 
            // CurrentBalancetextBox
            // 
            this.CurrentBalancetextBox.Font = new System.Drawing.Font("Dutch801 Rm BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBalancetextBox.Location = new System.Drawing.Point(282, 291);
            this.CurrentBalancetextBox.Name = "CurrentBalancetextBox";
            this.CurrentBalancetextBox.Size = new System.Drawing.Size(233, 27);
            this.CurrentBalancetextBox.TabIndex = 93;
            // 
            // Balancelabel
            // 
            this.Balancelabel.AutoSize = true;
            this.Balancelabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balancelabel.Location = new System.Drawing.Point(46, 296);
            this.Balancelabel.Name = "Balancelabel";
            this.Balancelabel.Size = new System.Drawing.Size(153, 22);
            this.Balancelabel.TabIndex = 92;
            this.Balancelabel.Text = "Current Balance:";
            // 
            // AccountsdataGridView
            // 
            this.AccountsdataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.AccountsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountsdataGridView.Location = new System.Drawing.Point(18, 155);
            this.AccountsdataGridView.Name = "AccountsdataGridView";
            this.AccountsdataGridView.Size = new System.Drawing.Size(760, 112);
            this.AccountsdataGridView.TabIndex = 91;
            this.AccountsdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountsdataGridView_CellClick);
            // 
            // SearchpictureBox
            // 
            this.SearchpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SearchpictureBox.Image")));
            this.SearchpictureBox.Location = new System.Drawing.Point(598, 111);
            this.SearchpictureBox.Name = "SearchpictureBox";
            this.SearchpictureBox.Size = new System.Drawing.Size(33, 27);
            this.SearchpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchpictureBox.TabIndex = 90;
            this.SearchpictureBox.TabStop = false;
            this.SearchpictureBox.Click += new System.EventHandler(this.SearchpictureBox_Click);
            // 
            // SenderAccountNumbertextBox
            // 
            this.SenderAccountNumbertextBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenderAccountNumbertextBox.Location = new System.Drawing.Point(368, 111);
            this.SenderAccountNumbertextBox.Name = "SenderAccountNumbertextBox";
            this.SenderAccountNumbertextBox.Size = new System.Drawing.Size(233, 27);
            this.SenderAccountNumbertextBox.TabIndex = 89;
            // 
            // SenderAccountNumberlabel
            // 
            this.SenderAccountNumberlabel.AutoSize = true;
            this.SenderAccountNumberlabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenderAccountNumberlabel.Location = new System.Drawing.Point(145, 116);
            this.SenderAccountNumberlabel.Name = "SenderAccountNumberlabel";
            this.SenderAccountNumberlabel.Size = new System.Drawing.Size(217, 22);
            this.SenderAccountNumberlabel.TabIndex = 88;
            this.SenderAccountNumberlabel.Text = "Sender Account Number:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(324, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 87;
            this.pictureBox2.TabStop = false;
            // 
            // Transferlabel
            // 
            this.Transferlabel.AutoSize = true;
            this.Transferlabel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transferlabel.Location = new System.Drawing.Point(347, 74);
            this.Transferlabel.Name = "Transferlabel";
            this.Transferlabel.Size = new System.Drawing.Size(96, 22);
            this.Transferlabel.TabIndex = 86;
            this.Transferlabel.Text = "Transfer";
            // 
            // ReceiverAccountNumbertextBox
            // 
            this.ReceiverAccountNumbertextBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiverAccountNumbertextBox.Location = new System.Drawing.Point(282, 357);
            this.ReceiverAccountNumbertextBox.Name = "ReceiverAccountNumbertextBox";
            this.ReceiverAccountNumbertextBox.Size = new System.Drawing.Size(233, 27);
            this.ReceiverAccountNumbertextBox.TabIndex = 104;
            // 
            // ReceiverAccountNumberlabel
            // 
            this.ReceiverAccountNumberlabel.AutoSize = true;
            this.ReceiverAccountNumberlabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiverAccountNumberlabel.Location = new System.Drawing.Point(46, 362);
            this.ReceiverAccountNumberlabel.Name = "ReceiverAccountNumberlabel";
            this.ReceiverAccountNumberlabel.Size = new System.Drawing.Size(230, 22);
            this.ReceiverAccountNumberlabel.TabIndex = 103;
            this.ReceiverAccountNumberlabel.Text = "Receiver Account Number:";
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(798, 541);
            this.Controls.Add(this.ReceiverAccountNumbertextBox);
            this.Controls.Add(this.ReceiverAccountNumberlabel);
            this.Controls.Add(this.AccountTypecomboBox);
            this.Controls.Add(this.AccountTypelabel);
            this.Controls.Add(this.Transferbutton);
            this.Controls.Add(this.BranchNamecomboBox);
            this.Controls.Add(this.BranchNamelabel);
            this.Controls.Add(this.AmounttextBox);
            this.Controls.Add(this.Amountlabel);
            this.Controls.Add(this.TransactionDateTimePicker);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.CurrentBalancetextBox);
            this.Controls.Add(this.Balancelabel);
            this.Controls.Add(this.AccountsdataGridView);
            this.Controls.Add(this.SearchpictureBox);
            this.Controls.Add(this.SenderAccountNumbertextBox);
            this.Controls.Add(this.SenderAccountNumberlabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Transferlabel);
            this.Controls.Add(this.Titlepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            this.Titlepanel.ResumeLayout(false);
            this.Titlepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.ComboBox AccountTypecomboBox;
        private System.Windows.Forms.Label AccountTypelabel;
        private System.Windows.Forms.Button Transferbutton;
        private System.Windows.Forms.ComboBox BranchNamecomboBox;
        private System.Windows.Forms.Label BranchNamelabel;
        private System.Windows.Forms.TextBox AmounttextBox;
        private System.Windows.Forms.Label Amountlabel;
        private System.Windows.Forms.DateTimePicker TransactionDateTimePicker;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.TextBox CurrentBalancetextBox;
        private System.Windows.Forms.Label Balancelabel;
        private System.Windows.Forms.DataGridView AccountsdataGridView;
        private System.Windows.Forms.PictureBox SearchpictureBox;
        private System.Windows.Forms.TextBox SenderAccountNumbertextBox;
        private System.Windows.Forms.Label SenderAccountNumberlabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Transferlabel;
        private System.Windows.Forms.TextBox ReceiverAccountNumbertextBox;
        private System.Windows.Forms.Label ReceiverAccountNumberlabel;
    }
}