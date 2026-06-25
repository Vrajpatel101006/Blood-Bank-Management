using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class Summary : Form
    {
        private string connectionString = "Data Source=VRAJPATEL\\SQLEXPRESS;Initial Catalog=dbBloodBank;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        // This variable "remembers" which button the user clicked last
        private string currentActiveView = "None";

        public Summary()
        {
            InitializeComponent();
        }

        private void DailySummary_Load(object sender, EventArgs e)
        {
            if (panel1 != null)
            {
                panel1.Location = new Point(
                    this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                    this.ClientSize.Height / 2 - panel1.Size.Height / 2);
                panel1.Anchor = AnchorStyles.None;
            }

            dgvSummary.ReadOnly = true;
            dgvSummary.AllowUserToAddRows = false;
            dgvSummary.AllowUserToDeleteRows = false;
            dgvSummary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Set default dates to today so it starts out clean
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
        }

        // ==========================================
        // HELPER METHOD: FETCH DATA
        // ==========================================
        private void LoadData(string query)
        {
            // NEW: Validation to ensure the user picked a valid date range
            if (dtpStartDate.Value.Date > dtpEndDate.Value.Date)
            {
                MessageBox.Show("The Start Date cannot be later than the End Date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Pass BOTH dates into the SQL query
                        cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date);
                        cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvSummary.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ==========================================
        // NEW REFRESH LOGIC
        // ==========================================
        private void RefreshCurrentView()
        {
            if (currentActiveView == "Donor")
            {
                // Updated WHERE clause to use BETWEEN for the date range
                string donorQuery = @"
                    SELECT 
                        [DonorName] AS Name, 
                        [PhoneNumber] AS [Phone Number], 
                        [Email], 
                        [DonorAge] AS Age, 
                        [Gender], 
                        [DonationDate] AS [Date and Time]
                    FROM [dbo].[tblBloodDonorMaster]
                    WHERE CAST([DonationDate] AS DATE) BETWEEN @StartDate AND @EndDate";

                LoadData(donorQuery);
            }
            else if (currentActiveView == "Recipient")
            {
                // Updated WHERE clause to use BETWEEN for the date range
                string recipientQuery = @"
                    SELECT 
                        [RecipientName] AS Name, 
                        [PhoneNumber] AS [Phone Number], 
                        [Email], 
                        [RecipientAge] AS Age, 
                        [Gender], 
                        [ReceivingDate] AS [Date and Time],
                        [HospitalName] AS [Hospital Name],
                        [HospitalPhoneNumber] AS [Hospital Number],
                        [ReferredDoctorName] AS [Doctor Name],
                        [DoctorPhoneNumber] AS [Doctor Number],
                        [RequiredBloodUnits] AS [Required Units]
                    FROM [dbo].[tblBloodRecipientMaster]
                    WHERE CAST([ReceivingDate] AS DATE) BETWEEN @StartDate AND @EndDate";

                LoadData(recipientQuery);
            }
        }

        // ==========================================
        // BUTTON EVENTS
        // ==========================================

        private void btnDonor_Click(object sender, EventArgs e)
        {
            currentActiveView = "Donor";
            RefreshCurrentView();
        }

        private void btnRecipient_Click(object sender, EventArgs e)
        {
            currentActiveView = "Recipient";
            RefreshCurrentView();
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            currentActiveView = "None";
            dgvSummary.DataSource = null;

            // Reset both calendars back to today
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
        }

        private void dgvSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Leave empty
        }

        // ==========================================
        // DATE PICKER EVENTS
        // ==========================================

        // Triggers when the Start Date calendar is changed
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (currentActiveView != "None")
            {
                RefreshCurrentView();
            }
        }

        // Triggers when the End Date calendar is changed
        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (currentActiveView != "None")
            {
                RefreshCurrentView();
            }
        }
    }
}