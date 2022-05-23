using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pro
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchSongsForSpecificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseForm BF = new BrowseForm();
            this.Hide();
            BF.Show();
        }

        private void button2_Click(object sender, EventArgs e) //logout
        {
            RegisterForm RF = new RegisterForm();
            this.Hide();
            RF.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void byCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseForm BF = new BrowseForm();
            this.Hide();
            BF.Show();
        }

        private void bySongIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseForm BF = new BrowseForm();
            this.Hide();
            BF.Show();
        }

        private void viewLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
        private void editPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editPack_form x = new editPack_form();
            this.Hide();
            x.Show();
        }
        private void likeSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
             DisconnectedMode  XX = new DisconnectedMode();
             this.Hide();
             XX.Show();      
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            username_label.Text = Globals.currentUsername;
            ID_label.Text = "ID: "+ Globals.currentUserID;
        }
    }
}
