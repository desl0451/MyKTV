using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyKTV
{
    public partial class FrmSongList : Form
    {
        public FrmSongList()
        {
            InitializeComponent();
        }
        //窗体加载
        private void FrmSongList_Load(object sender, EventArgs e)
        {
            //初始化歌曲类型
            InitialcboSongType();

            //加载所有歌曲信息
            InitialDgvSongList();
        }
        //加载所有歌曲信息
        private void InitialDgvSongList()
        {
            string singerSql = "select song_info.song_name,song_type.songtype_name,song_info.song_play_count from song_info inner join song_type on song_info.songtype_id=song_type.songtype_id";
            dgvSongList.DataSource = DBHelper.GetDataSet(singerSql, "ShowSong");

        }
        //初始化歌曲类型
        private void InitialcboSongType()
        {
            cboSongType.DataSource = DBHelper.GetDataSet("select * from song_type", "SongType", true, "songtype_name", "songtype_id");
            cboSongType.DisplayMember = "songtype_name";
            cboSongType.ValueMember = "songtype_id";
        }
        //查询歌曲信息
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowSongInfo();
        }
        //查询歌曲信息
        private void ShowSongInfo()
        {
            string sql = string.Format("select song_info.song_name,song_type.songtype_name,song_info.song_play_count from song_info inner join song_type on song_info.songtype_id=song_type.songtype_id where 1=1");
            string strSingerName = txtSongName.Text.Trim();
            if (!strSingerName.Equals(""))
            {
                sql += " and song_name like '%" + strSingerName + "%'";
            }
            string strCboSingerType = cboSongType.Text.Trim();
            if (!cboSongType.SelectedValue.ToString().Equals("-1"))
            {
                sql += " and song_type.songtype_id ='" + cboSongType.SelectedValue.ToString() + "'";
            }
            dgvSongList.DataSource = DBHelper.GetDataSet(sql, "ShowSong");
        }
    }
}
