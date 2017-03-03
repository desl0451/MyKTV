namespace MyKTV
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.msAdmin = new System.Windows.Forms.MenuStrip();
            this.tsmiSinger = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewSinger = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchSinger = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiResourcePath = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSingerPhotoPath = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSongPath = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.msAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // msAdmin
            // 
            this.msAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSinger,
            this.tsmiSong,
            this.tsmiResourcePath,
            this.tsmiHelp});
            this.msAdmin.Location = new System.Drawing.Point(0, 0);
            this.msAdmin.Name = "msAdmin";
            this.msAdmin.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msAdmin.Size = new System.Drawing.Size(472, 25);
            this.msAdmin.TabIndex = 2;
            this.msAdmin.Text = "menuStrip1";
            // 
            // tsmiSinger
            // 
            this.tsmiSinger.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewSinger,
            this.tsmiSearchSinger,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.tsmiSinger.Name = "tsmiSinger";
            this.tsmiSinger.Size = new System.Drawing.Size(83, 21);
            this.tsmiSinger.Text = "歌手管理(&S)";
            // 
            // tsmiNewSinger
            // 
            this.tsmiNewSinger.Name = "tsmiNewSinger";
            this.tsmiNewSinger.Size = new System.Drawing.Size(163, 22);
            this.tsmiNewSinger.Text = "新增歌手(&N)";
            this.tsmiNewSinger.Click += new System.EventHandler(this.tsmiNewSinger_Click);
            // 
            // tsmiSearchSinger
            // 
            this.tsmiSearchSinger.Name = "tsmiSearchSinger";
            this.tsmiSearchSinger.Size = new System.Drawing.Size(163, 22);
            this.tsmiSearchSinger.Text = "查询歌手信息(&S)";
            this.tsmiSearchSinger.Click += new System.EventHandler(this.tsmiSearchSinger_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(163, 22);
            this.tsmiExit.Text = "退出(&X)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiSong
            // 
            this.tsmiSong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewSong,
            this.tsmiSearchSong});
            this.tsmiSong.Name = "tsmiSong";
            this.tsmiSong.Size = new System.Drawing.Size(86, 21);
            this.tsmiSong.Text = "歌曲管理(&O)";
            // 
            // tsmiNewSong
            // 
            this.tsmiNewSong.Name = "tsmiNewSong";
            this.tsmiNewSong.Size = new System.Drawing.Size(163, 22);
            this.tsmiNewSong.Text = "新增歌曲(&N)";
            this.tsmiNewSong.Click += new System.EventHandler(this.tsmiNewSong_Click);
            // 
            // tsmiSearchSong
            // 
            this.tsmiSearchSong.Name = "tsmiSearchSong";
            this.tsmiSearchSong.Size = new System.Drawing.Size(163, 22);
            this.tsmiSearchSong.Text = "查询歌曲信息(&S)";
            this.tsmiSearchSong.Click += new System.EventHandler(this.tsmiSearchSong_Click);
            // 
            // tsmiResourcePath
            // 
            this.tsmiResourcePath.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSingerPhotoPath,
            this.tsmiSongPath});
            this.tsmiResourcePath.Name = "tsmiResourcePath";
            this.tsmiResourcePath.Size = new System.Drawing.Size(108, 21);
            this.tsmiResourcePath.Text = "设置资源路径(&R)";
            // 
            // tsmiSingerPhotoPath
            // 
            this.tsmiSingerPhotoPath.Name = "tsmiSingerPhotoPath";
            this.tsmiSingerPhotoPath.Size = new System.Drawing.Size(163, 22);
            this.tsmiSingerPhotoPath.Text = "歌手照片路径(&S)";
            this.tsmiSingerPhotoPath.Click += new System.EventHandler(this.tsmiSingerPhotoPath_Click);
            // 
            // tsmiSongPath
            // 
            this.tsmiSongPath.Name = "tsmiSongPath";
            this.tsmiSongPath.Size = new System.Drawing.Size(163, 22);
            this.tsmiSongPath.Text = "歌曲路径(&O)";
            this.tsmiSongPath.Click += new System.EventHandler(this.tsmiSongPath_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(61, 21);
            this.tsmiHelp.Text = "帮助(&H)";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(152, 22);
            this.tsmiAbout.Text = "关于我们(&A)";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 402);
            this.Controls.Add(this.msAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTV后台管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.msAdmin.ResumeLayout(false);
            this.msAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiSinger;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewSinger;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchSinger;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiSong;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewSong;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchSong;
        private System.Windows.Forms.ToolStripMenuItem tsmiResourcePath;
        private System.Windows.Forms.ToolStripMenuItem tsmiSingerPhotoPath;
        private System.Windows.Forms.ToolStripMenuItem tsmiSongPath;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;

    }
}