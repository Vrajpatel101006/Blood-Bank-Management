namespace BloodBank
{
    partial class BloodReceiver
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
            panel3 = new Panel();
            btnSubmit = new Button();
            label17 = new Label();
            txtDoctorPhoneNumber = new TextBox();
            label15 = new Label();
            label16 = new Label();
            drpBloodGivenBefore = new ComboBox();
            label14 = new Label();
            drpOccupation = new ComboBox();
            label13 = new Label();
            drpGender = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            dtpReceivingDate = new DateTimePicker();
            label10 = new Label();
            drpBloodGroup = new ComboBox();
            label9 = new Label();
            label1 = new Label();
            txtDoctorName = new TextBox();
            panel1 = new Panel();
            panel5 = new Panel();
            label19 = new Label();
            txtBloodRequired = new TextBox();
            txtDescription = new TextBox();
            label18 = new Label();
            label8 = new Label();
            txtHospitalPhoneNumber = new TextBox();
            label7 = new Label();
            txtHospitalName = new TextBox();
            label6 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtWeight = new TextBox();
            txtAge = new TextBox();
            txtName = new TextBox();
            panel2 = new Panel();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(15, 76, 129);
            panel3.Controls.Add(btnSubmit);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 758);
            panel3.Name = "panel3";
            panel3.Size = new Size(964, 63);
            panel3.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.LavenderBlush;
            btnSubmit.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(675, 6);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(167, 49);
            btnSubmit.TabIndex = 17;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century", 13.8F);
            label17.ForeColor = Color.FromArgb(55, 71, 79);
            label17.Location = new Point(489, 516);
            label17.Name = "label17";
            label17.Size = new Size(165, 23);
            label17.TabIndex = 17;
            label17.Text = "Doctor PhoneNo :";
            label17.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtDoctorPhoneNumber
            // 
            txtDoctorPhoneNumber.BackColor = Color.White;
            txtDoctorPhoneNumber.Location = new Point(663, 512);
            txtDoctorPhoneNumber.MaxLength = 10;
            txtDoctorPhoneNumber.Name = "txtDoctorPhoneNumber";
            txtDoctorPhoneNumber.Size = new Size(222, 23);
            txtDoctorPhoneNumber.TabIndex = 14;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century", 13.8F);
            label15.ForeColor = Color.FromArgb(55, 71, 79);
            label15.Location = new Point(59, 516);
            label15.Name = "label15";
            label15.Size = new Size(183, 23);
            label15.TabIndex = 14;
            label15.Text = "Hospital PhoneNo :";
            label15.TextAlign = ContentAlignment.TopCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century", 13.8F);
            label16.ForeColor = Color.FromArgb(55, 71, 79);
            label16.Location = new Point(79, 387);
            label16.Name = "label16";
            label16.Size = new Size(163, 46);
            label16.TabIndex = 15;
            label16.Text = "Blood Required : \r\nUnits ";
            label16.TextAlign = ContentAlignment.TopCenter;
            // 
            // drpBloodGivenBefore
            // 
            drpBloodGivenBefore.BackColor = Color.White;
            drpBloodGivenBefore.DropDownStyle = ComboBoxStyle.DropDownList;
            drpBloodGivenBefore.FormattingEnabled = true;
            drpBloodGivenBefore.Items.AddRange(new object[] { "Yes", "No" });
            drpBloodGivenBefore.Location = new Point(663, 387);
            drpBloodGivenBefore.Name = "drpBloodGivenBefore";
            drpBloodGivenBefore.Size = new Size(222, 23);
            drpBloodGivenBefore.TabIndex = 11;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century", 13.8F);
            label14.ForeColor = Color.FromArgb(55, 71, 79);
            label14.Location = new Point(82, 559);
            label14.Name = "label14";
            label14.Size = new Size(160, 46);
            label14.TabIndex = 13;
            label14.Text = "Referred Doctor :\r\nName\r\n";
            label14.TextAlign = ContentAlignment.TopCenter;
            // 
            // drpOccupation
            // 
            drpOccupation.BackColor = Color.White;
            drpOccupation.DropDownStyle = ComboBoxStyle.DropDownList;
            drpOccupation.FormattingEnabled = true;
            drpOccupation.Items.AddRange(new object[] { "Agriculture", "Driver / Pilot / OperatorMilitary ", "Government", "Healthcare / Medical Professional", "Law Enforcement", "Retired", "Self-Employed", "ServiceCorporate / Private Sector JobBusiness ", "Sports Person / AthleteFarmer ", "Student", "Unemployed", "Other" });
            drpOccupation.Location = new Point(258, 328);
            drpOccupation.Name = "drpOccupation";
            drpOccupation.Size = new Size(627, 23);
            drpOccupation.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century", 13.8F);
            label13.ForeColor = Color.FromArgb(55, 71, 79);
            label13.Location = new Point(88, 465);
            label13.Name = "label13";
            label13.Size = new Size(154, 23);
            label13.TabIndex = 12;
            label13.Text = "Hospital Name :";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // drpGender
            // 
            drpGender.BackColor = Color.White;
            drpGender.DropDownStyle = ComboBoxStyle.DropDownList;
            drpGender.FormattingEnabled = true;
            drpGender.Items.AddRange(new object[] { "MALE", "FEMALE", "OTHER" });
            drpGender.Location = new Point(663, 224);
            drpGender.Name = "drpGender";
            drpGender.Size = new Size(222, 23);
            drpGender.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century", 13.8F);
            label12.ForeColor = Color.FromArgb(55, 71, 79);
            label12.Location = new Point(492, 387);
            label12.Name = "label12";
            label12.Size = new Size(165, 46);
            label12.TabIndex = 11;
            label12.Text = "Have You Given :\r\nBlood Before        ";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century", 13.8F);
            label11.ForeColor = Color.FromArgb(55, 71, 79);
            label11.Location = new Point(148, 282);
            label11.Name = "label11";
            label11.Size = new Size(92, 23);
            label11.TabIndex = 10;
            label11.Text = "Address :";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // dtpReceivingDate
            // 
            dtpReceivingDate.CalendarMonthBackground = SystemColors.ActiveCaption;
            dtpReceivingDate.Location = new Point(258, 121);
            dtpReceivingDate.Name = "dtpReceivingDate";
            dtpReceivingDate.Size = new Size(243, 23);
            dtpReceivingDate.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 13.8F);
            label10.ForeColor = Color.FromArgb(55, 71, 79);
            label10.Location = new Point(122, 328);
            label10.Name = "label10";
            label10.Size = new Size(120, 23);
            label10.TabIndex = 9;
            label10.Text = "Occupation :";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // drpBloodGroup
            // 
            drpBloodGroup.BackColor = Color.White;
            drpBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            drpBloodGroup.FormattingEnabled = true;
            drpBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            drpBloodGroup.Location = new Point(663, 73);
            drpBloodGroup.Name = "drpBloodGroup";
            drpBloodGroup.Size = new Size(222, 23);
            drpBloodGroup.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 13.8F);
            label9.ForeColor = Color.FromArgb(55, 71, 79);
            label9.Location = new Point(568, 223);
            label9.Name = "label9";
            label9.Size = new Size(86, 23);
            label9.TabIndex = 8;
            label9.Text = "Gender :";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(300, 13);
            label1.Name = "label1";
            label1.Size = new Size(314, 33);
            label1.TabIndex = 0;
            label1.Text = "Blood Recipient Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDoctorName
            // 
            txtDoctorName.BackColor = Color.White;
            txtDoctorName.Location = new Point(258, 558);
            txtDoctorName.MaxLength = 50;
            txtDoctorName.Name = "txtDoctorName";
            txtDoctorName.Size = new Size(627, 23);
            txtDoctorName.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(32, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 821);
            panel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label19);
            panel5.Controls.Add(txtBloodRequired);
            panel5.Controls.Add(txtDescription);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(txtDoctorPhoneNumber);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(drpBloodGivenBefore);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(drpOccupation);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(drpGender);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(dtpReceivingDate);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(drpBloodGroup);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(txtDoctorName);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(txtHospitalPhoneNumber);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(txtHospitalName);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(txtAddress);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(txtPhoneNumber);
            panel5.Controls.Add(txtEmail);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(txtWeight);
            panel5.Controls.Add(txtAge);
            panel5.Controls.Add(txtName);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 54);
            panel5.Name = "panel5";
            panel5.Size = new Size(964, 704);
            panel5.TabIndex = 3;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Red;
            label19.Location = new Point(79, 433);
            label19.Name = "label19";
            label19.Size = new Size(308, 15);
            label19.TabIndex = 19;
            label19.Text = "*Note : 1Unit is equivent to 450ml of Blood";
            // 
            // txtBloodRequired
            // 
            txtBloodRequired.BackColor = Color.White;
            txtBloodRequired.Location = new Point(258, 387);
            txtBloodRequired.MaxLength = 3;
            txtBloodRequired.Name = "txtBloodRequired";
            txtBloodRequired.Size = new Size(178, 23);
            txtBloodRequired.TabIndex = 10;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.Location = new Point(258, 617);
            txtDescription.MaxLength = 500;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(627, 32);
            txtDescription.TabIndex = 16;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century", 13.8F);
            label18.ForeColor = Color.FromArgb(55, 71, 79);
            label18.Location = new Point(118, 626);
            label18.Name = "label18";
            label18.Size = new Size(122, 23);
            label18.TabIndex = 18;
            label18.Text = "Description :";
            label18.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 13.8F);
            label8.ForeColor = Color.FromArgb(55, 71, 79);
            label8.Location = new Point(131, 229);
            label8.Name = "label8";
            label8.Size = new Size(109, 23);
            label8.TabIndex = 7;
            label8.Text = "Phone no. :";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtHospitalPhoneNumber
            // 
            txtHospitalPhoneNumber.BackColor = Color.White;
            txtHospitalPhoneNumber.Location = new Point(258, 512);
            txtHospitalPhoneNumber.MaxLength = 10;
            txtHospitalPhoneNumber.Name = "txtHospitalPhoneNumber";
            txtHospitalPhoneNumber.Size = new Size(208, 23);
            txtHospitalPhoneNumber.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 13.8F);
            label7.ForeColor = Color.FromArgb(55, 71, 79);
            label7.Location = new Point(160, 177);
            label7.Name = "label7";
            label7.Size = new Size(80, 23);
            label7.TabIndex = 6;
            label7.Text = "E-mail :";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtHospitalName
            // 
            txtHospitalName.BackColor = Color.White;
            txtHospitalName.Location = new Point(258, 461);
            txtHospitalName.MaxLength = 50;
            txtHospitalName.Name = "txtHospitalName";
            txtHospitalName.Size = new Size(627, 23);
            txtHospitalName.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 13.8F);
            label6.ForeColor = Color.FromArgb(55, 71, 79);
            label6.Location = new Point(517, 126);
            label6.Name = "label6";
            label6.Size = new Size(140, 23);
            label6.TabIndex = 5;
            label6.Text = "Weight(in kg) :";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.Location = new Point(258, 281);
            txtAddress.MaxLength = 500;
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(627, 32);
            txtAddress.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 13.8F);
            label5.ForeColor = Color.FromArgb(55, 71, 79);
            label5.Location = new Point(88, 125);
            label5.Name = "label5";
            label5.Size = new Size(154, 23);
            label5.TabIndex = 4;
            label5.Text = "Receiving Date :";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.White;
            txtPhoneNumber.Location = new Point(258, 223);
            txtPhoneNumber.MaxLength = 10;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(243, 23);
            txtPhoneNumber.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Location = new Point(258, 173);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(627, 23);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 13.8F);
            label3.ForeColor = Color.FromArgb(55, 71, 79);
            label3.Location = new Point(97, 76);
            label3.Name = "label3";
            label3.Size = new Size(143, 23);
            label3.TabIndex = 2;
            label3.Text = "Recipient Age :";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 13.8F);
            label4.ForeColor = Color.FromArgb(55, 71, 79);
            label4.Location = new Point(522, 76);
            label4.Name = "label4";
            label4.Size = new Size(132, 23);
            label4.TabIndex = 3;
            label4.Text = "Blood Group :";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 13.8F);
            label2.ForeColor = Color.FromArgb(55, 71, 79);
            label2.Location = new Point(78, 33);
            label2.Name = "label2";
            label2.Size = new Size(162, 23);
            label2.TabIndex = 1;
            label2.Text = "Recipient Name :";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtWeight
            // 
            txtWeight.BackColor = Color.White;
            txtWeight.Location = new Point(663, 122);
            txtWeight.MaxLength = 3;
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(222, 23);
            txtWeight.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.White;
            txtAge.Location = new Point(258, 72);
            txtAge.MaxLength = 3;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(178, 23);
            txtAge.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Location = new Point(258, 29);
            txtName.MaxLength = 50;
            txtName.Name = "txtName";
            txtName.Size = new Size(627, 23);
            txtName.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 76, 129);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(964, 54);
            panel2.TabIndex = 0;
            // 
            // BloodReceiver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1049, 890);
            Controls.Add(panel1);
            Name = "BloodReceiver";
            Text = "BloodReceiver";
            Load += BloodReceiver_Load;
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button btnSubmit;
        private Label label17;
        private TextBox txtDoctorPhoneNumber;
        private Label label15;
        private Label label16;
        private ComboBox drpBloodGivenBefore;
        private Label label14;
        private ComboBox drpOccupation;
        private Label label13;
        private ComboBox drpGender;
        private Label label12;
        private Label label11;
        private DateTimePicker dtpReceivingDate;
        private Label label10;
        private ComboBox drpBloodGroup;
        private Label label9;
        private Label label1;
        private TextBox txtDoctorName;
        private Panel panel1;
        private Panel panel5;
        private Label label8;
        private TextBox txtHospitalPhoneNumber;
        private Label label7;
        private TextBox txtHospitalName;
        private Label label6;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private Label label3;
        private Label label4;
        private Label label2;
        private TextBox txtWeight;
        private TextBox txtAge;
        private TextBox txtName;
        private Panel panel2;
        private TextBox txtDescription;
        private Label label18;
        private TextBox txtBloodRequired;
        private Label label19;
    }
}