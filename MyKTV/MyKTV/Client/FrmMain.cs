using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyKTV
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        //歌星点歌
        private void picSinger_Click(object sender, EventArgs e)
        {
            FrmOrderBySinger singerForm = new FrmOrderBySinger();
            singerForm.Show();
        }
        //拼音点歌
        private void picSongName_Click(object sender, EventArgs e)
        {
            FrmOrderBySongName songNameForm = new FrmOrderBySongName();
            songNameForm.Show();
        }
        //类型选择
        private void picSongType_Click(object sender, EventArgs e)
        {
            FrmOrderBySongType songTypeForm = new FrmOrderBySongType();
            songTypeForm.Show();
        }
        //金榜排行
        private void picSongList_Click(object sender, EventArgs e)
        {

        }
        //字数点歌
        private void picWordCount_Click(object sender, EventArgs e)
        {
            FrmOrderByWordCount wordCountForm = new FrmOrderByWordCount();
            wordCountForm.Show();
        }
        //窗体加载
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("plugins/pic/3.jpg");

        }
    }
}
