
namespace pro
{
    partial class BrowseForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.songID_RB = new System.Windows.Forms.RadioButton();
            this.artist_RB = new System.Windows.Forms.RadioButton();
            this.genre_RB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_cmb = new System.Windows.Forms.ComboBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.hompage_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.songID_RB);
            this.groupBox1.Controls.Add(this.artist_RB);
            this.groupBox1.Controls.Add(this.genre_RB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(280, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search filter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // songID_RB
            // 
            this.songID_RB.AutoSize = true;
            this.songID_RB.BackColor = System.Drawing.Color.MintCream;
            this.songID_RB.Location = new System.Drawing.Point(44, 100);
            this.songID_RB.Name = "songID_RB";
            this.songID_RB.Size = new System.Drawing.Size(71, 17);
            this.songID_RB.TabIndex = 2;
            this.songID_RB.TabStop = true;
            this.songID_RB.Text = "Song ID";
            this.songID_RB.UseVisualStyleBackColor = false;
            this.songID_RB.CheckedChanged += new System.EventHandler(this.songID_RB_CheckedChanged);
            // 
            // artist_RB
            // 
            this.artist_RB.AutoSize = true;
            this.artist_RB.BackColor = System.Drawing.Color.MintCream;
            this.artist_RB.Location = new System.Drawing.Point(44, 67);
            this.artist_RB.Name = "artist_RB";
            this.artist_RB.Size = new System.Drawing.Size(54, 17);
            this.artist_RB.TabIndex = 1;
            this.artist_RB.TabStop = true;
            this.artist_RB.Text = "Artist";
            this.artist_RB.UseVisualStyleBackColor = false;
            this.artist_RB.CheckedChanged += new System.EventHandler(this.artist_RB_CheckedChanged);
            // 
            // genre_RB
            // 
            this.genre_RB.AutoSize = true;
            this.genre_RB.BackColor = System.Drawing.Color.MintCream;
            this.genre_RB.Location = new System.Drawing.Point(44, 35);
            this.genre_RB.Name = "genre_RB";
            this.genre_RB.Size = new System.Drawing.Size(59, 17);
            this.genre_RB.TabIndex = 0;
            this.genre_RB.TabStop = true;
            this.genre_RB.Text = "Genre";
            this.genre_RB.UseVisualStyleBackColor = false;
            this.genre_RB.CheckedChanged += new System.EventHandler(this.genre_RB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(126, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Box";
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.SpringGreen;
            this.search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(599, 172);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 3;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SongName,
            this.ArtistName,
            this.ReleaseDate,
            this.Genre});
            this.dataGridView1.GridColor = System.Drawing.Color.PaleGreen;
            this.dataGridView1.Location = new System.Drawing.Point(191, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 200);
            this.dataGridView1.TabIndex = 4;
            // 
            // SongName
            // 
            this.SongName.HeaderText = "SongName";
            this.SongName.Name = "SongName";
            // 
            // ArtistName
            // 
            this.ArtistName.HeaderText = "ArtistName";
            this.ArtistName.Name = "ArtistName";
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.HeaderText = "ReleaseDate";
            this.ReleaseDate.Name = "ReleaseDate";
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            // 
            // search_cmb
            // 
            this.search_cmb.BackColor = System.Drawing.Color.PaleGreen;
            this.search_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.search_cmb.ForeColor = System.Drawing.SystemColors.Highlight;
            this.search_cmb.FormattingEnabled = true;
            this.search_cmb.Location = new System.Drawing.Point(204, 172);
            this.search_cmb.Name = "search_cmb";
            this.search_cmb.Size = new System.Drawing.Size(376, 21);
            this.search_cmb.TabIndex = 5;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.SpringGreen;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(726, 448);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(91, 36);
            this.exit_btn.TabIndex = 6;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // hompage_btn
            // 
            this.hompage_btn.BackColor = System.Drawing.Color.SpringGreen;
            this.hompage_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hompage_btn.Location = new System.Drawing.Point(12, 448);
            this.hompage_btn.Name = "hompage_btn";
            this.hompage_btn.Size = new System.Drawing.Size(98, 36);
            this.hompage_btn.TabIndex = 7;
            this.hompage_btn.Text = "Home Page";
            this.hompage_btn.UseVisualStyleBackColor = false;
            this.hompage_btn.Click += new System.EventHandler(this.hompage_btn_Click);
            // 
            // BrowseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(829, 496);
            this.Controls.Add(this.hompage_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.search_cmb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "BrowseForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton songID_RB;
        private System.Windows.Forms.RadioButton artist_RB;
        private System.Windows.Forms.RadioButton genre_RB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.ComboBox search_cmb;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button hompage_btn;
    }
}

