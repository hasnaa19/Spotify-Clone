using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using CrystalDecisions.Shared;


namespace pro
{
    public partial class editPack_form : Form
    {
       
        editPack_report CR;
        public editPack_form()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CR = new editPack_report();
            label1.Text = Globals.currentUserID.ToString();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[1].DefaultValues)
                comboBox2.Items.Add(v.Value);

            string constr = "Data Source=orcl; User Id=scott;Password=tiger;";
            OracleConnection conn;
            conn = new OracleConnection(constr);
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select packageid from users where userid=:usid";
            c.Parameters.Add("usid", label1.Text);
            c.CommandType = CommandType.Text;
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                CR.SetParameterValue(2, dr[0].ToString());
            }
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, label1.Text);           
            crystalReportViewer1.ReportSource = CR;
        }

       

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl; User Id=scott;Password=tiger;";
            OracleConnection conn;
            conn = new OracleConnection(constr);
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "update Users set packageID=:pid where userID=:uuid";
            c.Parameters.Add("pid", comboBox2.Text);
            c.Parameters.Add("uuid", label1.Text);
            try
            {
                int r = c.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("User's Package modified");
                }
            }
            catch {
                MessageBox.Show("Please select a valid package ID(1 to 5).");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm mf = new mainForm();
            this.Hide();
            mf.Show();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
