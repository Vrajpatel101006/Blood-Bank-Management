using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class Login : Form
    {
        private string connectionString = "Data Source = VRAJPATEL\\SQLEXPRESS; Initial Catalog = dbBloodBank; Integrated Security = True; Encrypt=False;Trust Server Certificate=True";

        public Login()
        {
            InitializeComponent();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
        );

        private void Login_Load(object sender, EventArgs e)
        {
            // THIS is what allows the "Enter" key to trigger the login button!
            this.AcceptButton = btnLogin;

            // Center the main login panel
            if (panel1 != null)
            {
                panel1.Location = new Point(
                    this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                    this.ClientSize.Height / 2 - panel1.Size.Height / 2);
                panel1.Anchor = AnchorStyles.None;
                panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));
            }
        }

        private void ClearForm()
        {
            txtContact.Clear();
            txtPassword.Clear();
            txtContact.Focus();
        }

        // ==========================================
        // NEW, CORRECT CLICK EVENT
        // ==========================================
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Please enter Email or Phone Number.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContact.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter Password.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            string contact = txtContact.Text.Trim();
            string password = txtPassword.Text;

            // Checks if input is an Email OR a Phone Number
            bool isEmail = Regex.IsMatch(contact, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            bool isPhone = Regex.IsMatch(contact, @"^\+?\d{10,15}$");

            if (!isEmail && !isPhone)
            {
                MessageBox.Show("Please enter a valid Email Address or Phone Number.", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContact.Focus();
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // This query handles BOTH Email and Phone inherently. 
                    // It checks if what the user typed matches either column.
                    string authQuery = @"SELECT UserId, DisplayName, PhoneNumber, EmailId 
                                         FROM tblUserMaster 
                                         WHERE (EmailId = @Contact OR PhoneNumber = @Contact) 
                                         AND Password = @Password AND IsActive = 1 AND IsDelete = 0";

                    string authName = "";
                    string authPhone = "";
                    string authEmail = "";

                    using (SqlCommand authCmd = new SqlCommand(authQuery, con))
                    {
                        authCmd.Parameters.AddWithValue("@Contact", contact);
                        authCmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = authCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                authName = reader["DisplayName"]?.ToString() ?? "";
                                authPhone = reader["PhoneNumber"]?.ToString() ?? "";
                                authEmail = reader["EmailId"]?.ToString() ?? "";
                            }
                            else
                            {
                                MessageBox.Show("Invalid Email/Phone or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    // Optional: Log the login details
                    string logQuery = @"INSERT INTO tblLoginDetails (UserName, PhoneNumber, Email, Password, LoginDate) 
                                        VALUES (@Name, @Phone, @Email, @Password, GETDATE())";

                    using (SqlCommand logCmd = new SqlCommand(logQuery, con))
                    {
                        logCmd.Parameters.AddWithValue("@Name", authName);
                        logCmd.Parameters.AddWithValue("@Phone", authPhone);

                        // Handle null emails when logging
                        logCmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(authEmail) ? (object)DBNull.Value : authEmail);
                        logCmd.Parameters.AddWithValue("@Password", password);

                        logCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Welcome back, {authName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();

                    // This logic unlocks the MDI Parent buttons and opens the Dashboard
                    if (this.MdiParent is frmBloodBankMaster parentForm)
                    {
                        parentForm.ToggleSecureMenus(true);
                        parentForm.OpenChildForm(new DonorList());
                    }
                    else
                    {
                        // Fallback just in case you run this form independently
                        DonorList mainForm = new DonorList();
                        this.Hide();
                        mainForm.FormClosed += (s, args) => this.Close();
                        mainForm.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is frmBloodBankMaster parentForm)
            {
                parentForm.OpenChildForm(new SignUp());
            }
            else
            {
                SignUp SignUpForm = new SignUp();
                this.Hide();
                SignUpForm.FormClosed += (s, args) => this.Close();
                SignUpForm.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 250,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Reset Password",
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label lblContact = new Label() { Left = 20, Top = 20, Text = "Verify Email or Phone:", Width = 300 };
            TextBox txtVerify = new TextBox() { Left = 20, Top = 45, Width = 340 };

            Label lblPass = new Label() { Left = 20, Top = 85, Text = "New Password:", Width = 300 };
            TextBox txtNewPass = new TextBox() { Left = 20, Top = 110, Width = 340 };

            Button btnUpdate = new Button() { Text = "Update", Left = 150, Width = 100, Top = 160, DialogResult = DialogResult.OK };
            Button btnCancel = new Button() { Text = "Cancel", Left = 260, Width = 100, Top = 160, DialogResult = DialogResult.Cancel };

            prompt.Controls.Add(lblContact);
            prompt.Controls.Add(txtVerify);
            prompt.Controls.Add(lblPass);
            prompt.Controls.Add(txtNewPass);
            prompt.Controls.Add(btnUpdate);
            prompt.Controls.Add(btnCancel);

            // This allows hitting enter inside the tiny prompt box too!
            prompt.AcceptButton = btnUpdate;

            if (prompt.ShowDialog() == DialogResult.OK)
            {
                string contactInput = txtVerify.Text.Trim();
                string newPasswordInput = txtNewPass.Text;

                if (string.IsNullOrWhiteSpace(contactInput) || string.IsNullOrWhiteSpace(newPasswordInput))
                {
                    MessageBox.Show("Both fields are required to reset your password.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();

                        string verifyQuery = "SELECT COUNT(1) FROM tblUserMaster WHERE EmailId = @Contact OR PhoneNumber = @Contact";
                        using (SqlCommand verifyCmd = new SqlCommand(verifyQuery, con))
                        {
                            verifyCmd.Parameters.AddWithValue("@Contact", contactInput);
                            int exists = Convert.ToInt32(verifyCmd.ExecuteScalar());

                            if (exists == 0)
                            {
                                MessageBox.Show("We could not find an account matching that Email or Phone number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        string updateQuery = "UPDATE tblUserMaster SET Password = @NewPassword WHERE EmailId = @Contact OR PhoneNumber = @Contact";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@NewPassword", newPasswordInput);
                            updateCmd.Parameters.AddWithValue("@Contact", contactInput);

                            updateCmd.ExecuteNonQuery();
                            MessageBox.Show("Password updated successfully! You can now log in with your new password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            prompt.Dispose();
        }
    }
}