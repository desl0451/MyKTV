﻿namespace MyKTV
{
    partial class FrmSongPath
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtNewPath = new System.Windows.Forms.TextBox();
            this.txtOldPath = new System.Windows.Forms.TextBox();
            this.lblNewPath = new System.Windows.Forms.Label();
            this.lblOldPath = new System.Windows.Forms.Label();
            this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(545, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 27);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(439, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(84, 109);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(97, 27);
            this.btnBrowser.TabIndex = 18;
            this.btnBrowser.Text = "浏览";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtNewPath
            // 
            this.txtNewPath.Enabled = false;
            this.txtNewPath.Location = new System.Drawing.Point(84, 77);
            this.txtNewPath.Name = "txtNewPath";
            this.txtNewPath.ReadOnly = true;
            this.txtNewPath.Size = new System.Drawing.Size(548, 21);
            this.txtNewPath.TabIndex = 17;
            // 
            // txtOldPath
            // 
            this.txtOldPath.BackColor = System.Drawing.SystemColors.Window;
            this.txtOldPath.Enabled = false;
            this.txtOldPath.Location = new System.Drawing.Point(84, 27);
            this.txtOldPath.Name = "txtOldPath";
            this.txtOldPath.Size = new System.Drawing.Size(548, 21);
            this.txtOldPath.TabIndex = 16;
            // 
            // lblNewPath
            // 
            this.lblNewPath.AutoSize = true;
            this.lblNewPath.Font = new System.Drawing.Font("宋体", 10.5F);
            this.lblNewPath.Location = new System.Drawing.Point(26, 82);
            this.lblNewPath.Name = "lblNewPath";
            this.lblNewPath.Size = new System.Drawing.Size(49, 14);
            this.lblNewPath.TabIndex = 15;
            this.lblNewPath.Text = "新路径";
            // 
            // lblOldPath
            // 
            this.lblOldPath.AutoSize = true;
            this.lblOldPath.Font = new System.Drawing.Font("宋体", 10.5F);
            this.lblOldPath.Location = new System.Drawing.Point(12, 32);
            this.lblOldPath.Name = "lblOldPath";
            this.lblOldPath.Size = new System.Drawing.Size(63, 14);
            this.lblOldPath.TabIndex = 14;
            this.lblOldPath.Text = "当前路径";
            // 
            // FrmSongPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 180);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.txtNewPath);
            this.Controls.Add(this.txtOldPath);
            this.Controls.Add(this.lblNewPath);
            this.Controls.Add(this.lblOldPath);
            this.MaximizeBox = false;
            this.Name = "FrmSongPath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置歌曲路径";
            this.Load += new System.EventHandler(this.FrmSongPath_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox txtNewPath;
        private System.Windows.Forms.TextBox txtOldPath;
        private System.Windows.Forms.Label lblNewPath;
        private System.Windows.Forms.Label lblOldPath;
        private System.Windows.Forms.FolderBrowserDialog fbDialog;
    }
}