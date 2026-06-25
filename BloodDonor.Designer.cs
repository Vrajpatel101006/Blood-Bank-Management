namespace BloodBank
{
    partial class BloodDonor
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
            btnSubmit = new Button();
            label1 = new Label();
            txtDonorDescripiton = new TextBox();
            label12 = new Label();
            label13 = new Label();
            dtpDonationDate = new DateTimePicker();
            drpGivenBloodBefore = new ComboBox();
            label11 = new Label();
            txtDonorAddress = new TextBox();
            label7 = new Label();
            drpOccupation = new ComboBox();
            label10 = new Label();
            drpGender = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            drpBloodGroup = new ComboBox();
            txtDonorPhonenumber = new TextBox();
            label3 = new Label();
            txtDonorEmail = new TextBox();
            label8 = new Label();
            txtDonorWeight = new TextBox();
            label6 = new Label();
            txtDonorAge = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtDonorName = new TextBox();
            panel5 = new Panel();
            label14 = new Label();
            label9 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.LavenderBlush;
            btnSubmit.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(544, 2);
            btnSubmit.Margin = new Padding(2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(173, 44);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(298, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(266, 33);
            label1.TabIndex = 0;
            label1.Text = "Blood Donor Form";
            // 
            // txtDonorDescripiton
            // 
            txtDonorDescripiton.BackColor = Color.White;
            txtDonorDescripiton.Location = new Point(245, 420);
            txtDonorDescripiton.Margin = new Padding(2, 1, 2, 1);
            txtDonorDescripiton.MaxLength = 150;
            txtDonorDescripiton.Multiline = true;
            txtDonorDescripiton.Name = "txtDonorDescripiton";
            txtDonorDescripiton.Size = new Size(471, 67);
            txtDonorDescripiton.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(55, 71, 79);
            label12.Location = new Point(114, 420);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(122, 23);
            label12.TabIndex = 13;
            label12.Text = "Description :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(55, 71, 79);
            label13.Location = new Point(71, 370);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(165, 46);
            label13.TabIndex = 10;
            label13.Text = "Have You Given :\r\nBlood Before \r\n";
            // 
            // dtpDonationDate
            // 
            dtpDonationDate.CalendarMonthBackground = SystemColors.ActiveCaption;
            dtpDonationDate.Location = new Point(245, 131);
            dtpDonationDate.Margin = new Padding(2, 1, 2, 1);
            dtpDonationDate.Name = "dtpDonationDate";
            dtpDonationDate.Size = new Size(156, 23);
            dtpDonationDate.TabIndex = 3;
            // 
            // drpGivenBloodBefore
            // 
            drpGivenBloodBefore.BackColor = Color.White;
            drpGivenBloodBefore.DropDownStyle = ComboBoxStyle.DropDownList;
            drpGivenBloodBefore.FormattingEnabled = true;
            drpGivenBloodBefore.Items.AddRange(new object[] { "Yes", "No" });
            drpGivenBloodBefore.Location = new Point(245, 373);
            drpGivenBloodBefore.Margin = new Padding(2, 1, 2, 1);
            drpGivenBloodBefore.Name = "drpGivenBloodBefore";
            drpGivenBloodBefore.Size = new Size(471, 23);
            drpGivenBloodBefore.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(55, 71, 79);
            label11.Location = new Point(144, 279);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(92, 23);
            label11.TabIndex = 9;
            label11.Text = "Address :";
            // 
            // txtDonorAddress
            // 
            txtDonorAddress.BackColor = Color.White;
            txtDonorAddress.Location = new Point(245, 282);
            txtDonorAddress.Margin = new Padding(2, 1, 2, 1);
            txtDonorAddress.MaxLength = 150;
            txtDonorAddress.Multiline = true;
            txtDonorAddress.Name = "txtDonorAddress";
            txtDonorAddress.Size = new Size(471, 72);
            txtDonorAddress.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(55, 71, 79);
            label7.Location = new Point(156, 167);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 23);
            label7.TabIndex = 5;
            label7.Text = "E-mail :";
            // 
            // drpOccupation
            // 
            drpOccupation.AllowDrop = true;
            drpOccupation.BackColor = Color.White;
            drpOccupation.DropDownStyle = ComboBoxStyle.DropDownList;
            drpOccupation.FormattingEnabled = true;
            drpOccupation.Items.AddRange(new object[] { "Business / Self-Employed", "Corporate / Private Sector Job", "Driver / Pilot / Operator", "Farmer", "Government Service", "Healthcare / Medical Professional", "Laborer", "Military / Law Enforcement ", "Retired", "Sport person / Athlete", "Student", "Unemployed", "Other" });
            drpOccupation.Location = new Point(245, 243);
            drpOccupation.Margin = new Padding(2, 1, 2, 1);
            drpOccupation.Name = "drpOccupation";
            drpOccupation.Size = new Size(471, 23);
            drpOccupation.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(55, 71, 79);
            label10.Location = new Point(116, 243);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(120, 23);
            label10.TabIndex = 8;
            label10.Text = "Occupation :";
            // 
            // drpGender
            // 
            drpGender.BackColor = Color.White;
            drpGender.DropDownStyle = ComboBoxStyle.DropDownList;
            drpGender.FormattingEnabled = true;
            drpGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            drpGender.Location = new Point(567, 203);
            drpGender.Margin = new Padding(2, 1, 2, 1);
            drpGender.Name = "drpGender";
            drpGender.Size = new Size(149, 23);
            drpGender.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(55, 71, 79);
            label2.Location = new Point(103, 51);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 23);
            label2.TabIndex = 0;
            label2.Text = "Donor Name :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 76, 129);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(827, 55);
            panel2.TabIndex = 0;
            // 
            // drpBloodGroup
            // 
            drpBloodGroup.BackColor = Color.White;
            drpBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            drpBloodGroup.FormattingEnabled = true;
            drpBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            drpBloodGroup.Location = new Point(594, 90);
            drpBloodGroup.Margin = new Padding(2, 1, 2, 1);
            drpBloodGroup.Name = "drpBloodGroup";
            drpBloodGroup.Size = new Size(122, 23);
            drpBloodGroup.TabIndex = 2;
            // 
            // txtDonorPhonenumber
            // 
            txtDonorPhonenumber.BackColor = Color.White;
            txtDonorPhonenumber.Location = new Point(245, 203);
            txtDonorPhonenumber.Margin = new Padding(2, 1, 2, 1);
            txtDonorPhonenumber.MaxLength = 10;
            txtDonorPhonenumber.Name = "txtDonorPhonenumber";
            txtDonorPhonenumber.Size = new Size(202, 23);
            txtDonorPhonenumber.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(55, 71, 79);
            label3.Location = new Point(122, 90);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 23);
            label3.TabIndex = 1;
            label3.Text = "Donor Age :";
            // 
            // txtDonorEmail
            // 
            txtDonorEmail.BackColor = Color.White;
            txtDonorEmail.Location = new Point(245, 167);
            txtDonorEmail.Margin = new Padding(2, 1, 2, 1);
            txtDonorEmail.MaxLength = 50;
            txtDonorEmail.Name = "txtDonorEmail";
            txtDonorEmail.Size = new Size(471, 23);
            txtDonorEmail.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(55, 71, 79);
            label8.Location = new Point(127, 203);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(109, 23);
            label8.TabIndex = 6;
            label8.Text = "Phone no. :";
            // 
            // txtDonorWeight
            // 
            txtDonorWeight.BackColor = Color.White;
            txtDonorWeight.Location = new Point(595, 131);
            txtDonorWeight.Margin = new Padding(2, 1, 2, 1);
            txtDonorWeight.MaxLength = 3;
            txtDonorWeight.Name = "txtDonorWeight";
            txtDonorWeight.Size = new Size(121, 23);
            txtDonorWeight.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(55, 71, 79);
            label6.Location = new Point(451, 131);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(140, 23);
            label6.TabIndex = 4;
            label6.Text = "Weight(in kg) :";
            // 
            // txtDonorAge
            // 
            txtDonorAge.BackColor = Color.White;
            txtDonorAge.Location = new Point(245, 90);
            txtDonorAge.Margin = new Padding(2, 1, 2, 1);
            txtDonorAge.MaxLength = 3;
            txtDonorAge.Name = "txtDonorAge";
            txtDonorAge.Size = new Size(156, 23);
            txtDonorAge.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(55, 71, 79);
            label5.Location = new Point(85, 131);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(151, 23);
            label5.TabIndex = 3;
            label5.Text = "Donation Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(55, 71, 79);
            label4.Location = new Point(451, 90);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 23);
            label4.TabIndex = 2;
            label4.Text = "Blood Group :";
            // 
            // txtDonorName
            // 
            txtDonorName.BackColor = Color.White;
            txtDonorName.Location = new Point(245, 51);
            txtDonorName.Margin = new Padding(2, 1, 2, 1);
            txtDonorName.MaxLength = 50;
            txtDonorName.Name = "txtDonorName";
            txtDonorName.Size = new Size(471, 23);
            txtDonorName.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label14);
            panel5.Controls.Add(txtDonorDescripiton);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(dtpDonationDate);
            panel5.Controls.Add(drpGivenBloodBefore);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(txtDonorAddress);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(drpOccupation);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(drpGender);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(drpBloodGroup);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(txtDonorPhonenumber);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txtDonorEmail);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(txtDonorWeight);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(txtDonorAge);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(txtDonorName);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 55);
            panel5.Margin = new Padding(2, 1, 2, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(827, 539);
            panel5.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(144, 510);
            label14.Name = "label14";
            label14.Size = new Size(518, 15);
            label14.TabIndex = 14;
            label14.Text = "*Note : A person can donate 1Unit(450ml) of Blood in a period of 3 months";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(55, 71, 79);
            label9.Location = new Point(477, 203);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(86, 23);
            label9.TabIndex = 7;
            label9.Text = "Gender :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(15, 76, 129);
            panel3.Controls.Add(btnSubmit);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 594);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(827, 51);
            panel3.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(92, 50);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 645);
            panel1.TabIndex = 1;
            // 
            // BloodDonor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1034, 768);
            ControlBox = false;
            Controls.Add(panel1);
            Name = "BloodDonor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BloodDonor";
            Load += BloodDonor_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSubmit;
        private Label label1;
        private TextBox txtDonorDescripiton;
        private Label label12;
        private Label label13;
        private DateTimePicker dtpDonationDate;
        private ComboBox drpGivenBloodBefore;
        private Label label11;
        private TextBox txtDonorAddress;
        private Label label7;
        private ComboBox drpOccupation;
        private Label label10;
        private ComboBox drpGender;
        private Label label2;
        private Panel panel2;
        private ComboBox drpBloodGroup;
        private TextBox txtDonorPhonenumber;
        private Label label3;
        private TextBox txtDonorEmail;
        private Label label8;
        private TextBox txtDonorWeight;
        private Label label6;
        private TextBox txtDonorAge;
        private Label label5;
        private Label label4;
        private TextBox txtDonorName;
        private Panel panel5;
        private Label label9;
        private Panel panel3;
        private Panel panel1;
        private Label label14;
    }
}