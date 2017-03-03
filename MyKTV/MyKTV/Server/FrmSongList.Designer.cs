namespace MyKTV
{
    partial class FrmSongList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSongList = new System.Windows.Forms.DataGridView();
            this.song_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songtype_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song_play_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSongType = new System.Windows.Forms.ComboBox();
            this.lblSongType = new System.Windows.Forms.Label();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.lblSongName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSongList
            // 
            this.dgvSongList.AllowUserToAddRows = false;
            this.dgvSongList.AllowUserToDeleteRows = false;
            this.dgvSongList.AllowUserToResizeColumns = false;
            this.dgvSongList.AllowUserToResizeRows = false;
            this.dgvSongList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSongList.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSongList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSongList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.song_id,
            this.song_name,
            this.songtype_name,
            this.song_play_count});
            this.dgvSongList.Location = new System.Drawing.Point(12, 46);
            this.dgvSongList.Name = "dgvSongList";
            this.dgvSongList.ReadOnly = true;
            this.dgvSongList.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSongList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSongList.RowTemplate.Height = 23;
            this.dgvSongList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSongList.Size = new System.Drawing.Size(610, 239);
            this.dgvSongList.TabIndex = 18;
            // 
            // song_id
            // 
            this.song_id.DataPropertyName = "song_id";
            this.song_id.HeaderText = "标识列";
            this.song_id.Name = "song_id";
            this.song_id.ReadOnly = true;
            this.song_id.Visible = false;
            // 
            // song_name
            // 
            this.song_name.DataPropertyName = "song_name";
            this.song_name.HeaderText = "歌曲名";
            this.song_name.Name = "song_name";
            this.song_name.ReadOnly = true;
            // 
            // songtype_name
            // 
            this.songtype_name.DataPropertyName = "songtype_name";
            this.songtype_name.HeaderText = "歌曲类别";
            this.songtype_name.Name = "songtype_name";
            this.songtype_name.ReadOnly = true;
            // 
            // song_play_count
            // 
            this.song_play_count.DataPropertyName = "song_play_count";
            this.song_play_count.HeaderText = "点播次数";
            this.song_play_count.Name = "song_play_count";
            this.song_play_count.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(521, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 31);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cboSongType
            // 
            this.cboSongType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSongType.FormattingEnabled = true;
            this.cboSongType.Items.AddRange(new object[] {
            "请选择"});
            this.cboSongType.Location = new System.Drawing.Point(329, 9);
            this.cboSongType.Name = "cboSongType";
            this.cboSongType.Size = new System.Drawing.Size(170, 20);
            this.cboSongType.TabIndex = 16;
            // 
            // lblSongType
            // 
            this.lblSongType.AutoSize = true;
            this.lblSongType.Location = new System.Drawing.Point(260, 13);
            this.lblSongType.Name = "lblSongType";
            this.lblSongType.Size = new System.Drawing.Size(53, 12);
            this.lblSongType.TabIndex = 15;
            this.lblSongType.Text = "歌曲类型";
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(67, 9);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(164, 21);
            this.txtSongName.TabIndex = 14;
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Location = new System.Drawing.Point(12, 13);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(41, 12);
            this.lblSongName.TabIndex = 13;
            this.lblSongName.Text = "歌曲名";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tsmiDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(152, 22);
            this.tsmiEdit.Text = "修改";
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(152, 22);
            this.tsmiDelete.Text = "删除";
            // 
            // FrmSongList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 296);
            this.Controls.Add(this.dgvSongList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSongType);
            this.Controls.Add(this.lblSongType);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.lblSongName);
            this.Name = "FrmSongList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSongList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSongList;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn songtype_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_play_count;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSongType;
        private System.Windows.Forms.Label lblSongType;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
    }
}