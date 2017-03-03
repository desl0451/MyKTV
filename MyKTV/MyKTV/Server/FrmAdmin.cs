using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyKTV
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
 
        #region 1.歌手管理
        //1.新增歌手
        private void tsmiNewSinger_Click(object sender, EventArgs e)
        {
            FrmEditSinger newSingerForm = new FrmEditSinger();
            newSingerForm.MdiParent = this;
            newSingerForm.Show();
        }
        //2.查询歌手信息
        private void tsmiSearchSinger_Click(object sender, EventArgs e)
        {
            FrmSingerList singerListForm = new FrmSingerList();
            singerListForm.MdiParent = this;
            singerListForm.Show();
        }

        //3.退出
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
     
        #endregion

        #region 2.歌曲管理
        //1.新增歌曲
        private void tsmiNewSong_Click(object sender, EventArgs e)
        {
            FrmEditSong newSongForm = new FrmEditSong();
            newSongForm.MdiParent = this;
            newSongForm.Show();
        }

        //2.查询歌曲
        private void tsmiSearchSong_Click(object sender, EventArgs e)
        {
            FrmSongList songListForm = new FrmSongList();
            songListForm.MdiParent = this;
            songListForm.Show();
        }
        #endregion

        #region 3.设置资源路径
        //1.歌手照片路径
        private void tsmiSingerPhotoPath_Click(object sender, EventArgs e)
        {
            FrmPhotoPath frmPhoto = new FrmPhotoPath();
            frmPhoto.MdiParent = this;
            frmPhoto.Show();
        }
        //2.歌曲路径
        private void tsmiSongPath_Click(object sender, EventArgs e)
        {
            FrmSongPath frmPhoto = new FrmSongPath();
            frmPhoto.MdiParent = this;
            frmPhoto.Show();
        }
        #endregion

        #region 4.帮助
        //1.关于窗体
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();

        }
        #endregion

        /// <summary>
        /// 窗体加载壁纸
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int i = (int)(random.NextDouble() * 2) + 1;
            this.BackgroundImage = Image.FromFile(@"plugins\pic\" + i + ".jpg");
        }

    }
}
