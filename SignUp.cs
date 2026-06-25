using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BloodBank
{
    public partial class SignUp : Form
    {
        private string connectionString = "Data Source=VRAJPATEL\\SQLEXPRESS;Initial Catalog=dbBloodBank;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public SignUp()
        {
            InitializeComponent();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
        );

        private void SignUp_Load(object sender, EventArgs e)
        {
            if (panel5 != null)
            {
                panel5.Location = new Point(
                    this.ClientSize.Width / 2 - panel5.Size.Width / 2,
                    this.ClientSize.Height / 2 - panel5.Size.Height / 2);
                panel5.Anchor = AnchorStyles.None;
                panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 30, 30));
            }
            cmbRole.SelectedIndex = 2;
        }

        private void ClearForm()
        {
            txtUserName.Clear();
            txtEmail.Clear();
            txtPhoneNo.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string emailInput = txtEmail.Text.Trim();
            string phoneInput = txtPhoneNo.Text.Trim();

            // 1. Basic Validation (Email is no longer required)
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Please enter User Name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(phoneInput))
            {
                MessageBox.Show("Please enter Phone Number. This is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter Password.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // 2. Regex Validation
            if (!Regex.IsMatch(phoneInput, @"^\+?\d{10,15}$"))
            {
                MessageBox.Show("Please enter a valid phone number.", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNo.Focus();
                return;
            }

            // Only validate email format IF the user actually typed something
            if (!string.IsNullOrWhiteSpace(emailInput) && !Regex.IsMatch(emailInput, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address, or leave it blank.", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // 3. Duplicate Check: Dynamically check email only if it was provided
                    string checkQuery = "SELECT COUNT(1) FROM tblUserMaster WHERE PhoneNumber = @Phone";
                    if (!string.IsNullOrWhiteSpace(emailInput))
                    {
                        checkQuery += " OR EmailId = @Email";
                    }

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@Phone", phoneInput);
                        if (!string.IsNullOrWhiteSpace(emailInput))
                        {
                            checkCmd.Parameters.AddWithValue("@Email", emailInput);
                        }

                        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (exists > 0)
                        {
                            MessageBox.Show("An account with this Phone Number (or Email) already exists. \nPlease Log In with different credientials.", "Duplicate Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // 4. Safe Insertion (Handles empty email gracefully)
                    string insertQuery = @"INSERT INTO tblUserMaster (DisplayName, PhoneNumber, EmailId, Password, IsActive, IsDelete, RegistrationDate) 
                                           VALUES (@Name, @Phone, @Email, @Password, 1, 0, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtUserName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", phoneInput);

                        // Insert DBNull if email is blank, otherwise insert the email
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(emailInput) ? (object)DBNull.Value : emailInput);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Account Created Successfully! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();

                        // Automatically switch back to the login screen
                        label5_Click(sender, e);
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
                parentForm.OpenChildForm(new Login());
            }
            else
            {
                Login loginForm = new Login();
                this.Hide();
                loginForm.FormClosed += (s, args) => this.Close();
                loginForm.Show();
            }
        }
    }
}