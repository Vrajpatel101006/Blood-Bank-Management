using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class RecipientList : Form
    {
        // Database Connection
        private string connectionString = "Data Source=VRAJPATEL\\SQLEXPRESS;Initial Catalog=dbBloodBank;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        // Application State
        private string CurrentUserRole = "Admin";
        private int selectedRecipientId = -1;

        public RecipientList()
        {
            InitializeComponent();
            InitializeCustomUI();
        }

        private void RecipientList_Load(object sender, EventArgs e)
        {
            if (panel1 != null)
            {
                panel1.Location = new Point(
                this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - panel1.Size.Height / 2);
                panel1.Anchor = AnchorStyles.None;
            }
        }


        private void InitializeCustomUI()
        {
            if (panel5 != null)
            {
                panel5.Visible = false;
                panel5.Dock = DockStyle.Top;
            }

            if (panel7 != null)
            {
                panel7.Visible = false;
                panel7.Dock = DockStyle.Top;
            }

            if (dgvRecipientList != null)
            {
                dgvRecipientList.Dock = DockStyle.Fill;
                dgvRecipientList.BringToFront();

                dgvRecipientList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvRecipientList.MultiSelect = false;
            }
        }

        // ==========================================
        // 1. DATA LOADING & VIEWING
        // ==========================================

        private void btnViewRecipient_Click(object sender, EventArgs e)
        {
            if (panel5 != null) panel5.Visible = false;
            if (panel7 != null) panel7.Visible = false;
            selectedRecipientId = -1;

            LoadRecipientData();
        }

        private void LoadRecipientData()
        {
            string query = @"SELECT [BloodRecipientMasterId], [RecipientName], [RecipientAge], 
                                    [RecipientBloodGroup], [ReceivingDate], [WeightInKG], [Email], 
                                    [PhoneNumber], [Gender], [Occupation], [Address], 
                                    [IsDonatedBloodBefore], [HospitalName], [HospitalPhoneNumber], 
                                    [ReferredDoctorName], [DoctorPhoneNumber], [RecipientDescription], 
                                    [RequiredBloodUnits], [IsActive], [IsDelete]
                             FROM [dbo].[tblBloodRecipientMaster]";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvRecipientList.DataSource = null;
                    dgvRecipientList.Columns.Clear();
                    dgvRecipientList.AutoGenerateColumns = true;
                    dgvRecipientList.DataSource = dt;
                    dgvRecipientList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dgvRecipientList.Columns["BloodRecipientMasterId"] != null)
                    {
                        dgvRecipientList.Columns["BloodRecipientMasterId"].Visible = false;
                    }

                    dgvRecipientList.Refresh();
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
                MessageBox.Show("You do not have the required permissions to update recipient details.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvRecipientList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvRecipientList.SelectedRows[0];
                object idValue = row.Cells["BloodRecipientMasterId"].Value;
                selectedRecipientId = idValue != DBNull.Value && idValue != null ? Convert.ToInt32(idValue) : -1;

                if (selectedRecipientId == -1) return;

                txtRecipientName.Text = row.Cells["RecipientName"].Value?.ToString();
                txtRecipientAge.Text = row.Cells["RecipientAge"].Value?.ToString();
                txtRecipientEmail.Text = row.Cells["Email"].Value?.ToString();
                txtRecipientPhonenumber.Text = row.Cells["PhoneNumber"].Value?.ToString();
                txtRecipientAddress.Text = row.Cells["Address"].Value?.ToString();
                drpBloodGroup.Text = row.Cells["RecipientBloodGroup"].Value?.ToString();
                drpGender.Text = row.Cells["Gender"].Value?.ToString();
                drpOccupation.Text = row.Cells["Occupation"].Value?.ToString();

                txtHospitalName.Text = row.Cells["HospitalName"].Value?.ToString();
                txtDoctorName.Text = row.Cells["ReferredDoctorName"].Value?.ToString();
                txtBloodGiven.Text = row.Cells["RequiredBloodUnits"].Value?.ToString();

                if (panel7 != null) panel7.Visible = false;
                if (panel5 != null)
                {
                    panel5.Visible = true;
                    panel5.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Please select a recipient row from the list first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (selectedRecipientId == -1) return;

            string updateQuery = @"UPDATE [dbBloodBank].[dbo].[tblBloodRecipientMaster] 
                                   SET [RecipientName] = @Name, [RecipientAge] = @Age, [Email] = @Email, 
                                       [PhoneNumber] = @Phone, [Address] = @Address, 
                                       [RecipientBloodGroup] = @BloodGroup, [Gender] = @Gender, 
                                       [Occupation] = @Occupation, [HospitalName] = @HospitalName, 
                                       [ReferredDoctorName] = @DoctorName, [RequiredBloodUnits] = @Units 
                                   WHERE [BloodRecipientMasterId] = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", selectedRecipientId);
                        cmd.Parameters.AddWithValue("@Name", txtRecipientName.Text);
                        cmd.Parameters.AddWithValue("@Age", txtRecipientAge.Text);
                        cmd.Parameters.AddWithValue("@Email", txtRecipientEmail.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtRecipientPhonenumber.Text);
                        cmd.Parameters.AddWithValue("@Address", txtRecipientAddress.Text);
                        cmd.Parameters.AddWithValue("@BloodGroup", drpBloodGroup.Text);
                        cmd.Parameters.AddWithValue("@Gender", drpGender.Text);
                        cmd.Parameters.AddWithValue("@Occupation", drpOccupation.Text);
                        cmd.Parameters.AddWithValue("@HospitalName", txtHospitalName.Text);
                        cmd.Parameters.AddWithValue("@DoctorName", txtDoctorName.Text);

                        int units = 0;
                        int.TryParse(txtBloodGiven.Text, out units);
                        cmd.Parameters.AddWithValue("@Units", units);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }

                    if (panel5 != null) panel5.Visible = false;
                    selectedRecipientId = -1;
                    LoadRecipientData();
                    MessageBox.Show("Recipient details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (panel5 != null) panel5.Visible = false;
            selectedRecipientId = -1;
        }

        // ==========================================
        // 3. DELETING RECORDS
        // ==========================================

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (panel5 != null) panel5.Visible = false;
            if (panel7 != null) panel7.Visible = false;

            if (CurrentUserRole != "Admin")
            {
                MessageBox.Show("Only administrators can delete records.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvRecipientList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a recipient to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            object idValue = dgvRecipientList.SelectedRows[0].Cells["BloodRecipientMasterId"].Value;
            int idToDelete = idValue != DBNull.Value && idValue != null ? Convert.ToInt32(idValue) : 0;

            
            object nameValue = dgvRecipientList.SelectedRows[0].Cells["RecipientName"].Value;

            //changed 3.30pm 
            object idValue1 = dgvRecipientList.SelectedRows[0].Cells["RecipientBloodGroup"].Value;

            //changed 3.30pm 
            string BloodGroup = string.IsNullOrEmpty(Convert.ToString(idValue1)) ? "" : Convert.ToString(idValue1);
            string nameToDelete = nameValue?.ToString() ?? "Unknown Recipient";

            DialogResult result = ShowUndoDialog(nameToDelete);

            if (result == DialogResult.OK)
            {
                if (idToDelete > 0)
                {//changed 3.30pm 
                    ExecuteDelete(idToDelete, BloodGroup);
                    LoadRecipientData();
                }
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Deletion canceled. The record is safe.", "Action Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExecuteDelete(int id, string BloodGroup)
        {
            string deleteQuery = "DELETE FROM [dbBloodBank].[dbo].[tblBloodRecipientMaster] WHERE [BloodRecipientMasterId] = @Id";

            //changed 3.30pm 
            string InvetoryUpdateQuery = "UPDATE tblInventory SET AvailableUnits = AvailableUnits + " + int.Parse(txtBloodGiven.Text) + " WHERE RecipientBloodGroup = '" + BloodGroup + "'";
            //   string InvetoryUpdateQuery = "UPDATE  tblInventory  SET AvailableUnits = AvailableUnits-1 WHERE DonorBloodGroup = '"+ BloodGroup + "'";int.Parse(txtBloodRequired.Text)


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
                //changed 3.30pm 
                finally
                {
                    connection.Close();
                }
            }
        }

        private DialogResult ShowUndoDialog(string recipientName)
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
                Text = $"Are you sure you want to permanently delete\n{recipientName}?",
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
            if (panel5 != null) panel5.Visible = false;
            if (panel7 != null) panel7.Visible = false;
            selectedRecipientId = -1;

            LoadRecipientData();
            if (dgvRecipientList != null)
            {
                dgvRecipientList.ClearSelection();
            }
            MessageBox.Show("View reset and data refreshed successfully.", "List Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ==========================================
        // 5. SMART SEARCH FUNCTIONALITY
        // ==========================================

        private void btnSearchUserPanel_Click(object sender, EventArgs e)
        {
            if (panel5 != null) panel5.Visible = false;
            selectedRecipientId = -1;

            ClearSearchFields();

            if (panel7 != null)
            {
                panel7.Visible = true;
                panel7.BringToFront();
            }

            LoadRecipientData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [BloodRecipientMasterId], [RecipientName], [RecipientAge], 
                                    [RecipientBloodGroup], [ReceivingDate], [WeightInKG], [Email], 
                                    [PhoneNumber], [Gender], [Occupation], [Address], 
                                    [IsDonatedBloodBefore], [HospitalName], [HospitalPhoneNumber], 
                                    [ReferredDoctorName], [DoctorPhoneNumber], [RecipientDescription], 
                                    [RequiredBloodUnits], [IsActive], [IsDelete]
                             FROM [dbo].[tblBloodRecipientMaster] WHERE 1=1 ";

            List<string> conditions = new List<string>();
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.Clear();

            string name = txtSearchUserName.Text.Trim();
            if (!string.IsNullOrWhiteSpace(name))
            {
                conditions.Add("RecipientName LIKE @SearchName");
                cmd.Parameters.AddWithValue("@SearchName", "%" + name + "%");
            }

            string email = txtSearchUserEmail.Text.Trim();
            if (!string.IsNullOrWhiteSpace(email))
            {
                conditions.Add("Email LIKE @SearchEmail");
                cmd.Parameters.AddWithValue("@SearchEmail", "%" + email + "%");
            }

            string phone = txtSearchUserPhoneNumber.Text.Trim();
            if (!string.IsNullOrWhiteSpace(phone))
            {
                conditions.Add("PhoneNumber LIKE @SearchPhone");
                cmd.Parameters.AddWithValue("@SearchPhone", "%" + phone + "%");
            }

            string hospital = txtSearchUserHospital.Text.Trim();
            if (!string.IsNullOrWhiteSpace(hospital))
            {
                conditions.Add("HospitalName LIKE @SearchHospital");
                cmd.Parameters.AddWithValue("@SearchHospital", "%" + hospital + "%");
            }

            string doctor = txtSearchUserDoctor.Text.Trim();
            if (!string.IsNullOrWhiteSpace(doctor))
            {
                conditions.Add("ReferredDoctorName LIKE @SearchDoctor");
                cmd.Parameters.AddWithValue("@SearchDoctor", "%" + doctor + "%");
            }

            string ageText = txtSearchUserAge.Text.Trim();
            if (!string.IsNullOrWhiteSpace(ageText))
            {
                if (int.TryParse(ageText, out int parsedAge))
                {
                    conditions.Add("RecipientAge = @SearchAge");
                    cmd.Parameters.AddWithValue("@SearchAge", parsedAge);
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric age.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string unitsText = txtSearchUserBloodGiven.Text.Trim();
            if (!string.IsNullOrWhiteSpace(unitsText))
            {
                if (int.TryParse(unitsText, out int parsedUnits))
                {
                    conditions.Add("RequiredBloodUnits = @SearchUnits");
                    cmd.Parameters.AddWithValue("@SearchUnits", parsedUnits);
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for Units Given.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string gender = drpSearchUserGender.Text.Trim();
            if (!string.IsNullOrWhiteSpace(gender) && !gender.ToLower().Contains("select"))
            {
                conditions.Add("Gender LIKE @SearchGender");
                cmd.Parameters.AddWithValue("@SearchGender", gender + "%");
            }

            string bloodGroup = drpSearchUserBloodGroup.Text.Trim();
            if (!string.IsNullOrWhiteSpace(bloodGroup) && !bloodGroup.ToLower().Contains("select"))
            {
                conditions.Add("RecipientBloodGroup LIKE @SearchBloodGroup");
                cmd.Parameters.AddWithValue("@SearchBloodGroup", bloodGroup + "%");
            }

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

                    if (dgvRecipientList != null)
                    {
                        dgvRecipientList.DataSource = null;
                        dgvRecipientList.Columns.Clear();
                        dgvRecipientList.AutoGenerateColumns = true;
                        dgvRecipientList.DataSource = dt;
                        dgvRecipientList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        if (dgvRecipientList.Columns["BloodRecipientMasterId"] != null)
                        {
                            dgvRecipientList.Columns["BloodRecipientMasterId"].Visible = false;
                        }

                        dgvRecipientList.Refresh();
                        dgvRecipientList.BringToFront();
                    }

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No recipients found matching your search criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (panel7 != null) panel7.Visible = false;
            LoadRecipientData();
        }

        private void btnClearSearchFields_Click(object sender, EventArgs e)
        {
            ClearSearchFields();
            LoadRecipientData();
        }

        private void ClearSearchFields()
        {
            txtSearchUserName.Clear();
            txtSearchUserEmail.Clear();
            txtSearchUserPhoneNumber.Clear();
            txtSearchUserAge.Clear();
            txtSearchUserHospital.Clear();
            txtSearchUserDoctor.Clear();
            txtSearchUserBloodGiven.Clear();

            drpSearchUserGender.SelectedIndex = -1;
            drpSearchUserBloodGroup.SelectedIndex = -1;

            txtSearchUserName.Focus();
        }

        private void btnAddRecipient_Click(object sender, EventArgs e)
        {

            if (this.MdiParent is frmBloodBankMaster parentForm)
            {
                parentForm.OpenChildForm(new BloodReceiver());
            }

        }
    }
}