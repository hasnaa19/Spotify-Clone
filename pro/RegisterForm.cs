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

namespace pro
{
    public partial class RegisterForm : Form
    {
        string ordb = "Data Source=orcl ;User Id=scott;Password=tiger;";
        OracleConnection conn;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select max(userID) from Users";
            int max = 0 ;
            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
              max = Convert.ToInt32(dr[0]);
            }
            max++;

            cmd.CommandText ="insert into Users values (:id, :pname, :password, :packageID, :gender, :email, :dob)";

            cmd.Parameters.Add("id", max.ToString());
            cmd.Parameters.Add("pname", pname.Text);
            cmd.Parameters.Add("password", password.Text);

            int packageID = 1;
            cmd.Parameters.Add("packageID", packageID.ToString());
            cmd.Parameters.Add("gender", G.Text);

            cmd.Parameters.Add("email", email.Text);
            cmd.Parameters.Add("dob", DOB.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thank You for Signing up.\n" +
                    "Please note that your Account ID is: " + max);
                Globals.currentUserID = max;
                Globals.currentUsername = pname.Text;
                mainForm mf = new mainForm();
                this.Hide();
                mf.Show();
            }
            catch
            {
                MessageBox.Show("This profile name already exist, Please change it in order to continue.");
                pname.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            loginForm frm2 = new loginForm();
            this.Hide();
            frm2.Show();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pname_TextChanged(object sender, EventArgs e)
        {

        }

        private void DOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void G_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void registerForm_closing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
