using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyKTV
{
    public partial class FrmOrderBySongName : Form
    {
        public FrmOrderBySongName()
        {
            InitializeComponent();
        }
        //打入内容后查询
        private void txtSongName_TextChanged(object sender, EventArgs e)
        {
            string songName = txtSongName.Text.Trim();
            dgvSong.DataSource = DBHelper.GetDataSet("select song_name,singer_info.singer_name from song_info inner join singer_info on song_info.singer_id=singer_info.singer_id where song_name like '%" + songName + "%'", "ShowSongInfo");
        }
        //窗体加载
        private void FrmOrderBySongName_Load(object sender, EventArgs e)
        {
            dgvSong.DataSource = DBHelper.GetDataSet("select song_name,singer_info.singer_name from song_info inner join singer_info on song_info.singer_id=singer_info.singer_id", "ShowSongInfo");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string songName = txtSongName.Text.Trim();
            dgvSong.DataSource = DBHelper.GetDataSet("select song_name,singer_info.singer_name from song_info inner join singer_info on song_info.singer_id=singer_info.singer_id where song_name like '%" + songName + "%'", "ShowSongInfo");

        }
    }
}
