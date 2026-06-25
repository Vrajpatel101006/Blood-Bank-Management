namespace BloodBank
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            pictureBox2 = new PictureBox();
            pictureBox6 = new PictureBox();
            txtPassword = new TextBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            panel7 = new Panel();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            txtUserName = new TextBox();
            label1 = new Label();
            btnSignup = new Button();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            txtEmail = new TextBox();
            label6 = new Label();
            txtPhoneNo = new TextBox();
            panel5 = new Panel();
            cmbRole = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(42, 123);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(328, 314);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(272, 366);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 34);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.AccessibleDescription = "Password must countain atleast one number, special character, and maxlength upto12  ";
            txtPassword.AccessibleRole = AccessibleRole.Cursor;
            txtPassword.BackColor = Color.FromArgb(176, 190, 197);
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(72, 366);
            txtPassword.Margin = new Padding(2);
            txtPassword.MaxLength = 12;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(211, 33);
            txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(55, 71, 79);
            label3.Location = new Point(71, 346);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 18);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(2, 0);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(370, 148);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(21, 101, 192);
            label5.Location = new Point(248, 532);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 9;
            label5.Text = "Log In";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(66, 534);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(178, 17);
            label4.TabIndex = 8;
            label4.Text = "Already have an Account?";
            // 
            // pictureBox5
            // 
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(272, 230);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 34);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(pictureBox2);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(375, 560);
            panel7.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(272, 167);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(55, 71, 79);
            label2.Location = new Point(72, 210);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 18);
            label2.TabIndex = 3;
            label2.Text = "Phone No.";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(176, 190, 197);
            txtUserName.Cursor = Cursors.IBeam;
            txtUserName.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(72, 167);
            txtUserName.Margin = new Padding(2);
            txtUserName.MaxLength = 50;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(211, 33);
            txtUserName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(55, 71, 79);
            label1.Location = new Point(72, 147);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 18);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.FromArgb(25, 118, 210);
            btnSignup.ForeColor = SystemColors.Control;
            btnSignup.Location = new Point(103, 476);
            btnSignup.Margin = new Padding(2);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(165, 55);
            btnSignup.TabIndex = 4;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(label7);
            panel6.Controls.Add(cmbRole);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(txtEmail);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(pictureBox6);
            panel6.Controls.Add(txtPassword);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(pictureBox5);
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(txtPhoneNo);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(txtUserName);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(btnSignup);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(376, 0);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(374, 560);
            panel6.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(272, 302);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.AccessibleDescription = "";
            txtEmail.BackColor = Color.FromArgb(176, 190, 197);
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(72, 302);
            txtEmail.Margin = new Padding(2);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 33);
            txtEmail.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(55, 71, 79);
            label6.Location = new Point(72, 282);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(158, 18);
            label6.TabIndex = 13;
            label6.Text = "Email(Optional)";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.AccessibleDescription = "";
            txtPhoneNo.BackColor = Color.FromArgb(176, 190, 197);
            txtPhoneNo.Cursor = Cursors.IBeam;
            txtPhoneNo.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNo.Location = new Point(72, 230);
            txtPhoneNo.Margin = new Padding(2);
            txtPhoneNo.MaxLength = 50;
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(211, 33);
            txtPhoneNo.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(162, 90);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(750, 560);
            panel5.TabIndex = 1;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Manager", "Staff" });
            cmbRole.Location = new Point(72, 436);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(217, 23);
            cmbRole.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(55, 71, 79);
            label7.Location = new Point(72, 415);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(58, 18);
            label7.TabIndex = 17;
            label7.Text = "Roles";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 242, 248);
            ClientSize = new Size(1074, 751);
            ControlBox = false;
            Controls.Add(panel5);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private TextBox txtPassword;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox5;
        private Panel panel7;
        private PictureBox pictureBox4;
        private Label label2;
        private TextBox txtUserName;
        private Label label1;
        private Button btnSignup;
        private Panel panel6;
        private TextBox txtPhoneNo;
        private Panel panel5;
        private PictureBox pictureBox1;
        private TextBox txtEmail;
        private Label label6;
        private Label label7;
        private ComboBox cmbRole;
    }
}