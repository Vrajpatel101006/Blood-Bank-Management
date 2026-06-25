namespace BloodBank
{
    partial class frmBloodBankMaster
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBloodBankMaster));
            menuStrip = new MenuStrip();
            signUpToolStripMenuItem = new ToolStripMenuItem();
            logInToolStripMenuItem = new ToolStripMenuItem();
            donorFormToolStripMenuItem = new ToolStripMenuItem();
            recipientFormToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            bloodDonorsToolStripMenuItem = new ToolStripMenuItem();
            bloodRecipientsToolStripMenuItem = new ToolStripMenuItem();
            ReportsToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem1 = new ToolStripMenuItem();
            dailySummaryToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            newToolStripButton = new ToolStripButton();
            openToolStripButton = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            printToolStripButton = new ToolStripButton();
            printPreviewToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            helpToolStripButton = new ToolStripButton();
            toolStrip = new ToolStrip();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.FromArgb(15, 76, 129);
            menuStrip.Font = new Font("Segoe UI", 12F);
            menuStrip.Items.AddRange(new ToolStripItem[] { logInToolStripMenuItem, signUpToolStripMenuItem, donorFormToolStripMenuItem, recipientFormToolStripMenuItem, usersToolStripMenuItem, ReportsToolStripMenuItem, logOutToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 3, 0, 3);
            menuStrip.Size = new Size(1640, 31);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // signUpToolStripMenuItem
            // 
            signUpToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            signUpToolStripMenuItem.ForeColor = Color.White;
            signUpToolStripMenuItem.Name = "signUpToolStripMenuItem";
            signUpToolStripMenuItem.Size = new Size(77, 25);
            signUpToolStripMenuItem.Text = "Sign Up";
            signUpToolStripMenuItem.Click += signUpToolStripMenuItem_Click;
            // 
            // logInToolStripMenuItem
            // 
            logInToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            logInToolStripMenuItem.ForeColor = Color.White;
            logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            logInToolStripMenuItem.Size = new Size(65, 25);
            logInToolStripMenuItem.Text = "Log In";
            logInToolStripMenuItem.Click += logInToolStripMenuItem_Click;
            // 
            // donorFormToolStripMenuItem
            // 
            donorFormToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            donorFormToolStripMenuItem.ForeColor = Color.White;
            donorFormToolStripMenuItem.Name = "donorFormToolStripMenuItem";
            donorFormToolStripMenuItem.Size = new Size(107, 25);
            donorFormToolStripMenuItem.Text = "Donor Form";
            donorFormToolStripMenuItem.Click += donorFormToolStripMenuItem_Click;
            // 
            // recipientFormToolStripMenuItem
            // 
            recipientFormToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            recipientFormToolStripMenuItem.ForeColor = Color.White;
            recipientFormToolStripMenuItem.Name = "recipientFormToolStripMenuItem";
            recipientFormToolStripMenuItem.Size = new Size(127, 25);
            recipientFormToolStripMenuItem.Text = "Recipient Form";
            recipientFormToolStripMenuItem.Click += recipientFormToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bloodDonorsToolStripMenuItem, bloodRecipientsToolStripMenuItem });
            usersToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            usersToolStripMenuItem.ForeColor = Color.White;
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(61, 25);
            usersToolStripMenuItem.Text = "Users";
            // 
            // bloodDonorsToolStripMenuItem
            // 
            bloodDonorsToolStripMenuItem.Name = "bloodDonorsToolStripMenuItem";
            bloodDonorsToolStripMenuItem.Size = new Size(223, 26);
            bloodDonorsToolStripMenuItem.Text = "Blood Donors List";
            bloodDonorsToolStripMenuItem.Click += bloodDonorsToolStripMenuItem_Click;
            // 
            // bloodRecipientsToolStripMenuItem
            // 
            bloodRecipientsToolStripMenuItem.Name = "bloodRecipientsToolStripMenuItem";
            bloodRecipientsToolStripMenuItem.Size = new Size(223, 26);
            bloodRecipientsToolStripMenuItem.Text = "Blood Recipients List";
            bloodRecipientsToolStripMenuItem.Click += bloodRecipientsToolStripMenuItem_Click;
            // 
            // ReportsToolStripMenuItem
            // 
            ReportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inventoryToolStripMenuItem1, dailySummaryToolStripMenuItem });
            ReportsToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            ReportsToolStripMenuItem.ForeColor = Color.White;
            ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
            ReportsToolStripMenuItem.Size = new Size(76, 25);
            ReportsToolStripMenuItem.Text = "Reports";
            // 
            // inventoryToolStripMenuItem1
            // 
            inventoryToolStripMenuItem1.Name = "inventoryToolStripMenuItem1";
            inventoryToolStripMenuItem1.Size = new Size(148, 26);
            inventoryToolStripMenuItem1.Text = "Inventory";
            inventoryToolStripMenuItem1.Click += inventoryToolStripMenuItem1_Click;
            // 
            // dailySummaryToolStripMenuItem
            // 
            dailySummaryToolStripMenuItem.Name = "dailySummaryToolStripMenuItem";
            dailySummaryToolStripMenuItem.Size = new Size(148, 26);
            dailySummaryToolStripMenuItem.Text = "Summary";
            dailySummaryToolStripMenuItem.Click += dailySummaryToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            logOutToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(78, 25);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.FromArgb(11, 59, 99);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 759);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 18, 0);
            statusStrip.Size = new Size(1640, 25);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripStatusLabel.ForeColor = Color.White;
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(49, 20);
            toolStripStatusLabel.Text = "Status";
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton.Font = new Font("Segoe UI", 11.25F);
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Black;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(23, 22);
            newToolStripButton.Text = "New";
            newToolStripButton.Click += ShowNewForm;
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openToolStripButton.Font = new Font("Segoe UI", 11.25F);
            openToolStripButton.Image = (Image)resources.GetObject("openToolStripButton.Image");
            openToolStripButton.ImageTransparentColor = Color.Black;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new Size(23, 22);
            openToolStripButton.Text = "Open";
            openToolStripButton.Click += OpenFile;
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Font = new Font("Segoe UI", 11.25F);
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Black;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(23, 22);
            saveToolStripButton.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // printToolStripButton
            // 
            printToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printToolStripButton.Font = new Font("Segoe UI", 11.25F);
            printToolStripButton.Image = (Image)resources.GetObject("printToolStripButton.Image");
            printToolStripButton.ImageTransparentColor = Color.Black;
            printToolStripButton.Name = "printToolStripButton";
            printToolStripButton.Size = new Size(23, 22);
            printToolStripButton.Text = "Print";
            // 
            // printPreviewToolStripButton
            // 
            printPreviewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printPreviewToolStripButton.Font = new Font("Segoe UI", 11.25F);
            printPreviewToolStripButton.Image = (Image)resources.GetObject("printPreviewToolStripButton.Image");
            printPreviewToolStripButton.ImageTransparentColor = Color.Black;
            printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            printPreviewToolStripButton.Size = new Size(23, 22);
            printPreviewToolStripButton.Text = "Print Preview";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // helpToolStripButton
            // 
            helpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            helpToolStripButton.Font = new Font("Segoe UI", 11.25F);
            helpToolStripButton.Image = (Image)resources.GetObject("helpToolStripButton.Image");
            helpToolStripButton.ImageTransparentColor = Color.Black;
            helpToolStripButton.Name = "helpToolStripButton";
            helpToolStripButton.Size = new Size(23, 22);
            helpToolStripButton.Text = "Help";
            // 
            // toolStrip
            // 
            toolStrip.BackColor = Color.FromArgb(21, 101, 192);
            toolStrip.Items.AddRange(new ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, toolStripSeparator1, printToolStripButton, printPreviewToolStripButton, toolStripSeparator2, helpToolStripButton });
            toolStrip.Location = new Point(0, 31);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(1640, 25);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "ToolStrip";
            // 
            // frmBloodBankMaster
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(1640, 784);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            Font = new Font("Segoe UI", 11.25F);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmBloodBankMaster";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBloodBankMaster";
            WindowState = FormWindowState.Maximized;
            Load += frmBloodBankMaster_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem signUpToolStripMenuItem;
        private ToolStripMenuItem logInToolStripMenuItem;
        private ToolStripMenuItem donorFormToolStripMenuItem;
        private ToolStripMenuItem recipientFormToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem bloodDonorsToolStripMenuItem;
        private ToolStripMenuItem bloodRecipientsToolStripMenuItem;
        private ToolStripMenuItem ReportsToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem1;
        private ToolStripMenuItem dailySummaryToolStripMenuItem;
        private ToolStripButton newToolStripButton;
        private ToolStripButton openToolStripButton;
        private ToolStripButton saveToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton printToolStripButton;
        private ToolStripButton printPreviewToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton helpToolStripButton;
        private ToolStrip toolStrip;
    }
}



