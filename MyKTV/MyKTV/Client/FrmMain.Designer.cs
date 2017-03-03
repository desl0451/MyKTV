namespace MyKTV
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.picWordCount = new System.Windows.Forms.PictureBox();
            this.picSongList = new System.Windows.Forms.PictureBox();
            this.picSongType = new System.Windows.Forms.PictureBox();
            this.picSongName = new System.Windows.Forms.PictureBox();
            this.picSinger = new System.Windows.Forms.PictureBox();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWordCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSongList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSongType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSongName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSinger)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.Transparent;
            this.pnlCenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCenter.BackgroundImage")));
            this.pnlCenter.Controls.Add(this.picWordCount);
            this.pnlCenter.Controls.Add(this.picSongList);
            this.pnlCenter.Controls.Add(this.picSongType);
            this.pnlCenter.Controls.Add(this.picSongName);
            this.pnlCenter.Controls.Add(this.picSinger);
            this.pnlCenter.Location = new System.Drawing.Point(52, 157);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(394, 245);
            this.pnlCenter.TabIndex = 4;
            // 
            // picWordCount
            // 
            this.picWordCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWordCount.Location = new System.Drawing.Point(158, 133);
            this.picWordCount.Name = "picWordCount";
            this.picWordCount.Size = new System.Drawing.Size(76, 74);
            this.picWordCount.TabIndex = 4;
            this.picWordCount.TabStop = false;
            this.picWordCount.Click += new System.EventHandler(this.picWordCount_Click);
            // 
            // picSongList
            // 
            this.picSongList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSongList.Location = new System.Drawing.Point(32, 133);
            this.picSongList.Name = "picSongList";
            this.picSongList.Size = new System.Drawing.Size(76, 74);
            this.picSongList.TabIndex = 3;
            this.picSongList.TabStop = false;
            this.picSongList.Click += new System.EventHandler(this.picSongList_Click);
            // 
            // picSongType
            // 
            this.picSongType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSongType.Location = new System.Drawing.Point(283, 33);
            this.picSongType.Name = "picSongType";
            this.picSongType.Size = new System.Drawing.Size(76, 74);
            this.picSongType.TabIndex = 2;
            this.picSongType.TabStop = false;
            this.picSongType.Click += new System.EventHandler(this.picSongType_Click);
            // 
            // picSongName
            // 
            this.picSongName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSongName.Location = new System.Drawing.Point(158, 33);
            this.picSongName.Name = "picSongName";
            this.picSongName.Size = new System.Drawing.Size(76, 74);
            this.picSongName.TabIndex = 1;
            this.picSongName.TabStop = false;
            this.picSongName.Click += new System.EventHandler(this.picSongName_Click);
            // 
            // picSinger
            // 
            this.picSinger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSinger.Location = new System.Drawing.Point(32, 34);
            this.picSinger.Name = "picSinger";
            this.picSinger.Size = new System.Drawing.Size(76, 74);
            this.picSinger.TabIndex = 0;
            this.picSinger.TabStop = false;
            this.picSinger.Click += new System.EventHandler(this.picSinger_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 504);
            this.Controls.Add(this.pnlCenter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "多多影音";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWordCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSongList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSongType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSongName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSinger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.PictureBox picWordCount;
        private System.Windows.Forms.PictureBox picSongList;
        private System.Windows.Forms.PictureBox picSongType;
        private System.Windows.Forms.PictureBox picSongName;
        private System.Windows.Forms.PictureBox picSinger;

    }
}