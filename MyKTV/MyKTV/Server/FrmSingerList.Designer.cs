namespace MyKTV
{
    partial class FrmSingerList
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
            this.dgvSingerList = new System.Windows.Forms.DataGridView();
            this.singer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singertype_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singer_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singer_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSingerType = new System.Windows.Forms.ComboBox();
            this.lblSingerType = new System.Windows.Forms.Label();
            this.txtSingerName = new System.Windows.Forms.TextBox();
            this.lblSingerName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSingerList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSingerList
            // 
            this.dgvSingerList.AllowUserToAddRows = false;
            this.dgvSingerList.AllowUserToDeleteRows = false;
            this.dgvSingerList.AllowUserToResizeColumns = false;
            this.dgvSingerList.AllowUserToResizeRows = false;
            this.dgvSingerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSingerList.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSingerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSingerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSingerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.singer_id,
            this.singer_name,
            this.singertype_name,
            this.singer_gender,
            this.singer_description});
            this.dgvSingerList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSingerList.Location = new System.Drawing.Point(12, 48);
            this.dgvSingerList.Name = "dgvSingerList";
            this.dgvSingerList.ReadOnly = true;
            this.dgvSingerList.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSingerList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSingerList.RowTemplate.Height = 23;
            this.dgvSingerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSingerList.Size = new System.Drawing.Size(591, 252);
            this.dgvSingerList.TabIndex = 11;
            // 
            // singer_id
            // 
            this.singer_id.DataPropertyName = "singer_id";
            this.singer_id.HeaderText = "标识列";
            this.singer_id.Name = "singer_id";
            this.singer_id.ReadOnly = true;
            this.singer_id.Visible = false;
            // 
            // singer_name
            // 
            this.singer_name.DataPropertyName = "singer_name";
            this.singer_name.HeaderText = "歌手姓名";
            this.singer_name.Name = "singer_name";
            this.singer_name.ReadOnly = true;
            // 
            // singertype_name
            // 
            this.singertype_name.DataPropertyName = "singertype_name";
            this.singertype_name.HeaderText = "歌手类别";
            this.singertype_name.Name = "singertype_name";
            this.singertype_name.ReadOnly = true;
            // 
            // singer_gender
            // 
            this.singer_gender.DataPropertyName = "singer_gender";
            this.singer_gender.HeaderText = "歌手性别";
            this.singer_gender.Name = "singer_gender";
            this.singer_gender.ReadOnly = true;
            // 
            // singer_description
            // 
            this.singer_description.DataPropertyName = "singer_description";
            this.singer_description.HeaderText = "歌手描述";
            this.singer_description.Name = "singer_description";
            this.singer_description.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(516, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 27);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboSingerType
            // 
            this.cboSingerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSingerType.FormattingEnabled = true;
            this.cboSingerType.Items.AddRange(new object[] {
            "请选择"});
            this.cboSingerType.Location = new System.Drawing.Point(339, 17);
            this.cboSingerType.Name = "cboSingerType";
            this.cboSingerType.Size = new System.Drawing.Size(146, 20);
            this.cboSingerType.TabIndex = 9;
            // 
            // lblSingerType
            // 
            this.lblSingerType.AutoSize = true;
            this.lblSingerType.Font = new System.Drawing.Font("宋体", 10.5F);
            this.lblSingerType.Location = new System.Drawing.Point(270, 20);
            this.lblSingerType.Name = "lblSingerType";
            this.lblSingerType.Size = new System.Drawing.Size(63, 14);
            this.lblSingerType.TabIndex = 8;
            this.lblSingerType.Text = "歌手类型";
            // 
            // txtSingerName
            // 
            this.txtSingerName.Location = new System.Drawing.Point(81, 17);
            this.txtSingerName.Name = "txtSingerName";
            this.txtSingerName.Size = new System.Drawing.Size(151, 21);
            this.txtSingerName.TabIndex = 7;
            // 
            // lblSingerName
            // 
            this.lblSingerName.AutoSize = true;
            this.lblSingerName.Font = new System.Drawing.Font("宋体", 10.5F);
            this.lblSingerName.Location = new System.Drawing.Point(12, 20);
            this.lblSingerName.Name = "lblSingerName";
            this.lblSingerName.Size = new System.Drawing.Size(63, 14);
            this.lblSingerName.TabIndex = 6;
            this.lblSingerName.Text = "歌手姓名";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tsmiDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(100, 22);
            this.tsmiEdit.Text = "修改";
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(100, 22);
            this.tsmiDelete.Text = "删除";
            // 
            // FrmSingerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 315);
            this.Controls.Add(this.dgvSingerList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSingerType);
            this.Controls.Add(this.lblSingerType);
            this.Controls.Add(this.txtSingerName);
            this.Controls.Add(this.lblSingerName);
            this.Name = "FrmSingerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "歌手查询";
            this.Load += new System.EventHandler(this.FrmSingerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSingerList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSingerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn singer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn singer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn singertype_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn singer_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn singer_description;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSingerType;
        private System.Windows.Forms.Label lblSingerType;
        private System.Windows.Forms.TextBox txtSingerName;
        private System.Windows.Forms.Label lblSingerName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
    }
}