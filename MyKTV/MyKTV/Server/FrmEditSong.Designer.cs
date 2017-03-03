namespace MyKTV
{
    partial class FrmEditSong
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
            this.txtSongNameAB = new System.Windows.Forms.TextBox();
            this.lblSongNameAB = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtSongFile = new System.Windows.Forms.TextBox();
            this.lblSongFile = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSinger = new System.Windows.Forms.TextBox();
            this.lblSinger = new System.Windows.Forms.Label();
            this.cboSongType = new System.Windows.Forms.ComboBox();
            this.lblSongType = new System.Windows.Forms.Label();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.lblSongName = new System.Windows.Forms.Label();
            this.ofdSongFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtSongNameAB
            // 
            this.txtSongNameAB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSongNameAB.Location = new System.Drawing.Point(95, 50);
            this.txtSongNameAB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSongNameAB.Name = "txtSongNameAB";
            this.txtSongNameAB.Size = new System.Drawing.Size(311, 21);
            this.txtSongNameAB.TabIndex = 15;
            // 
            // lblSongNameAB
            // 
            this.lblSongNameAB.AutoSize = true;
            this.lblSongNameAB.Font = new System.Drawing.Font("宋体", 10.5F);
            this.lblSongNameAB.Location = new System.Drawing.Point(25, 55);
            this.lblSongNameAB.Name = "lblSongNameAB";
            this.lblSongNameAB.Size = new System.Drawing.Size(63, 14);
            this.lblSongNameAB.TabIndex = 24;
            this.lblSongNameAB.Text = "拼音缩写";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(319, 229);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 29);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(224, 229);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 29);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "保存";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(319, 188);
            this.btnBrowser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(87, 27);
            this.btnBrowser.TabIndex = 20;
            this.btnBrowser.Text = "浏览";
            this.btnBrowser.UseVisualStyleBackColor = true;
            // 
            // txtSongFile
            // 
            this.txtSongFile.BackColor = System.Drawing.SystemColors.Window;
            this.txtSongFile.Location = new System.Drawing.Point(11, 190);
            this.txtSongFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSongFile.Name = "txtSongFile";
            this.txtSongFile.ReadOnly = true;
            this.txtSongFile.Size = new System.Drawing.Size(298, 21);
            this.txtSongFile.TabIndex = 19;
            // 
            // lblSongFile
            // 
            this.lblSongFile.AutoSize = true;
            this.lblSongFile.Font = new System.Drawing.Font("宋体", 10.5F);
            this.lblSongFile.Location = new System.Drawing.Point(11, 162);
            this.lblSongFile.Name = "lblSongFile";
            this.lblSongFile.Size = new System.Drawing.Size(77, 14);
            this.lblSongFile.TabIndex = 27;
            this.lblSongFile.Text = "歌曲文件名";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(319, 117);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 27);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSinger
            // 
            this.txtSinger.Location = new System.Drawing.Point(95, 120);
            this.txtSinger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSinger.Name = "txtSinger";
            this.txtSinger.Size = new System.Drawing.Size(214, 21);
            this.txtSinger.TabIndex = 17;
            // 
            // lblSinger
            // 
            this.lblSinger.AutoSize = true;
            this.lblSinger.Font = new System.Drawing.Font("宋体", 10.5F);
            this.lblSinger.Location = new System.Drawing.Point(53, 124);
            this.lblSinger.Name = "lblSinger";
            this.lblSinger.Size = new System.Drawing.Size(35, 14);
            this.lblSinger.TabIndex = 26;
            this.lblSinger.Text = "歌手";
            // 
            // cboSongType
            // 
            this.cboSongType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSongType.FormattingEnabled = true;
            this.cboSongType.Location = new System.Drawing.Point(95, 84);
            this.cboSongType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSongType.Name = "cboSongType";
            this.cboSongType.Size = new System.Drawing.Size(311, 20);
            this.cboSongType.TabIndex = 16;
            // 
            // lblSongType
            // 
            this.lblSongType.AutoSize = true;
            this.lblSongType.Font = new System.Drawing.Font("宋体", 10.5F);
            this.lblSongType.Location = new System.Drawing.Point(25, 88);
            this.lblSongType.Name = "lblSongType";
            this.lblSongType.Size = new System.Drawing.Size(63, 14);
            this.lblSongType.TabIndex = 25;
            this.lblSongType.Text = "歌曲类型";
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(95, 22);
            this.txtSongName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(311, 21);
            this.txtSongName.TabIndex = 14;
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Font = new System.Drawing.Font("宋体", 10.5F);
            this.lblSongName.Location = new System.Drawing.Point(25, 25);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(63, 14);
            this.lblSongName.TabIndex = 23;
            this.lblSongName.Text = "歌曲名称";
            // 
            // ofdSongFile
            // 
            this.ofdSongFile.DefaultExt = "jpg";
            this.ofdSongFile.InitialDirectory = "D:";
            this.ofdSongFile.Title = "请选择歌手头像";
            // 
            // FrmEditSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 277);
            this.Controls.Add(this.txtSongNameAB);
            this.Controls.Add(this.lblSongNameAB);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.txtSongFile);
            this.Controls.Add(this.lblSongFile);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSinger);
            this.Controls.Add(this.lblSinger);
            this.Controls.Add(this.cboSongType);
            this.Controls.Add(this.lblSongType);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.lblSongName);
            this.Name = "FrmEditSong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑歌曲信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSongNameAB;
        private System.Windows.Forms.Label lblSongNameAB;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox txtSongFile;
        private System.Windows.Forms.Label lblSongFile;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.TextBox txtSinger;
        private System.Windows.Forms.Label lblSinger;
        private System.Windows.Forms.ComboBox cboSongType;
        private System.Windows.Forms.Label lblSongType;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.OpenFileDialog ofdSongFile;
    }
}