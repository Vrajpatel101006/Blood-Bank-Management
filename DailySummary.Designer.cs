namespace BloodBank
{
    partial class Summary
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
            dgvSummary = new DataGridView();
            label1 = new Label();
            panel3 = new Panel();
            btnRefreshList = new Button();
            btnDonor = new Button();
            panel4 = new Panel();
            dtpStartDate = new DateTimePicker();
            btnRecipient = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            panel6 = new Panel();
            dtpEndDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSummary
            // 
            dgvSummary.BackgroundColor = Color.FromArgb(240, 253, 244);
            dgvSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSummary.Dock = DockStyle.Fill;
            dgvSummary.Location = new Point(0, 73);
            dgvSummary.Name = "dgvSummary";
            dgvSummary.Size = new Size(1454, 517);
            dgvSummary.TabIndex = 7;
            dgvSummary.CellContentClick += dgvSummary_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(606, 9);
            label1.Name = "label1";
            label1.Size = new Size(176, 38);
            label1.TabIndex = 0;
            label1.Text = "Summary";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(15, 76, 129);
            panel3.Dock = DockStyle.Bottom;
            panel3.ForeColor = Color.FromArgb(167, 243, 208);
            panel3.Location = new Point(0, 650);
            panel3.Name = "panel3";
            panel3.Size = new Size(1454, 60);
            panel3.TabIndex = 1;
            // 
            // btnRefreshList
            // 
            btnRefreshList.BackColor = Color.FromArgb(96, 125, 139);
            btnRefreshList.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefreshList.ForeColor = Color.White;
            btnRefreshList.Location = new Point(1107, 25);
            btnRefreshList.Name = "btnRefreshList";
            btnRefreshList.Size = new Size(200, 40);
            btnRefreshList.TabIndex = 4;
            btnRefreshList.Text = "Refresh List";
            btnRefreshList.UseVisualStyleBackColor = false;
            btnRefreshList.Click += btnRefreshList_Click;
            // 
            // btnDonor
            // 
            btnDonor.BackColor = Color.FromArgb(25, 118, 210);
            btnDonor.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDonor.ForeColor = Color.White;
            btnDonor.Location = new Point(112, 25);
            btnDonor.Name = "btnDonor";
            btnDonor.Size = new Size(200, 40);
            btnDonor.TabIndex = 0;
            btnDonor.Text = "Donor";
            btnDonor.UseVisualStyleBackColor = false;
            btnDonor.Click += btnDonor_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(240, 253, 244);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(dtpEndDate);
            panel4.Controls.Add(dtpStartDate);
            panel4.Controls.Add(btnRecipient);
            panel4.Controls.Add(btnRefreshList);
            panel4.Controls.Add(btnDonor);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1454, 73);
            panel4.TabIndex = 6;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(634, 35);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(180, 23);
            dtpStartDate.TabIndex = 6;
            //dtpStartDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // btnRecipient
            // 
            btnRecipient.BackColor = Color.FromArgb(25, 118, 210);
            btnRecipient.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecipient.ForeColor = Color.White;
            btnRecipient.Location = new Point(375, 25);
            btnRecipient.Name = "btnRecipient";
            btnRecipient.Size = new Size(200, 40);
            btnRecipient.TabIndex = 5;
            btnRecipient.Text = "Recipient";
            btnRecipient.UseVisualStyleBackColor = false;
            btnRecipient.Click += btnRecipient_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 76, 129);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1454, 60);
            panel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(80, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(1454, 710);
            panel1.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.InactiveCaption;
            panel6.Controls.Add(dgvSummary);
            panel6.Controls.Add(panel4);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 60);
            panel6.Name = "panel6";
            panel6.Size = new Size(1454, 590);
            panel6.TabIndex = 4;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(866, 35);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(180, 23);
            dtpEndDate.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 76, 129);
            label2.Location = new Point(634, 14);
            label2.Name = "label2";
            label2.Size = new Size(106, 18);
            label2.TabIndex = 8;
            label2.Text = "From Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(15, 76, 129);
            label3.Location = new Point(866, 14);
            label3.Name = "label3";
            label3.Size = new Size(84, 18);
            label3.TabIndex = 9;
            label3.Text = "To Date :";
            // 
            // Summary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1614, 810);
            Controls.Add(panel1);
            Name = "Summary";
            Text = "DailySummary";
            Load += DailySummary_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSummary;
        private Label label1;
        private Panel panel3;
        private Button btnRefreshList;
        private Button btnDonor;
        private Panel panel4;
        private Panel panel2;
        private Panel panel1;
        private Panel panel6;
        private Button btnRecipient;
        private DateTimePicker dtpStartDate;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpEndDate;
    }
}