using Microsoft.Data.SqlClient; // Added for SQL Connection
using System;
using System.Data; // Added for DataTable
using System.Windows.Forms;

namespace BloodBank
{
    public partial class InventoryReport : Form
    {
        // Keeping your standard connection string
        private string connectionString = "Data Source=VRAJPATEL\\SQLEXPRESS;Initial Catalog=dbBloodBank;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public InventoryReport()
        {
            InitializeComponent();
        }

        // It's best practice to set up the grid and load data when the form first opens
        private void InventoryReport_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadInventoryData();

            panel1.Location = new Point(
            this.ClientSize.Width / 2 - panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
        }

        // ==========================================
        // HELPER METHOD: LOCK DOWN THE GRID
        // ==========================================
        private void SetupDataGridView()
        {
            // This ensures the user can strictly view the data, but not touch it
            dgvInventory.ReadOnly = true;
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;

            // Optional but recommended for better UI styling
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ==========================================
        // HELPER METHOD: FETCH AND BIND DATA
        // ==========================================
        private void LoadInventoryData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Your SQL Query
                    string query = @"SELECT [InventoryId], [DonorBloodGroup], [AvailableUnits] 
                                     FROM [dbo].[tblInventory]";

                    // A SqlDataAdapter is perfect here. It fetches the data and fills a DataTable
                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Bind the DataTable directly to the DataGridView
                        dgvInventory.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ==========================================
        // BUTTON EVENTS
        // ==========================================

        private void btnViewStock_Click(object sender, EventArgs e)
        {

        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            // Does the exact same thing: reloads the data from the database
            LoadInventoryData();
        }

        private void btnTotalStock_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // SQL query to add up everything in the AvailableUnits column
                    string query = "SELECT SUM(AvailableUnits) FROM tblInventory";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // ExecuteScalar grabs the single value returned by the SUM() query
                        object result = cmd.ExecuteScalar();

                        // We check for DBNull just in case the table is completely empty!
                        int totalStock = (result != DBNull.Value && result != null) ? Convert.ToInt32(result) : 0;

                        // Pop up the result in a clean message box
                        MessageBox.Show($"The total available stock across all blood groups is: {totalStock} Units.",
                                        "Total Stock Summary",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}