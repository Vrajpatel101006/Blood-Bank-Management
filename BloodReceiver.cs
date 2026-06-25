using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class BloodReceiver : Form
    {

        SqlConnection con = new SqlConnection("Data Source=VRAJPATEL\\SQLEXPRESS;Initial Catalog=dbBloodBank;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

        public BloodReceiver()
        {
            InitializeComponent();
            txtBloodRequired.KeyPress += txtBloodRequired_KeyPress;
        }

        private void txtBloodRequired_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BloodReceiver_Load(object sender, EventArgs e)
        {
            drpBloodGivenBefore.SelectedIndex = 1;
            drpBloodGroup.SelectedIndex = 0;
            //drpBloodRequired.SelectedIndex = 0;
            drpGender.SelectedIndex = 0;
            drpOccupation.SelectedIndex = 0;

            panel1.Location = new Point(
            this.ClientSize.Width / 2 - panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;



        }

        private void ClearForm()
        {
            txtName.Clear();
            txtAge.Clear();
            txtWeight.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtHospitalName.Clear();
            txtHospitalPhoneNumber.Clear();
            txtDoctorName.Clear();
            txtDoctorPhoneNumber.Clear();
            txtDescription.Clear();
            txtBloodRequired.Clear();

            drpBloodGivenBefore.SelectedIndex = 1;
            drpBloodGroup.SelectedIndex = 0;
            drpGender.SelectedIndex = 0;
            drpOccupation.SelectedIndex = 0;

            dtpReceivingDate.Value = DateTime.Now;

            txtName.Focus();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // ==========================================
            // 1. FORM VALIDATION
            // ==========================================
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter Patient Name");
                txtName.Focus();
                return;
            }
            else if (txtAge.Text == "")
            {
                MessageBox.Show("Enter Patient Age"); // Fixed typo in your original code here
                txtAge.Focus();
                return;
            }
            else if (!int.TryParse(txtAge.Text, out int age) || age <= 0 || age > 120)
            {
                MessageBox.Show("Enter Valid Age");
                txtAge.Focus();
                return;
            }
            else if (!decimal.TryParse(txtWeight.Text, out decimal weight) || weight <= 0)
            {
                MessageBox.Show("Enter Valid Weight");
                txtWeight.Focus();
                return;
            }
            else if (drpBloodGroup.Text == "")
            {
                MessageBox.Show("Enter BloodGroup");
                drpBloodGroup.Focus();
                return;
            }
            else if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Enter Receiver Phone Number");
                txtPhoneNumber.Focus();
                return;
            }
            else if (drpGender.Text == "")
            {
                MessageBox.Show("Select your Gender");
                drpGender.Focus();
                return;
            }
            else if (txtHospitalName.Text == "")
            {
                MessageBox.Show("Enter Hospital Name");
                txtHospitalName.Focus();
                return;
            }
            else if (txtHospitalPhoneNumber.Text == "")
            {
                MessageBox.Show("Enter Hospital Phone Number");
                txtHospitalPhoneNumber.Focus();
                return;
            }
            else if (txtDoctorName.Text == "")
            {
                MessageBox.Show("Enter Doctor Name");
                txtDoctorName.Focus();
                return;
            }
            else if (txtDoctorPhoneNumber.Text == "")
            {
                MessageBox.Show("Enter Doctor Phone No.");
                txtDoctorPhoneNumber.Focus();
                return;
            }

            if (!Regex.IsMatch(txtPhoneNumber.Text, @"^\+?\d{10,15}$"))
            {
                MessageBox.Show("Please enter a valid phone number.");
                txtPhoneNumber.Focus();
                return;
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.");
                txtEmail.Focus();
                return;
            }
            else if (!Regex.IsMatch(txtHospitalPhoneNumber.Text, @"^\+?\d{10,15}$"))
            {
                MessageBox.Show("Please enter a valid hospital phone number.");
                txtHospitalPhoneNumber.Focus();
                return;
            }
            else if (!Regex.IsMatch(txtDoctorPhoneNumber.Text, @"^\+?\d{10,15}$"))
            {
                MessageBox.Show("Please enter a valid doctor phone number.");
                txtDoctorPhoneNumber.Focus();
                return;
            }

            // Required Blood Units Validation
            if (txtBloodRequired.Text.Trim() == "")
            {
                MessageBox.Show("Enter Required Blood Units");
                txtBloodRequired.Focus();
                return;
            }

            if (!int.TryParse(txtBloodRequired.Text, out int requiredUnits))
            {
                MessageBox.Show("Enter Valid Blood Units");
                txtBloodRequired.Focus();
                return;
            }

            if (requiredUnits <= 0)
            {
                MessageBox.Show("Blood Units must be greater than 0");
                txtBloodRequired.Focus();
                return;
            }

            // ==========================================
            // 2. DATABASE OPERATIONS
            // ==========================================
            try
            {
                con.Open();

                
                int currentStock = 0;

                using (SqlCommand checkCmd = new SqlCommand("SELECT AvailableUnits FROM tblInventory WHERE DonorBloodGroup = @BloodGroup", con))
                {
                    checkCmd.Parameters.AddWithValue("@BloodGroup", drpBloodGroup.Text);
                    object result = checkCmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        currentStock = Convert.ToInt32(result);
                    }
                }

                if (currentStock < requiredUnits)
                {
                    MessageBox.Show($"Insufficient blood stock!\n\nYou requested {requiredUnits} units, but only {currentStock} units of {drpBloodGroup.Text} are currently available.",
                                    "Stock Unavailable",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    txtBloodRequired.Focus();
                    return;

                    // This completely stops the submission right here!
                }
                // --- END NEW CODE ---


                // If the code reaches here, it means we HAVE enough blood stock. Proceed with Insert.
                int isBloodDoname = 0;
                if (drpBloodGivenBefore.Text == "Yes")
                {
                    isBloodDoname = 1;
                }

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO tblBloodRecipientMaster " +
                    "(RecipientName, RecipientAge, RecipientBloodGroup, ReceivingDate, WeightInKG, Email, PhoneNumber, Gender, Occupation, Address, IsDonatedBloodBefore, HospitalName, HospitalPhoneNumber, ReferredDoctorName, DoctorPhoneNumber, RecipientDescription, RequiredBloodUnits) " +
                    "VALUES('" + txtName.Text + "','" + txtAge.Text + "','" + drpBloodGroup.Text + "','" + dtpReceivingDate.Text + "','" + txtWeight.Text + "','" +
                    txtEmail.Text + "','" + txtPhoneNumber.Text + "','" + drpGender.Text + "','" + drpOccupation.Text + "','" + txtAddress.Text + "'," +
                    isBloodDoname + ",'" + txtHospitalName.Text + "','" + txtHospitalPhoneNumber.Text + "','" + txtDoctorName.Text + "','" +
                    txtDoctorPhoneNumber.Text + "','" + txtDescription.Text + "'," + requiredUnits + ")", con);

                cmd.ExecuteNonQuery();

                // Proceed with Update
                SqlCommand cmd1 = new SqlCommand("UPDATE tblInventory SET AvailableUnits = AvailableUnits - '" + requiredUnits + "' WHERE DonorBloodGroup = '" + drpBloodGroup.Text + "'", con);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                  con.Close();
            }
        }
    }
}