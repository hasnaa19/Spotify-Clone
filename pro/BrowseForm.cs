using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace pro
{
    public partial class BrowseForm : Form
    {
        string ordb = "Data source = orcl; User ID = scott; Password = tiger";
        OracleConnection conn;

        public BrowseForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();          
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();                             //lw m3lmthash byzwd rows 3la al abl kda
            if (string.IsNullOrEmpty(search_cmb.Text))
            {
                MessageBox.Show("Search Box is Empty.");
            }
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                if (genre_RB.Checked)
                {
                    cmd.CommandText = "select songName, artistName, Releasedate, genre from Songs, artist, genres where genres.genre =:category and songs.artistID = artist.artistID and genres.genreid = songs.genreid";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("category", search_cmb.SelectedItem.ToString());
                    OracleDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
                    }
                    dr.Close();
                }
                else if (artist_RB.Checked)      //select MULTIPLE ROWS, WITH ref cursor, STORED PROCEDURE
                {
                    cmd.CommandText = "byArtistName";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("name", search_cmb.SelectedItem.ToString());
                    cmd.Parameters.Add("result", OracleDbType.RefCursor, ParameterDirection.Output);
                    OracleDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
                    }
                    dr.Close();
                }
                else if (songID_RB.Checked)     //select SINGLE ROW, WITH out parameters, STORED PROCEDURE
                {
                    cmd.CommandText = "bySong_ID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("id", search_cmb.SelectedItem.ToString());

                    cmd.Parameters.Add("sn", OracleDbType.Varchar2, 500);
                    cmd.Parameters["sn"].Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("an", OracleDbType.Varchar2, 500);
                    cmd.Parameters["an"].Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("release", OracleDbType.Date);
                    cmd.Parameters["release"].Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("genre", OracleDbType.Varchar2, 500);
                    cmd.Parameters["genre"].Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    dataGridView1.Rows.Add(cmd.Parameters[1].Value, cmd.Parameters[2].Value, cmd.Parameters[3].Value, cmd.Parameters[4].Value);
                }
                search_cmb.Text = "";
            }
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void genre_RB_CheckedChanged(object sender, EventArgs e)
        {
            search_cmb.Text= "";
            dataGridView1.Rows.Clear();
            fill_comboBox("select genre from genres");
        }

        private void artist_RB_CheckedChanged(object sender, EventArgs e)
        {
            search_cmb.Text = "";
            dataGridView1.Rows.Clear();
            fill_comboBox("select artistname from artist");
        }

        private void songID_RB_CheckedChanged(object sender, EventArgs e)
        {
            search_cmb.Text = "";
            dataGridView1.Rows.Clear();
            fill_comboBox("select songid from songs");
        }
        public void fill_comboBox(string cmdstr) {
            search_cmb.Items.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = cmdstr;   
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                search_cmb.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void hompage_btn_Click(object sender, EventArgs e)
        {
            pro.mainForm mf = new pro.mainForm();
            this.Hide();
            mf.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
