namespace BloodBank
{
    partial class RecipientList
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
            label1 = new Label();
            panel3 = new Panel();
            dgvRecipientList = new DataGridView();
            btnSearchUserPanel = new Button();
            btnResetList = new Button();
            btnUpdate = new Button();
            btnViewRecipient = new Button();
            btnDeleteUser = new Button();
            panel4 = new Panel();
            btnAddRecipient = new Button();
            panel2 = new Panel();
            btnCancel = new Button();
            btnChange = new Button();
            drpOccupation = new ComboBox();
            label10 = new Label();
            panel5 = new Panel();
            txtBloodGiven = new TextBox();
            label18 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtDoctorName = new TextBox();
            txtHospitalName = new TextBox();
            label11 = new Label();
            txtRecipientAddress = new TextBox();
            label7 = new Label();
            drpGender = new ComboBox();
            label9 = new Label();
            txtRecipientPhonenumber = new TextBox();
            txtRecipientEmail = new TextBox();
            label8 = new Label();
            drpBloodGroup = new ComboBox();
            label3 = new Label();
            txtRecipientAge = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtRecipientName = new TextBox();
            txtSearchUserName = new TextBox();
            panel1 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            txtSearchUserBloodGiven = new TextBox();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            txtSearchUserDoctor = new TextBox();
            txtSearchUserHospital = new TextBox();
            btnClearSearchFields = new Button();
            btnCancelSearch = new Button();
            btnSearch = new Button();
            label12 = new Label();
            drpSearchUserGender = new ComboBox();
            label13 = new Label();
            txtSearchUserPhoneNumber = new TextBox();
            txtSearchUserEmail = new TextBox();
            label14 = new Label();
            drpSearchUserBloodGroup = new ComboBox();
            label15 = new Label();
            txtSearchUserAge = new TextBox();
            label16 = new Label();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRecipientList).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(576, 19);
            label1.Name = "label1";
            label1.Size = new Size(305, 38);
            label1.TabIndex = 0;
            label1.Text = "Recipient Details";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(15, 76, 129);
            panel3.Dock = DockStyle.Bottom;
            panel3.ForeColor = Color.FromArgb(167, 243, 208);
            panel3.Location = new Point(0, 907);
            panel3.Name = "panel3";
            panel3.Size = new Size(1454, 60);
            panel3.TabIndex = 1;
            // 
            // dgvRecipientList
            // 
            dgvRecipientList.BackgroundColor = Color.FromArgb(240, 253, 244);
            dgvRecipientList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipientList.Dock = DockStyle.Bottom;
            dgvRecipientList.Location = new Point(0, 583);
            dgvRecipientList.Name = "dgvRecipientList";
            dgvRecipientList.Size = new Size(1454, 264);
            dgvRecipientList.TabIndex = 5;
            // 
            // btnSearchUserPanel
            // 
            btnSearchUserPanel.BackColor = Color.FromArgb(2, 136, 209);
            btnSearchUserPanel.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchUserPanel.ForeColor = Color.White;
            btnSearchUserPanel.Location = new Point(262, 5);
            btnSearchUserPanel.Name = "btnSearchUserPanel";
            btnSearchUserPanel.Size = new Size(197, 40);
            btnSearchUserPanel.TabIndex = 1;
            btnSearchUserPanel.Text = "Search User";
            btnSearchUserPanel.UseVisualStyleBackColor = false;
            btnSearchUserPanel.Click += btnSearchUserPanel_Click;
            // 
            // btnResetList
            // 
            btnResetList.BackColor = Color.FromArgb(96, 125, 139);
            btnResetList.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResetList.ForeColor = Color.White;
            btnResetList.Location = new Point(996, 5);
            btnResetList.Name = "btnResetList";
            btnResetList.Size = new Size(197, 40);
            btnResetList.TabIndex = 4;
            btnResetList.Text = "Reset List";
            btnResetList.UseVisualStyleBackColor = false;
            btnResetList.Click += btnResetList_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(46, 125, 50);
            btnUpdate.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(509, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(197, 40);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update Details";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnViewRecipient
            // 
            btnViewRecipient.BackColor = Color.FromArgb(25, 118, 210);
            btnViewRecipient.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewRecipient.ForeColor = Color.White;
            btnViewRecipient.Location = new Point(20, 4);
            btnViewRecipient.Name = "btnViewRecipient";
            btnViewRecipient.Size = new Size(197, 40);
            btnViewRecipient.TabIndex = 0;
            btnViewRecipient.Text = "View Recipient List";
            btnViewRecipient.UseVisualStyleBackColor = false;
            btnViewRecipient.Click += btnViewRecipient_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.FromArgb(211, 47, 47);
            btnDeleteUser.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.Location = new Point(752, 5);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(197, 40);
            btnDeleteUser.TabIndex = 3;
            btnDeleteUser.Text = "Remove User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(240, 253, 244);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnAddRecipient);
            panel4.Controls.Add(btnSearchUserPanel);
            panel4.Controls.Add(btnResetList);
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(btnViewRecipient);
            panel4.Controls.Add(btnDeleteUser);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1454, 56);
            panel4.TabIndex = 6;
            // 
            // btnAddRecipient
            // 
            btnAddRecipient.BackColor = Color.FromArgb(2, 136, 209);
            btnAddRecipient.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddRecipient.ForeColor = Color.White;
            btnAddRecipient.Location = new Point(1237, 5);
            btnAddRecipient.Name = "btnAddRecipient";
            btnAddRecipient.Size = new Size(197, 40);
            btnAddRecipient.TabIndex = 5;
            btnAddRecipient.Text = "Add Recipient";
            btnAddRecipient.UseVisualStyleBackColor = false;
            btnAddRecipient.Click += btnAddRecipient_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 76, 129);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1454, 60);
            panel2.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(211, 47, 47);
            btnCancel.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1047, 172);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(235, 40);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.FromArgb(46, 125, 50);
            btnChange.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChange.ForeColor = Color.White;
            btnChange.Location = new Point(797, 172);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(235, 40);
            btnChange.TabIndex = 11;
            btnChange.Text = "Update";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // drpOccupation
            // 
            drpOccupation.AllowDrop = true;
            drpOccupation.BackColor = Color.Lavender;
            drpOccupation.DropDownStyle = ComboBoxStyle.DropDownList;
            drpOccupation.FormattingEnabled = true;
            drpOccupation.Items.AddRange(new object[] { "Business / Self-Employed", "Corporate / Private Sector Job", "Driver / Pilot / Operator", "Farmer", "Government Service", "Healthcare / Medical Professional", "Laborer", "Military / Law Enforcement ", "Retired", "Sport person / Athlete", "Student", "Unemployed", "Other" });
            drpOccupation.Location = new Point(226, 133);
            drpOccupation.Margin = new Padding(2, 1, 2, 1);
            drpOccupation.Name = "drpOccupation";
            drpOccupation.Size = new Size(460, 23);
            drpOccupation.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(98, 130);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(120, 23);
            label10.TabIndex = 17;
            label10.Text = "Occupation :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(240, 253, 244);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txtBloodGiven);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(txtDoctorName);
            panel5.Controls.Add(txtHospitalName);
            panel5.Controls.Add(btnCancel);
            panel5.Controls.Add(btnChange);
            panel5.Controls.Add(drpOccupation);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(txtRecipientAddress);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(drpGender);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(txtRecipientPhonenumber);
            panel5.Controls.Add(txtRecipientEmail);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(drpBloodGroup);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txtRecipientAge);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(txtRecipientName);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 56);
            panel5.Name = "panel5";
            panel5.Size = new Size(1454, 277);
            panel5.TabIndex = 7;
            panel5.Visible = false;
            // 
            // txtBloodGiven
            // 
            txtBloodGiven.BackColor = Color.Lavender;
            txtBloodGiven.Location = new Point(859, 127);
            txtBloodGiven.MaxLength = 3;
            txtBloodGiven.Name = "txtBloodGiven";
            txtBloodGiven.Size = new Size(195, 23);
            txtBloodGiven.TabIndex = 8;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century", 13.8F);
            label18.ForeColor = SystemColors.ControlText;
            label18.Location = new Point(728, 127);
            label18.Name = "label18";
            label18.Size = new Size(127, 23);
            label18.TabIndex = 23;
            label18.Text = "Given Units :";
            label18.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 13.8F);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(80, 208);
            label5.Name = "label5";
            label5.Size = new Size(136, 23);
            label5.TabIndex = 20;
            label5.Text = "Doctor Name :\r\n";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 13.8F);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(64, 166);
            label6.Name = "label6";
            label6.Size = new Size(154, 23);
            label6.TabIndex = 18;
            label6.Text = "Hospital Name :";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtDoctorName
            // 
            txtDoctorName.BackColor = Color.Lavender;
            txtDoctorName.Location = new Point(226, 214);
            txtDoctorName.MaxLength = 50;
            txtDoctorName.Name = "txtDoctorName";
            txtDoctorName.Size = new Size(460, 23);
            txtDoctorName.TabIndex = 10;
            // 
            // txtHospitalName
            // 
            txtHospitalName.BackColor = Color.Lavender;
            txtHospitalName.Location = new Point(226, 172);
            txtHospitalName.MaxLength = 50;
            txtHospitalName.Name = "txtHospitalName";
            txtHospitalName.Size = new Size(460, 23);
            txtHospitalName.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(762, 58);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(92, 23);
            label11.TabIndex = 14;
            label11.Text = "Address :";
            // 
            // txtRecipientAddress
            // 
            txtRecipientAddress.BackColor = Color.Lavender;
            txtRecipientAddress.Location = new Point(859, 58);
            txtRecipientAddress.Margin = new Padding(2, 1, 2, 1);
            txtRecipientAddress.MaxLength = 150;
            txtRecipientAddress.Multiline = true;
            txtRecipientAddress.Name = "txtRecipientAddress";
            txtRecipientAddress.Size = new Size(517, 56);
            txtRecipientAddress.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(136, 52);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 23);
            label7.TabIndex = 8;
            label7.Text = "E-mail :";
            // 
            // drpGender
            // 
            drpGender.BackColor = Color.Lavender;
            drpGender.DropDownStyle = ComboBoxStyle.DropDownList;
            drpGender.FormattingEnabled = true;
            drpGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            drpGender.Location = new Point(548, 91);
            drpGender.Margin = new Padding(2, 1, 2, 1);
            drpGender.Name = "drpGender";
            drpGender.Size = new Size(138, 23);
            drpGender.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(458, 91);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(86, 23);
            label9.TabIndex = 13;
            label9.Text = "Gender :";
            // 
            // txtRecipientPhonenumber
            // 
            txtRecipientPhonenumber.BackColor = Color.Lavender;
            txtRecipientPhonenumber.Location = new Point(226, 91);
            txtRecipientPhonenumber.Margin = new Padding(2, 1, 2, 1);
            txtRecipientPhonenumber.MaxLength = 10;
            txtRecipientPhonenumber.Name = "txtRecipientPhonenumber";
            txtRecipientPhonenumber.Size = new Size(191, 23);
            txtRecipientPhonenumber.TabIndex = 4;
            // 
            // txtRecipientEmail
            // 
            txtRecipientEmail.BackColor = Color.Lavender;
            txtRecipientEmail.Location = new Point(226, 55);
            txtRecipientEmail.Margin = new Padding(2, 1, 2, 1);
            txtRecipientEmail.MaxLength = 50;
            txtRecipientEmail.Name = "txtRecipientEmail";
            txtRecipientEmail.Size = new Size(460, 23);
            txtRecipientEmail.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(107, 88);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(109, 23);
            label8.TabIndex = 11;
            label8.Text = "Phone no. :";
            // 
            // drpBloodGroup
            // 
            drpBloodGroup.BackColor = Color.Lavender;
            drpBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            drpBloodGroup.Enabled = false;
            drpBloodGroup.FormattingEnabled = true;
            drpBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            drpBloodGroup.Location = new Point(1207, 15);
            drpBloodGroup.Margin = new Padding(2, 1, 2, 1);
            drpBloodGroup.Name = "drpBloodGroup";
            drpBloodGroup.Size = new Size(169, 23);
            drpBloodGroup.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(712, 15);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 23);
            label3.TabIndex = 3;
            label3.Text = "Recipient Age :";
            // 
            // txtRecipientAge
            // 
            txtRecipientAge.BackColor = Color.Lavender;
            txtRecipientAge.Location = new Point(859, 18);
            txtRecipientAge.Margin = new Padding(2, 1, 2, 1);
            txtRecipientAge.MaxLength = 3;
            txtRecipientAge.Name = "txtRecipientAge";
            txtRecipientAge.Size = new Size(194, 23);
            txtRecipientAge.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1071, 15);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 23);
            label4.TabIndex = 6;
            label4.Text = "Blood Group :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(52, 18);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(162, 23);
            label2.TabIndex = 1;
            label2.Text = "Recipient Name :";
            // 
            // txtRecipientName
            // 
            txtRecipientName.BackColor = Color.Lavender;
            txtRecipientName.Location = new Point(226, 18);
            txtRecipientName.Margin = new Padding(2, 1, 2, 1);
            txtRecipientName.MaxLength = 50;
            txtRecipientName.Name = "txtRecipientName";
            txtRecipientName.Size = new Size(460, 23);
            txtRecipientName.TabIndex = 0;
            // 
            // txtSearchUserName
            // 
            txtSearchUserName.BackColor = Color.Lavender;
            txtSearchUserName.Location = new Point(222, 32);
            txtSearchUserName.Margin = new Padding(2, 1, 2, 1);
            txtSearchUserName.MaxLength = 50;
            txtSearchUserName.Name = "txtSearchUserName";
            txtSearchUserName.Size = new Size(455, 23);
            txtSearchUserName.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(85, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(1454, 967);
            panel1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.InactiveCaption;
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel5);
            panel6.Controls.Add(panel4);
            panel6.Controls.Add(dgvRecipientList);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 60);
            panel6.Name = "panel6";
            panel6.Size = new Size(1454, 847);
            panel6.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(240, 253, 244);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(txtSearchUserBloodGiven);
            panel7.Controls.Add(label19);
            panel7.Controls.Add(label20);
            panel7.Controls.Add(label21);
            panel7.Controls.Add(txtSearchUserDoctor);
            panel7.Controls.Add(txtSearchUserHospital);
            panel7.Controls.Add(btnClearSearchFields);
            panel7.Controls.Add(btnCancelSearch);
            panel7.Controls.Add(btnSearch);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(drpSearchUserGender);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(txtSearchUserPhoneNumber);
            panel7.Controls.Add(txtSearchUserEmail);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(drpSearchUserBloodGroup);
            panel7.Controls.Add(label15);
            panel7.Controls.Add(txtSearchUserAge);
            panel7.Controls.Add(label16);
            panel7.Controls.Add(label17);
            panel7.Controls.Add(txtSearchUserName);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 333);
            panel7.Name = "panel7";
            panel7.Size = new Size(1454, 250);
            panel7.TabIndex = 8;
            panel7.Visible = false;
            // 
            // txtSearchUserBloodGiven
            // 
            txtSearchUserBloodGiven.BackColor = Color.Lavender;
            txtSearchUserBloodGiven.Location = new Point(859, 81);
            txtSearchUserBloodGiven.MaxLength = 3;
            txtSearchUserBloodGiven.Name = "txtSearchUserBloodGiven";
            txtSearchUserBloodGiven.Size = new Size(194, 23);
            txtSearchUserBloodGiven.TabIndex = 39;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Century", 13.8F);
            label19.ForeColor = SystemColors.ControlText;
            label19.Location = new Point(728, 81);
            label19.Name = "label19";
            label19.Size = new Size(127, 23);
            label19.TabIndex = 40;
            label19.Text = "Given Units :";
            label19.TextAlign = ContentAlignment.TopCenter;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Century", 13.8F);
            label20.ForeColor = SystemColors.ControlText;
            label20.Location = new Point(78, 173);
            label20.Name = "label20";
            label20.Size = new Size(136, 23);
            label20.TabIndex = 37;
            label20.Text = "Doctor Name :\r\n";
            label20.TextAlign = ContentAlignment.TopCenter;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Century", 13.8F);
            label21.ForeColor = SystemColors.ControlText;
            label21.Location = new Point(62, 141);
            label21.Name = "label21";
            label21.Size = new Size(154, 23);
            label21.TabIndex = 35;
            label21.Text = "Hospital Name :";
            label21.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtSearchUserDoctor
            // 
            txtSearchUserDoctor.BackColor = Color.Lavender;
            txtSearchUserDoctor.Location = new Point(222, 176);
            txtSearchUserDoctor.MaxLength = 50;
            txtSearchUserDoctor.Name = "txtSearchUserDoctor";
            txtSearchUserDoctor.Size = new Size(455, 23);
            txtSearchUserDoctor.TabIndex = 38;
            // 
            // txtSearchUserHospital
            // 
            txtSearchUserHospital.BackColor = Color.Lavender;
            txtSearchUserHospital.Location = new Point(222, 144);
            txtSearchUserHospital.MaxLength = 50;
            txtSearchUserHospital.Name = "txtSearchUserHospital";
            txtSearchUserHospital.Size = new Size(455, 23);
            txtSearchUserHospital.TabIndex = 36;
            // 
            // btnClearSearchFields
            // 
            btnClearSearchFields.BackColor = Color.FromArgb(96, 125, 139);
            btnClearSearchFields.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearSearchFields.ForeColor = Color.White;
            btnClearSearchFields.Location = new Point(797, 176);
            btnClearSearchFields.Name = "btnClearSearchFields";
            btnClearSearchFields.Size = new Size(235, 40);
            btnClearSearchFields.TabIndex = 34;
            btnClearSearchFields.Text = "Clear Search";
            btnClearSearchFields.UseVisualStyleBackColor = false;
            btnClearSearchFields.Click += btnClearSearchFields_Click;
            // 
            // btnCancelSearch
            // 
            btnCancelSearch.BackColor = Color.FromArgb(211, 47, 47);
            btnCancelSearch.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelSearch.ForeColor = Color.White;
            btnCancelSearch.Location = new Point(1047, 124);
            btnCancelSearch.Name = "btnCancelSearch";
            btnCancelSearch.Size = new Size(235, 40);
            btnCancelSearch.TabIndex = 31;
            btnCancelSearch.Text = "Cancel";
            btnCancelSearch.UseVisualStyleBackColor = false;
            btnCancelSearch.Click += btnCancelSearch_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(96, 125, 139);
            btnSearch.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(797, 124);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(235, 40);
            btnSearch.TabIndex = 29;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(134, 69);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(80, 23);
            label12.TabIndex = 30;
            label12.Text = "E-mail :";
            // 
            // drpSearchUserGender
            // 
            drpSearchUserGender.BackColor = Color.Lavender;
            drpSearchUserGender.DropDownStyle = ComboBoxStyle.DropDownList;
            drpSearchUserGender.FormattingEnabled = true;
            drpSearchUserGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            drpSearchUserGender.Location = new Point(519, 105);
            drpSearchUserGender.Margin = new Padding(2, 1, 2, 1);
            drpSearchUserGender.Name = "drpSearchUserGender";
            drpSearchUserGender.Size = new Size(158, 23);
            drpSearchUserGender.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(422, 105);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(86, 23);
            label13.TabIndex = 33;
            label13.Text = "Gender :";
            // 
            // txtSearchUserPhoneNumber
            // 
            txtSearchUserPhoneNumber.BackColor = Color.Lavender;
            txtSearchUserPhoneNumber.Location = new Point(222, 105);
            txtSearchUserPhoneNumber.Margin = new Padding(2, 1, 2, 1);
            txtSearchUserPhoneNumber.MaxLength = 10;
            txtSearchUserPhoneNumber.Name = "txtSearchUserPhoneNumber";
            txtSearchUserPhoneNumber.Size = new Size(173, 23);
            txtSearchUserPhoneNumber.TabIndex = 24;
            // 
            // txtSearchUserEmail
            // 
            txtSearchUserEmail.BackColor = Color.Lavender;
            txtSearchUserEmail.Location = new Point(222, 69);
            txtSearchUserEmail.Margin = new Padding(2, 1, 2, 1);
            txtSearchUserEmail.MaxLength = 50;
            txtSearchUserEmail.Name = "txtSearchUserEmail";
            txtSearchUserEmail.Size = new Size(455, 23);
            txtSearchUserEmail.TabIndex = 22;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(105, 105);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(109, 23);
            label14.TabIndex = 32;
            label14.Text = "Phone no. :";
            // 
            // drpSearchUserBloodGroup
            // 
            drpSearchUserBloodGroup.BackColor = Color.Lavender;
            drpSearchUserBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            drpSearchUserBloodGroup.FormattingEnabled = true;
            drpSearchUserBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            drpSearchUserBloodGroup.Location = new Point(1207, 35);
            drpSearchUserBloodGroup.Margin = new Padding(2, 1, 2, 1);
            drpSearchUserBloodGroup.Name = "drpSearchUserBloodGroup";
            drpSearchUserBloodGroup.Size = new Size(158, 23);
            drpSearchUserBloodGroup.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(740, 32);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(114, 23);
            label15.TabIndex = 23;
            label15.Text = "Donor Age :";
            // 
            // txtSearchUserAge
            // 
            txtSearchUserAge.BackColor = Color.Lavender;
            txtSearchUserAge.Location = new Point(859, 35);
            txtSearchUserAge.Margin = new Padding(2, 1, 2, 1);
            txtSearchUserAge.MaxLength = 3;
            txtSearchUserAge.Name = "txtSearchUserAge";
            txtSearchUserAge.Size = new Size(194, 23);
            txtSearchUserAge.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(1071, 35);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(132, 23);
            label16.TabIndex = 27;
            label16.Text = "Blood Group :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(81, 32);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(133, 23);
            label17.TabIndex = 20;
            label17.Text = "Donor Name :";
            // 
            // RecipientList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1677, 1061);
            ControlBox = false;
            Controls.Add(panel1);
            Name = "RecipientList";
            Text = "RecipientList";
            Load += RecipientList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecipientList).EndInit();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel3;
        private DataGridView dgvRecipientList;
        private Button btnSearchUserPanel;
        private Button btnResetList;
        private Button btnUpdate;
        private Button btnViewRecipient;
        private Button btnDeleteUser;
        private Panel panel4;
        private Panel panel2;
        private Button btnCancel;
        private Button btnChange;
        private ComboBox drpOccupation;
        private Label label10;
        private Panel panel5;
        private Label label11;
        private TextBox txtRecipientAddress;
        private Label label7;
        private ComboBox drpGender;
        private Label label9;
        private TextBox txtRecipientPhonenumber;
        private TextBox txtRecipientEmail;
        private Label label8;
        private ComboBox drpBloodGroup;
        private Label label3;
        private TextBox txtRecipientAge;
        private Label label4;
        private Label label2;
        private TextBox txtRecipientName;
        private TextBox txtSearchUserName;
        private Panel panel1;
        private Panel panel6;
        private Panel panel7;
        private Button btnClearSearchFields;
        private Button btnCancelSearch;
        private Button btnSearch;
        private Label label12;
        private ComboBox drpSearchUserGender;
        private Label label13;
        private TextBox txtSearchUserPhoneNumber;
        private TextBox txtSearchUserEmail;
        private Label label14;
        private ComboBox drpSearchUserBloodGroup;
        private Label label15;
        private TextBox txtSearchUserAge;
        private Label label16;
        private Label label17;
        private Label label5;
        private Label label6;
        private TextBox txtDoctorName;
        private TextBox txtHospitalName;
        private TextBox txtBloodGiven;
        private Label label18;
        private TextBox txtSearchUserBloodGiven;
        private Label label19;
        private Label label20;
        private Label label21;
        private TextBox txtSearchUserDoctor;
        private TextBox txtSearchUserHospital;
        private Button btnAddRecipient;
    }
}