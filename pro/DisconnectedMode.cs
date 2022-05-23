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
    public partial class DisconnectedMode : Form
    {
        public DisconnectedMode()
        {
            InitializeComponent();
        }
        OracleDataAdapter adapter;
        OracleCommandBuilder commandBuilder;
        DataSet ds;
        string constr = "Data Source=orcl; User Id=scott;Password=tiger;";

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

 
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string cmdstr = "select songName, songId,artistName,genre from Songs s, Artist a, genres g" +
                " where a.artistID = s.artistID and g.genreID = s.genreID";
      
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.AcceptChangesDuringFill = false;
            adapter.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            commandBuilder = new OracleCommandBuilder(adapter);
            try
            {
                adapter.Update(ds.Tables[0]);
                MessageBox.Show("Changes Saved.");
            }
            catch
            {
                MessageBox.Show("Invalid userID and/or songID.");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cmdstr = "select songId, userID from LikedSongs LS where LS.UserId =:id";          
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("id", Globals.currentUserID);
            ds = new DataSet();
            adapter.AcceptChangesDuringFill = true;
            adapter.Fill(ds);
            dgv2.DataSource = ds.Tables[0];
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
  
                mainForm mf = new mainForm();
                this.Hide();
                mf.Show();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
                Application.Exit();
            

        }

        private void DisconnectedMode_Load(object sender, EventArgs e)
        {

        }
    }
}
