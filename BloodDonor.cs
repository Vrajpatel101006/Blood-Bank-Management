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
using System.Xml.Linq;

namespace BloodBank
{
    public partial class BloodDonor : Form
    {
        SqlConnection con = new SqlConnection("Data Source=VRAJPATEL\\SQLEXPRESS;Initial Catalog=dbBloodBank;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        public BloodDonor()
        {
            InitializeComponent();
        }

        private void BloodDonor_Load(object sender, EventArgs e)
        {
            drpGivenBloodBefore.SelectedIndex = 1;
            drpBloodGroup.SelectedIndex = 0;
            drpGender.SelectedIndex = 0;
            drpOccupation.SelectedIndex = 0;

            panel1.Location = new Point(
            this.ClientSize.Width / 2 - panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;

        }
        private void ClearForm()
        {
            txtDonorName.Clear();
            txtDonorAge.Clear();
            txtDonorWeight.Clear();
            txtDonorEmail.Clear();
            txtDonorPhonenumber.Clear();
            txtDonorAddress.Clear();
            txtDonorDescripiton.Clear();
            drpBloodGroup.SelectedIndex = 0;
            drpGender.SelectedIndex = 0;
            drpOccupation.SelectedIndex = 0;
            txtDonorName.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtDonorName.Text == "")
            {
                MessageBox.Show("Enter Donor Name");
                txtDonorName.Focus();
                return;
            }
            else if (txtDonorAge.Text == "")
            {
                MessageBox.Show("Enter Donor Age");
                txtDonorAge.Focus();
                return;
            }
            else if (drpBloodGroup.Text == "")
            {
                MessageBox.Show("Enter BloodGroup");
                drpBloodGroup.Focus();
                return;
            }
            else if (dtpDonationDate.Text == "")
            {
                MessageBox.Show("Enter the Donation date");
                dtpDonationDate.Focus();
                return;
            }
            else if (txtDonorPhonenumber.Text == "")
            {
                MessageBox.Show("Enter Donor Phone Number");
                txtDonorPhonenumber.Focus();
                return;
            }
            else if (drpGender.Text == "")
            {
                MessageBox.Show("Select your Gender");
                drpGender.Focus();
                return;
            }

            else if (txtDonorAddress.Text == "")
            {
                MessageBox.Show("Enter your Address");
                txtDonorAddress.Focus();
                return;
            }

            else if (!int.TryParse(txtDonorAge.Text, out int age) || age <= 0 || age > 120)
            {
                MessageBox.Show("Enter Valid Age");
                txtDonorAge.Focus();
                return;
            }

            else if (!decimal.TryParse(txtDonorWeight.Text, out decimal weight) || weight <= 0)
            {
                MessageBox.Show("Enter Valid Weight");
                txtDonorWeight.Focus();
                return;
            }

            if (!Regex.IsMatch(txtDonorPhonenumber.Text, @"^\+?\d{10,15}$"))
            {
                MessageBox.Show("Please enter a valid phone number.");
                txtDonorPhonenumber.Focus();
                return;
            }
            else if (!Regex.IsMatch(txtDonorEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.");
                txtDonorEmail.Focus();
                return;
            }

            try
            {
                con.Open();

                int isBloodDoname = 0;

                if (drpGivenBloodBefore.Text == "Yes")
                {
                    isBloodDoname = 1;
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO tblBloodDonorMaster (DonorName, DonorAge, DonorBloodGroup, DonationDate, WeightInKG, Email, PhoneNumber, Gender, Occupation, Address, DonorDescription, IsDonatedBloodBefore)" +
                    " VALUES('" + txtDonorName.Text + "','" + txtDonorAge.Text + "','" + drpBloodGroup.Text + "','" + dtpDonationDate.Text + "','" + txtDonorWeight.Text + "','" + txtDonorEmail.Text + "','" + txtDonorPhonenumber.Text + "','" +
                    drpGender.Text + "','" + drpOccupation.Text + "','" + txtDonorAddress.Text + "','"+txtDonorDescripiton.Text+"',"+ isBloodDoname + " )", con);

                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("UPDATE  tblInventory  SET AvailableUnits = AvailableUnits+1 WHERE DonorBloodGroup = '"+ drpBloodGroup.Text + "'", con);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;

            }
            finally
            {

                con.Close();
            }
            
        }

        
    }
}
