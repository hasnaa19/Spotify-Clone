using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace pro
{
    public partial class Form1 : Form
    {
        CrystalReport1 CR;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, Globals.currentUserID);
            crystalReportViewer1.ReportSource = CR;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
            label1.Text = Globals.currentUserID.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void Homepage_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm f = new mainForm();
            this.Hide();
            f.Show();
        }
    }
}
