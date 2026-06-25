namespace BloodBank
{
    partial class DonorList
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
            panel1 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            btnClearSearchFields = new Button();
            btnCancelSearch = new Button();
            btnSearch = new Button();
            label12 = new Label();
            drpSearchUserGender = new ComboBox();
            label13 = new Label();
            txtSearchUserPhoneNo = new TextBox();
            txtSearchUserEmail = new TextBox();
            label14 = new Label();
            drpSearchUserBloodGroup = new ComboBox();
            label15 = new Label();
            txtSearchUserAge = new TextBox();
            label16 = new Label();
            label17 = new Label();
            txtSearchUserName = new TextBox();
            panel5 = new Panel();
            btnCancel = new Button();
            btnChange = new Button();
            drpOccupation = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            txtDonorAddress = new TextBox();
            label7 = new Label();
            drpGender = new ComboBox();
            label9 = new Label();
            txtDonorPhonenumber = new TextBox();
            txtDonorEmail = new TextBox();
            label8 = new Label();
            drpBloodGroup = new ComboBox();
            label3 = new Label();
            txtDonorAge = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtDonorName = new TextBox();
            panel4 = new Panel();
            btnAddDonor = new Button();
            btnSearchUserPanel = new Button();
            btnResetList = new Button();
            btnUpdate = new Button();
            btnViewDonor = new Button();
            btnDeleteUser = new Button();
            dgvDonorlist = new DataGridView();
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonorlist).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(27, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1454, 967);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.InactiveCaption;
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel5);
            panel6.Controls.Add(panel4);
            panel6.Controls.Add(dgvDonorlist);
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
            panel7.Controls.Add(btnClearSearchFields);
            panel7.Controls.Add(btnCancelSearch);
            panel7.Controls.Add(btnSearch);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(drpSearchUserGender);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(txtSearchUserPhoneNo);
            panel7.Controls.Add(txtSearchUserEmail);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(drpSearchUserBloodGroup);
            panel7.Controls.Add(label15);
            panel7.Controls.Add(txtSearchUserAge);
            panel7.Controls.Add(label16);
            panel7.Controls.Add(label17);
            panel7.Controls.Add(txtSearchUserName);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 298);
            panel7.Name = "panel7";
            panel7.Size = new Size(1454, 257);
            panel7.TabIndex = 8;
            panel7.Visible = false;
            // 
            // btnClearSearchFields
            // 
            btnClearSearchFields.BackColor = Color.FromArgb(96, 125, 139);
            btnClearSearchFields.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearSearchFields.ForeColor = Color.White;
            btnClearSearchFields.Location = new Point(811, 114);
            btnClearSearchFields.Name = "btnClearSearchFields";
            btnClearSearchFields.Size = new Size(200, 40);
            btnClearSearchFields.TabIndex = 7;
            btnClearSearchFields.Text = "Clear Search";
            btnClearSearchFields.UseVisualStyleBackColor = false;
            btnClearSearchFields.Click += btnClearSearchFields_Click;
            // 
            // btnCancelSearch
            // 
            btnCancelSearch.BackColor = Color.FromArgb(211, 47, 47);
            btnCancelSearch.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelSearch.ForeColor = Color.White;
            btnCancelSearch.Location = new Point(1061, 51);
            btnCancelSearch.Name = "btnCancelSearch";
            btnCancelSearch.Size = new Size(200, 40);
            btnCancelSearch.TabIndex = 8;
            btnCancelSearch.Text = "Cancel";
            btnCancelSearch.UseVisualStyleBackColor = false;
            btnCancelSearch.Click += btnCancelSearch_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(96, 125, 139);
            btnSearch.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(811, 51);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(200, 40);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(175, 88);
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
            drpSearchUserGender.Location = new Point(593, 124);
            drpSearchUserGender.Margin = new Padding(2, 1, 2, 1);
            drpSearchUserGender.Name = "drpSearchUserGender";
            drpSearchUserGender.Size = new Size(143, 23);
            drpSearchUserGender.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(496, 124);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(86, 23);
            label13.TabIndex = 33;
            label13.Text = "Gender :";
            // 
            // txtSearchUserPhoneNo
            // 
            txtSearchUserPhoneNo.BackColor = Color.Lavender;
            txtSearchUserPhoneNo.Location = new Point(264, 124);
            txtSearchUserPhoneNo.Margin = new Padding(2, 1, 2, 1);
            txtSearchUserPhoneNo.MaxLength = 10;
            txtSearchUserPhoneNo.Name = "txtSearchUserPhoneNo";
            txtSearchUserPhoneNo.Size = new Size(156, 23);
            txtSearchUserPhoneNo.TabIndex = 2;
            // 
            // txtSearchUserEmail
            // 
            txtSearchUserEmail.BackColor = Color.Lavender;
            txtSearchUserEmail.Location = new Point(264, 88);
            txtSearchUserEmail.Margin = new Padding(2, 1, 2, 1);
            txtSearchUserEmail.MaxLength = 50;
            txtSearchUserEmail.Name = "txtSearchUserEmail";
            txtSearchUserEmail.Size = new Size(472, 23);
            txtSearchUserEmail.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(146, 124);
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
            drpSearchUserBloodGroup.Location = new Point(593, 163);
            drpSearchUserBloodGroup.Margin = new Padding(2, 1, 2, 1);
            drpSearchUserBloodGroup.Name = "drpSearchUserBloodGroup";
            drpSearchUserBloodGroup.Size = new Size(143, 23);
            drpSearchUserBloodGroup.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(141, 163);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(114, 23);
            label15.TabIndex = 23;
            label15.Text = "Donor Age :";
            // 
            // txtSearchUserAge
            // 
            txtSearchUserAge.BackColor = Color.Lavender;
            txtSearchUserAge.Location = new Point(264, 166);
            txtSearchUserAge.Margin = new Padding(2, 1, 2, 1);
            txtSearchUserAge.MaxLength = 3;
            txtSearchUserAge.Name = "txtSearchUserAge";
            txtSearchUserAge.Size = new Size(156, 23);
            txtSearchUserAge.TabIndex = 4;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(450, 163);
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
            label17.Location = new Point(122, 51);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(133, 23);
            label17.TabIndex = 20;
            label17.Text = "Donor Name :";
            // 
            // txtSearchUserName
            // 
            txtSearchUserName.BackColor = Color.Lavender;
            txtSearchUserName.Location = new Point(264, 51);
            txtSearchUserName.Margin = new Padding(2, 1, 2, 1);
            txtSearchUserName.MaxLength = 50;
            txtSearchUserName.Name = "txtSearchUserName";
            txtSearchUserName.Size = new Size(472, 23);
            txtSearchUserName.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(240, 253, 244);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnCancel);
            panel5.Controls.Add(btnChange);
            panel5.Controls.Add(drpOccupation);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(txtDonorAddress);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(drpGender);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(txtDonorPhonenumber);
            panel5.Controls.Add(txtDonorEmail);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(drpBloodGroup);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txtDonorAge);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(txtDonorName);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 56);
            panel5.Name = "panel5";
            panel5.Size = new Size(1454, 242);
            panel5.TabIndex = 7;
            panel5.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(211, 47, 47);
            btnCancel.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1061, 157);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(200, 40);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.FromArgb(46, 125, 50);
            btnChange.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChange.ForeColor = Color.White;
            btnChange.Location = new Point(811, 157);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(200, 40);
            btnChange.TabIndex = 8;
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
            drpOccupation.Location = new Point(262, 157);
            drpOccupation.Margin = new Padding(2, 1, 2, 1);
            drpOccupation.Name = "drpOccupation";
            drpOccupation.Size = new Size(425, 23);
            drpOccupation.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(133, 157);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(120, 23);
            label10.TabIndex = 17;
            label10.Text = "Occupation :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(752, 82);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(92, 23);
            label11.TabIndex = 14;
            label11.Text = "Address :";
            // 
            // txtDonorAddress
            // 
            txtDonorAddress.BackColor = Color.Lavender;
            txtDonorAddress.Location = new Point(855, 82);
            txtDonorAddress.Margin = new Padding(2, 1, 2, 1);
            txtDonorAddress.MaxLength = 150;
            txtDonorAddress.Multiline = true;
            txtDonorAddress.Name = "txtDonorAddress";
            txtDonorAddress.Size = new Size(464, 56);
            txtDonorAddress.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(173, 79);
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
            drpGender.Location = new Point(584, 115);
            drpGender.Margin = new Padding(2, 1, 2, 1);
            drpGender.Name = "drpGender";
            drpGender.Size = new Size(103, 23);
            drpGender.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(494, 115);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(86, 23);
            label9.TabIndex = 13;
            label9.Text = "Gender :";
            // 
            // txtDonorPhonenumber
            // 
            txtDonorPhonenumber.BackColor = Color.Lavender;
            txtDonorPhonenumber.Location = new Point(262, 115);
            txtDonorPhonenumber.Margin = new Padding(2, 1, 2, 1);
            txtDonorPhonenumber.MaxLength = 10;
            txtDonorPhonenumber.Name = "txtDonorPhonenumber";
            txtDonorPhonenumber.Size = new Size(156, 23);
            txtDonorPhonenumber.TabIndex = 4;
            // 
            // txtDonorEmail
            // 
            txtDonorEmail.BackColor = Color.Lavender;
            txtDonorEmail.Location = new Point(262, 79);
            txtDonorEmail.Margin = new Padding(2, 1, 2, 1);
            txtDonorEmail.MaxLength = 50;
            txtDonorEmail.Name = "txtDonorEmail";
            txtDonorEmail.Size = new Size(425, 23);
            txtDonorEmail.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(144, 115);
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
            drpBloodGroup.Location = new Point(1197, 39);
            drpBloodGroup.Margin = new Padding(2, 1, 2, 1);
            drpBloodGroup.Name = "drpBloodGroup";
            drpBloodGroup.Size = new Size(122, 23);
            drpBloodGroup.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(732, 42);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 23);
            label3.TabIndex = 3;
            label3.Text = "Donor Age :";
            // 
            // txtDonorAge
            // 
            txtDonorAge.BackColor = Color.Lavender;
            txtDonorAge.Location = new Point(855, 42);
            txtDonorAge.Margin = new Padding(2, 1, 2, 1);
            txtDonorAge.MaxLength = 3;
            txtDonorAge.Name = "txtDonorAge";
            txtDonorAge.Size = new Size(156, 23);
            txtDonorAge.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1061, 42);
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
            label2.Location = new Point(120, 42);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 23);
            label2.TabIndex = 1;
            label2.Text = "Donor Name :";
            // 
            // txtDonorName
            // 
            txtDonorName.BackColor = Color.Lavender;
            txtDonorName.Location = new Point(262, 42);
            txtDonorName.Margin = new Padding(2, 1, 2, 1);
            txtDonorName.MaxLength = 50;
            txtDonorName.Name = "txtDonorName";
            txtDonorName.Size = new Size(425, 23);
            txtDonorName.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(240, 253, 244);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnAddDonor);
            panel4.Controls.Add(btnSearchUserPanel);
            panel4.Controls.Add(btnResetList);
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(btnViewDonor);
            panel4.Controls.Add(btnDeleteUser);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1454, 56);
            panel4.TabIndex = 6;
            // 
            // btnAddDonor
            // 
            btnAddDonor.BackColor = Color.FromArgb(2, 136, 209);
            btnAddDonor.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddDonor.ForeColor = Color.White;
            btnAddDonor.Location = new Point(1230, 9);
            btnAddDonor.Name = "btnAddDonor";
            btnAddDonor.Size = new Size(192, 40);
            btnAddDonor.TabIndex = 6;
            btnAddDonor.Text = "Add Donor";
            btnAddDonor.UseVisualStyleBackColor = false;
            btnAddDonor.Click += btnAddDonor_Click;
            // 
            // btnSearchUserPanel
            // 
            btnSearchUserPanel.BackColor = Color.FromArgb(2, 136, 209);
            btnSearchUserPanel.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchUserPanel.ForeColor = Color.White;
            btnSearchUserPanel.Location = new Point(264, 9);
            btnSearchUserPanel.Name = "btnSearchUserPanel";
            btnSearchUserPanel.Size = new Size(192, 40);
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
            btnResetList.Location = new Point(1001, 8);
            btnResetList.Name = "btnResetList";
            btnResetList.Size = new Size(192, 40);
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
            btnUpdate.Location = new Point(514, 9);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(192, 40);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update Details";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnViewDonor
            // 
            btnViewDonor.BackColor = Color.FromArgb(25, 118, 210);
            btnViewDonor.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewDonor.ForeColor = Color.White;
            btnViewDonor.Location = new Point(31, 8);
            btnViewDonor.Name = "btnViewDonor";
            btnViewDonor.Size = new Size(192, 40);
            btnViewDonor.TabIndex = 0;
            btnViewDonor.Text = "View Donor List";
            btnViewDonor.UseVisualStyleBackColor = false;
            btnViewDonor.Click += btnViewDonor_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.FromArgb(211, 47, 47);
            btnDeleteUser.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.Location = new Point(752, 8);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(192, 40);
            btnDeleteUser.TabIndex = 3;
            btnDeleteUser.Text = "Remove User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // dgvDonorlist
            // 
            dgvDonorlist.BackgroundColor = Color.FromArgb(240, 253, 244);
            dgvDonorlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonorlist.Dock = DockStyle.Bottom;
            dgvDonorlist.Location = new Point(0, 555);
            dgvDonorlist.Name = "dgvDonorlist";
            dgvDonorlist.Size = new Size(1454, 292);
            dgvDonorlist.TabIndex = 5;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(585, 19);
            label1.Name = "label1";
            label1.Size = new Size(252, 38);
            label1.TabIndex = 0;
            label1.Text = "Donor Details";
            // 
            // DonorList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1677, 1061);
            Controls.Add(panel1);
            Name = "DonorList";
            Text = "DonorList";
            Load += DonorList_Load;
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDonorlist).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel6;
        private Panel panel3;
        private Panel panel2;
        private Button btnViewDonor;
        private Button btnResetList;
        private Button btnDeleteUser;
        private Button btnUpdate;
        private DataGridView dgvDonorlist;
        private Label label1;
        private Panel panel4;
        private Panel panel5;
        private Label label2;
        private TextBox txtDonorName;
        private ComboBox drpBloodGroup;
        private Label label3;
        private TextBox txtDonorAge;
        private Label label4;
        private Label label7;
        private ComboBox drpGender;
        private Label label9;
        private TextBox txtDonorPhonenumber;
        private TextBox txtDonorEmail;
        private Label label8;
        private Label label11;
        private TextBox txtDonorAddress;
        private ComboBox drpOccupation;
        private Label label10;
        private Button btnChange;
        private Button btnCancel;
        private Button btnSearchUserPanel;
        private Panel panel7;
        private Button btnCancelSearch;
        private Button btnSearch;
        private Label label12;
        private ComboBox drpSearchUserGender;
        private Label label13;
        private TextBox txtSearchUserPhoneNo;
        private TextBox txtSearchUserEmail;
        private Label label14;
        private ComboBox drpSearchUserBloodGroup;
        private Label label15;
        private TextBox txtSearchUserAge;
        private Label label16;
        private Label label17;
        private TextBox txtSearchUserName;
        private Button btnClearSearchFields;
        private Button btnAddDonor;
    }
}