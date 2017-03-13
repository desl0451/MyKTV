using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyKTV
{
    public partial class FrmSongLists : Form
    {
        private string sql = "";

        public string Sql
        {
            get { return sql; }
            set { sql = value; }
        }
        public FrmSongLists()
        {
            InitializeComponent();
        }
        //窗体加载
        private void FrmSongLists_Load(object sender, EventArgs e)
        {
            dgvSong.DataSource = DBHelper.GetDataSet(Sql, "SongLists");
        }
    }
}
