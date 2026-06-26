using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class frmBloodBankMaster : Form
    {
        private int childFormNumber = 0;

        public frmBloodBankMaster()
        {
            InitializeComponent();
        }

        private void frmBloodBankMaster_Load(object sender, EventArgs e)
        {
            // On startup, lock the secure menus and open the Sign Up form
            ToggleSecureMenus(false);
            OpenChildForm(new Login());
        }

        // NEW METHOD: Controls which menus are visible based on login status
        public void ToggleSecureMenus(bool isLoggedIn)
        {
            // These buttons show UP when logged in, and HIDE when logged out
            donorFormToolStripMenuItem.Visible = isLoggedIn;
            recipientFormToolStripMenuItem.Visible = isLoggedIn;
            bloodDonorsToolStripMenuItem.Visible = isLoggedIn;
            bloodRecipientsToolStripMenuItem.Visible = isLoggedIn;

            // NEW: Hide the Log Out button if the user is not logged in!
            logOutToolStripMenuItem.Visible = isLoggedIn;
            usersToolStripMenuItem.Visible = isLoggedIn;
            ReportsToolStripMenuItem.Visible = isLoggedIn;


            // These buttons HIDE when logged in, and show UP when logged out
            signUpToolStripMenuItem.Visible = !isLoggedIn;
            logInToolStripMenuItem.Visible = !isLoggedIn;


        }

        // UPDATED: Now public so child forms can call it
        public void OpenChildForm(Form childForm)
        {
            // Close all currently opened child forms
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            // Open new child form
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }




        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Login());
        }


        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SignUp());
        }

        

        private void donorFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BloodDonor());
        }

        private void recipientFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BloodReceiver());
        }

        private void bloodDonorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DonorList());
        }

        private void bloodRecipientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RecipientList());
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. Lock the secure menus (hides Donor/Recipient buttons, shows Login/SignUp)
                ToggleSecureMenus(false);

                // 3. Open the Sign Up form (this automatically closes all other active child forms)
                OpenChildForm(new Login());

                // Note: If you'd rather it redirect to Login instead of Sign Up, 
                // just change the line above to: OpenChildForm(new Login());
            }
        }


        private void inventoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InventoryReport());
        }

        private void dailySummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Summary());
        }
    }
}