using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class DonorList : Form
    {
        // Database Connection
        private string connectionString = "Data Source=VRAJPATEL\\SQLEXPRESS;Initial Catalog=dbBloodBank;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        // Application State
        private string CurrentUserRole = "Admin";
        private int selectedDonorId = -1;

        public DonorList()
        {
            InitializeComponent();
            InitializeCustomUI();
        }

        private void DonorList_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(
            this.ClientSize.Width / 2 - panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
        }

        private void InitializeCustomUI()
        {
            // Initial UI Setup for Update Panel
            panel5.Visible = false;
            panel5.Dock = DockStyle.Top;

            // Initial UI Setup for Search Panel (panel7)
            if (panel7 != null)
            {
                panel7.Visible = false;
                panel7.Dock = DockStyle.Top;
            }

            dgvDonorlist.Dock = DockStyle.Fill;
            dgvDonorlist.BringToFront();

            // Grid Selection Setup
            dgvDonorlist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDonorlist.MultiSelect = false;
        }

        // ==========================================
        // 1. DATA LOADING & VIEWING
        // ==========================================

        private void btnViewDonor_Click(object sender, EventArgs e)
        {
            // Force panels closed to see the grid
            panel5.Visible = false;
            panel7.Visible = false;
            selectedDonorId = -1;

            LoadDonorData();
        }

        private void LoadDonorData()
        {
            string query = @"SELECT
                     BloodDonorMasterId, DonorName, DonorAge, DonorBloodGroup,
                     DonationDate, WeightInKG, Email, PhoneNumber, Gender,
                     Address, DonorDescription
                     FROM tblBloodDonorMaster";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvDonorlist.DataSource = null;
                    dgvDonorlist.Columns.Clear();
                    dgvDonorlist.AutoGenerateColumns = true;
                    dgvDonorlist.DataSource = dt;
                    dgvDonorlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dgvDonorlist.Columns["BloodDonorMasterId"] != null)
                    {
                        dgvDonorlist.Columns["BloodDonorMasterId"].Visible = false;
                    }

                    dgvDonorlist.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // 2. UPDATING RECORDS
        // ==========================================

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CurrentUserRole != "Admin" && CurrentUserRole != "Manager")
            {
                MessageBox.Show("You do not have the required permissions to update donor details.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvDonorlist.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDonorlist.SelectedRows[0];
                object idValue = row.Cells["BloodDonorMasterId"].Value;
                selectedDonorId = idValue != DBNull.Value && idValue != null ? Convert.ToInt32(idValue) : -1;

                if (selectedDonorId == -1) return;

                txtDonorName.Text = row.Cells["DonorName"].Value?.ToString();
                txtDonorAge.Text = row.Cells["DonorAge"].Value?.ToString();
                txtDonorEmail.Text = row.Cells["Email"].Value?.ToString();
                txtDonorPhonenumber.Text = row.Cells["PhoneNumber"].Value?.ToString();
                txtDonorAddress.Text = row.Cells["Address"].Value?.ToString();
                drpBloodGroup.Text = row.Cells["DonorBloodGroup"].Value?.ToString();
                drpGender.Text = row.Cells["Gender"].Value?.ToString();
                drpOccupation.Text = row.Cells["DonorDescription"].Value?.ToString();

                // Close search panel, open update panel
                panel7.Visible = false;
                panel5.Visible = true;
                panel5.BringToFront();
            }
            else
            {
                MessageBox.Show("Please select a donor row from the list first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (selectedDonorId == -1) return;

            string updateQuery = @"UPDATE [dbBloodBank].[dbo].[tblBloodDonorMaster] 
                                   SET [DonorName] = @Name, [DonorAge] = @Age, [Email] = @Email, 
                                       [PhoneNumber] = @Phone, [Address] = @Address, 
                                       [DonorBloodGroup] = @BloodGroup, [Gender] = @Gender, 
                                       [Occupation] = @Occupation 
                                   WHERE [BloodDonorMasterId] = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", selectedDonorId);
                        cmd.Parameters.AddWithValue("@Name", txtDonorName.Text);
                        cmd.Parameters.AddWithValue("@Age", txtDonorAge.Text);
                        cmd.Parameters.AddWithValue("@Email", txtDonorEmail.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtDonorPhonenumber.Text);
                        cmd.Parameters.AddWithValue("@Address", txtDonorAddress.Text);
                        cmd.Parameters.AddWithValue("@BloodGroup", drpBloodGroup.Text);
                        cmd.Parameters.AddWithValue("@Gender", drpGender.Text);
                        cmd.Parameters.AddWithValue("@Occupation", drpOccupation.Text);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }

                    panel5.Visible = false;
                    selectedDonorId = -1;
                    LoadDonorData();
                    MessageBox.Show("Donor details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            selectedDonorId = -1;
        }

        // ==========================================
        // 3. DELETING RECORDS
        // ==========================================

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // NEW: Immediately hide all panels so the user can see the grid update
            panel5.Visible = false;
            panel7.Visible = false;

            if (CurrentUserRole != "Admin")
            {
                MessageBox.Show("Only administrators can delete records.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvDonorlist.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a donor to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            /*--------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------*/
            object idValue = dgvDonorlist.SelectedRows[0].Cells["BloodDonorMasterId"].Value;
            int idToDelete = idValue != DBNull.Value && idValue != null ? Convert.ToInt32(idValue) : 0;


            //validation for delete blood units from the data base
            object idValue1 = dgvDonorlist.SelectedRows[0].Cells["DonorBloodGroup"].Value;
            string BloodGroup = string.IsNullOrEmpty(Convert.ToString(idValue1)) ? "": Convert.ToString(idValue1) ;



            object nameValue = dgvDonorlist.SelectedRows[0].Cells["DonorName"].Value;
            string nameToDelete = nameValue?.ToString() ?? "Unknown Donor";

            DialogResult result = ShowUndoDialog(nameToDelete);

            if (result == DialogResult.OK)
            {
                if (idToDelete > 0)
                {
                    ExecuteDelete(idToDelete, BloodGroup);
                    LoadDonorData(); // Refresh the grid, which is now fully visible
                }
            }
            else if (result == DialogResult.Cancel)
            {
                // Optional: You can keep this or remove it if you don't want a popup every time they cancel
                MessageBox.Show("Deletion canceled. The record is safe.", "Action Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //making blood donor delete by giving Bloodgroup as string
        private void ExecuteDelete(int id, string BloodGroup)
        {
            string deleteQuery = "DELETE FROM [dbBloodBank].[dbo].[tblBloodDonorMaster] WHERE [BloodDonorMasterId] = @Id";
            /*below is the delete query of a donor is deleted which delete the donation made by the user */
            string InvetoryUpdateQuery = "UPDATE  tblInventory  SET AvailableUnits = AvailableUnits-1 WHERE DonorBloodGroup = '"+ BloodGroup + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally {
                    connection.Close();
                }
                try
                {
                    using (SqlCommand cmd = new SqlCommand(InvetoryUpdateQuery, connection))
                    {
                        //cmd.Parameters.AddWithValue("@Id", id);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // NEW: Standard OK/Cancel dialog without the confusing timer
        private DialogResult ShowUndoDialog(string donorName)
        {
            Form prompt = new Form()
            {
                Width = 350,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Delete Confirmation",
                StartPosition = FormStartPosition.CenterScreen,
                ControlBox = false
            };

            Label textLabel = new Label()
            {
                Left = 20,
                Top = 20,
                Width = 300,
                Text = $"Are you sure you want to permanently delete\n{donorName}?",
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };

            Button btnCancel = new Button() { Text = "Cancel", Left = 50, Width = 100, Top = 70, DialogResult = DialogResult.Cancel };
            Button btnOk = new Button() { Text = "OK", Left = 180, Width = 100, Top = 70, DialogResult = DialogResult.OK };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(btnCancel);
            prompt.Controls.Add(btnOk);

            return prompt.ShowDialog();
        }

        // ==========================================
        // 4. RESET VIEW
        // ==========================================

        private void btnResetList_Click(object sender, EventArgs e)
        {
            // Force panels closed to see the grid
            panel5.Visible = false;
            panel7.Visible = false;
            selectedDonorId = -1;

            LoadDonorData();
            dgvDonorlist.ClearSelection();
            MessageBox.Show("View reset and data refreshed successfully.", "List Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ==========================================
        // 5. SMART SEARCH FUNCTIONALITY
        // ==========================================

        private void btnSearchUserPanel_Click(object sender, EventArgs e)
        {
            panel5.Visible = false; // Close Update panel if open
            selectedDonorId = -1;

            // Clear textboxes
            txtSearchUserName.Clear();
            txtSearchUserEmail.Clear();
            txtSearchUserPhoneNo.Clear();
            txtSearchUserAge.Clear();

            // Clear dropdowns
            drpSearchUserGender.SelectedIndex = -1;
            drpSearchUserBloodGroup.SelectedIndex = -1;

            panel7.Visible = true;
            panel7.BringToFront();

            LoadDonorData(); // Fills the grid before they start searching
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = @"SELECT BloodDonorMasterId, DonorName, DonorAge, DonorBloodGroup,
                            DonationDate, WeightInKG, Email, PhoneNumber, Gender,
                            Address, DonorDescription
                     FROM tblBloodDonorMaster WHERE 1=1 ";

            List<string> conditions = new List<string>();
            SqlCommand cmd = new SqlCommand();

            // Fixes the crash when searching multiple times
            cmd.Parameters.Clear();

            // 1. Textbox Searches
            string name = txtSearchUserName.Text.Trim();
            if (!string.IsNullOrWhiteSpace(name))
            {
                conditions.Add("DonorName LIKE @SearchName");
                cmd.Parameters.AddWithValue("@SearchName", "%" + name + "%");
            }

            string email = txtSearchUserEmail.Text.Trim();
            if (!string.IsNullOrWhiteSpace(email))
            {
                conditions.Add("Email LIKE @SearchEmail");
                cmd.Parameters.AddWithValue("@SearchEmail", "%" + email + "%");
            }

            string phone = txtSearchUserPhoneNo.Text.Trim();
            if (!string.IsNullOrWhiteSpace(phone))
            {
                conditions.Add("PhoneNumber LIKE @SearchPhone");
                cmd.Parameters.AddWithValue("@SearchPhone", "%" + phone + "%");
            }

            // 2. Age Search 
            string ageText = txtSearchUserAge.Text.Trim();
            if (!string.IsNullOrWhiteSpace(ageText))
            {
                if (int.TryParse(ageText, out int parsedAge))
                {
                    conditions.Add("DonorAge = @SearchAge");
                    cmd.Parameters.AddWithValue("@SearchAge", parsedAge);
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric age.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // 3. Dropdown Searches
            string gender = drpSearchUserGender.Text.Trim();
            if (!string.IsNullOrWhiteSpace(gender) && !gender.ToLower().Contains("select"))
            {
                conditions.Add("Gender LIKE @SearchGender");
                cmd.Parameters.AddWithValue("@SearchGender", gender + "%");
            }

            string bloodGroup = drpSearchUserBloodGroup.Text.Trim();
            if (!string.IsNullOrWhiteSpace(bloodGroup) && !bloodGroup.ToLower().Contains("select"))
            {
                conditions.Add("DonorBloodGroup LIKE @SearchBloodGroup");
                cmd.Parameters.AddWithValue("@SearchBloodGroup", bloodGroup + "%");
            }

            // 4. Attach all valid conditions
            if (conditions.Count > 0)
            {
                query += " AND " + string.Join(" AND ", conditions);
            }

            cmd.CommandText = query;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    cmd.Connection = con;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Rebind the Data Grid
                    dgvDonorlist.DataSource = null;
                    dgvDonorlist.Columns.Clear();
                    dgvDonorlist.AutoGenerateColumns = true;
                    dgvDonorlist.DataSource = dt;
                    dgvDonorlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dgvDonorlist.Columns["BloodDonorMasterId"] != null)
                    {
                        dgvDonorlist.Columns["BloodDonorMasterId"].Visible = false;
                    }

                    dgvDonorlist.Refresh();
                    dgvDonorlist.BringToFront(); // Ensures grid doesn't get buried

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No donors found matching your search criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            LoadDonorData(); // Reset the view automatically
        }

        // NEW: Clear fields without closing the panel
        private void btnClearSearchFields_Click(object sender, EventArgs e)
        {
            txtSearchUserName.Clear();
            txtSearchUserEmail.Clear();
            txtSearchUserPhoneNo.Clear();
            txtSearchUserAge.Clear();

            drpSearchUserGender.SelectedIndex = -1;
            drpSearchUserBloodGroup.SelectedIndex = -1;

            txtSearchUserName.Focus(); // Put cursor back in the name box

            // Optional: If you want clearing the boxes to also show all users again instantly:
            LoadDonorData();
        }

        private void btnAddDonor_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is frmBloodBankMaster parentForm)
            {
                parentForm.OpenChildForm(new BloodDonor());
            }
        }
    }
}