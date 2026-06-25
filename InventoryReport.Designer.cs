namespace BloodBank
{
    partial class InventoryReport
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
            label1 = new Label();
            panel3 = new Panel();
            btnRefreshList = new Button();
            btnTotalStock = new Button();
            panel4 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            panel6 = new Panel();
            dgvInventory = new DataGridView();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(612, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 38);
            label1.TabIndex = 0;
            label1.Text = "Inventory";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(15, 76, 129);
            panel3.Dock = DockStyle.Bottom;
            panel3.ForeColor = Color.FromArgb(167, 243, 208);
            panel3.Location = new Point(0, 650);
            panel3.Name = "panel3";
            panel3.Size = new Size(1454, 60);
            panel3.TabIndex = 1;
            // 
            // btnRefreshList
            // 
            btnRefreshList.BackColor = Color.FromArgb(96, 125, 139);
            btnRefreshList.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefreshList.ForeColor = Color.White;
            btnRefreshList.Location = new Point(1102, 5);
            btnRefreshList.Name = "btnRefreshList";
            btnRefreshList.Size = new Size(200, 40);
            btnRefreshList.TabIndex = 4;
            btnRefreshList.Text = "Refresh List";
            btnRefreshList.UseVisualStyleBackColor = false;
            btnRefreshList.Click += btnRefreshList_Click;
            // 
            // btnTotalStock
            // 
            btnTotalStock.BackColor = Color.FromArgb(25, 118, 210);
            btnTotalStock.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTotalStock.ForeColor = Color.White;
            btnTotalStock.Location = new Point(116, 4);
            btnTotalStock.Name = "btnTotalStock";
            btnTotalStock.Size = new Size(200, 40);
            btnTotalStock.TabIndex = 0;
            btnTotalStock.Text = "Total Stock";
            btnTotalStock.UseVisualStyleBackColor = false;
            btnTotalStock.Click += btnTotalStock_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(240, 253, 244);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnRefreshList);
            panel4.Controls.Add(btnTotalStock);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1454, 56);
            panel4.TabIndex = 6;
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
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(33, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1454, 710);
            panel1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.InactiveCaption;
            panel6.Controls.Add(dgvInventory);
            panel6.Controls.Add(panel4);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 60);
            panel6.Name = "panel6";
            panel6.Size = new Size(1454, 590);
            panel6.TabIndex = 4;
            // 
            // dgvInventory
            // 
            dgvInventory.BackgroundColor = Color.FromArgb(240, 253, 244);
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.Location = new Point(0, 56);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.Size = new Size(1454, 534);
            dgvInventory.TabIndex = 7;
            // 
            // InventoryReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1520, 1034);
            Controls.Add(panel1);
            Name = "InventoryReport";
            Text = "InventoryReport";
            Load += InventoryReport_Load;
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel3;
        private Button btnRefreshList;
        private Button btnTotalStock;
        private Panel panel4;
        private Panel panel2;
        private Panel panel1;
        private Panel panel6;
        private DataGridView dgvInventory;
    }
}