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
    public partial class loginForm : Form
    {

        string ordb ="Data Source=orcl ;User Id=scott;Password=tiger;";
        OracleConnection conn;

        public loginForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select upassword, userID from users where username = :name";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", textBox1.Text); 
            OracleDataReader dr = cmd.ExecuteReader();
            bool valid = false;
            if(dr.HasRows)
            {              
                if(textBox2.Text == dr[0].ToString())
                {              
                    MessageBox.Show("You are Succesfully logged in.");
                    valid = true;
                }
              
                else              
                {
                    MessageBox.Show("Please Enter Correct Password.");          
                    textBox2.Text = "";              
                }
            }
            else
            {
                MessageBox.Show("Please Enter Correct username.");
                textBox2.Text = "";
                textBox1.Text = "";
            }
            if (valid)
            {
                Globals.currentUserID = Convert.ToInt32(dr[1]);
                Globals.currentUsername = textBox1.Text;
                mainForm mf = new mainForm();
                this.Hide();
                mf.Show();
            }
            dr.Close();
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goBack_btn_Click(object sender, EventArgs e)
        {
            RegisterForm RG = new RegisterForm();
            this.Hide();
            RG.Show();
        }

        private void loginForm_closing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
