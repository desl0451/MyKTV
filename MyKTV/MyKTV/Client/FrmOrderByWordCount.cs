using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyKTV
{
    public partial class FrmOrderByWordCount : Form
    {
      
        public FrmOrderByWordCount()
        {
            InitializeComponent();
        }
        //加载字数
        private void FrmOrderByWordCount_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                ListViewItem lv = new ListViewItem((i + 1) + "个字");
                lv.Tag = i + 1;
                lvWordCount.Items.Add(lv);
            }
           
        }

        private void lvWordCount_MouseClick(object sender, MouseEventArgs e)
        {

            string wordCount = lvWordCount.SelectedItems[0].Tag.ToString();
            string sql = string.Format("select song_id,song_name, singer_name,song_url  from song_info inner join singer_info on song_info.singer_id=singer_info.singer_id where  song_word_count={0}",wordCount);
            FrmSongLists songList= new FrmSongLists();
            songList.Sql = sql;
            songList.Show();
        }
    }
}
