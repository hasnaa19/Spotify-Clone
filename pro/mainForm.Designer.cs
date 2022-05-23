
namespace pro
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.songsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bySongIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.likeSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchSongsForSpecificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.username_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SpringGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.songsToolStripMenuItem,
            this.artistsToolStripMenuItem,
            this.myProfileToolStripMenuItem,
            this.manageAccountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // songsToolStripMenuItem
            // 
            this.songsToolStripMenuItem.BackColor = System.Drawing.Color.PaleGreen;
            this.songsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseToolStripMenuItem,
            this.likeSongToolStripMenuItem});
            this.songsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songsToolStripMenuItem.Name = "songsToolStripMenuItem";
            this.songsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.songsToolStripMenuItem.Text = "Songs";
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byCategoryToolStripMenuItem,
            this.bySongIDToolStripMenuItem});
            this.browseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.browseToolStripMenuItem.Text = "Browse";
            // 
            // byCategoryToolStripMenuItem
            // 
            this.byCategoryToolStripMenuItem.Name = "byCategoryToolStripMenuItem";
            this.byCategoryToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.byCategoryToolStripMenuItem.Text = "By category";
            this.byCategoryToolStripMenuItem.Click += new System.EventHandler(this.byCategoryToolStripMenuItem_Click);
            // 
            // bySongIDToolStripMenuItem
            // 
            this.bySongIDToolStripMenuItem.Name = "bySongIDToolStripMenuItem";
            this.bySongIDToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.bySongIDToolStripMenuItem.Text = "By Song ID";
            this.bySongIDToolStripMenuItem.Click += new System.EventHandler(this.bySongIDToolStripMenuItem_Click);
            // 
            // likeSongToolStripMenuItem
            // 
            this.likeSongToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeSongToolStripMenuItem.Name = "likeSongToolStripMenuItem";
            this.likeSongToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.likeSongToolStripMenuItem.Text = "Like song";
            this.likeSongToolStripMenuItem.Click += new System.EventHandler(this.likeSongToolStripMenuItem_Click);
            // 
            // artistsToolStripMenuItem
            // 
            this.artistsToolStripMenuItem.BackColor = System.Drawing.Color.PaleGreen;
            this.artistsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchSongsForSpecificToolStripMenuItem});
            this.artistsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistsToolStripMenuItem.Name = "artistsToolStripMenuItem";
            this.artistsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.artistsToolStripMenuItem.Text = "Artists";
            // 
            // searchSongsForSpecificToolStripMenuItem
            // 
            this.searchSongsForSpecificToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSongsForSpecificToolStripMenuItem.Name = "searchSongsForSpecificToolStripMenuItem";
            this.searchSongsForSpecificToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.searchSongsForSpecificToolStripMenuItem.Text = "Search Songs for Specific Artist";
            this.searchSongsForSpecificToolStripMenuItem.Click += new System.EventHandler(this.searchSongsForSpecificToolStripMenuItem_Click);
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.BackColor = System.Drawing.Color.PaleGreen;
            this.myProfileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewLibraryToolStripMenuItem});
            this.myProfileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.myProfileToolStripMenuItem.Text = "My Profile";
            this.myProfileToolStripMenuItem.Click += new System.EventHandler(this.myProfileToolStripMenuItem_Click);
            // 
            // viewLibraryToolStripMenuItem
            // 
            this.viewLibraryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLibraryToolStripMenuItem.Name = "viewLibraryToolStripMenuItem";
            this.viewLibraryToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.viewLibraryToolStripMenuItem.Text = "View Library";
            this.viewLibraryToolStripMenuItem.Click += new System.EventHandler(this.viewLibraryToolStripMenuItem_Click);
            // 
            // manageAccountToolStripMenuItem
            // 
            this.manageAccountToolStripMenuItem.BackColor = System.Drawing.Color.PaleGreen;
            this.manageAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPackageToolStripMenuItem});
            this.manageAccountToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageAccountToolStripMenuItem.Name = "manageAccountToolStripMenuItem";
            this.manageAccountToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.manageAccountToolStripMenuItem.Text = "Manage Account";
            // 
            // editPackageToolStripMenuItem
            // 
            this.editPackageToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPackageToolStripMenuItem.Name = "editPackageToolStripMenuItem";
            this.editPackageToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.editPackageToolStripMenuItem.Text = "Edit Package";
            this.editPackageToolStripMenuItem.Click += new System.EventHandler(this.editPackageToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To Spotify";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.SpringGreen;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(12, 388);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(79, 32);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.SpringGreen;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(549, 388);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(89, 32);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(4, 25);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(85, 18);
            this.username_label.TabIndex = 4;
            this.username_label.Text = "Username";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label.Location = new System.Drawing.Point(6, 53);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(24, 18);
            this.ID_label.TabIndex = 5;
            this.ID_label.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ID_label);
            this.groupBox1.Controls.Add(this.username_label);
            this.groupBox1.Location = new System.Drawing.Point(549, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 80);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem songsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bySongIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem likeSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchSongsForSpecificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPackageToolStripMenuItem;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}