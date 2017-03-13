using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyKTV
{
    public partial class FrmSingerList : Form
    {
        public FrmSingerList()
        {
            InitializeComponent();
        }
        //窗体加载
        private void FrmSingerList_Load(object sender, EventArgs e)
        {
            Initial();
        }
        private void Initial()
        {
            cboSingerType.DataSource = DBHelper.GetDataSet("select * from singer_type", "singer_type", true, "singertype_name", "singertype_id");
            cboSingerType.DisplayMember = "singertype_name";
            cboSingerType.ValueMember = "singertype_id";
            //加载所有歌手信息
            string singerSql = "SELECT   dbo.singer_type.singertype_name, dbo.singer_info.singer_name, dbo.singer_info.singer_description, dbo.singer_info.singer_gender FROM      dbo.singer_info INNER JOIN dbo.singer_type ON dbo.singer_info.singertype_id = dbo.singer_type.singertype_id where 1=1";
            dgvSingerList.DataSource = DBHelper.GetDataSet(singerSql, "ShowSinger");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowSinger();
        }
        //查询歌手信息
        private void ShowSinger()
        {
            string sql = string.Format("SELECT   dbo.singer_type.singertype_name, dbo.singer_info.singer_name, dbo.singer_info.singer_description, dbo.singer_info.singer_gender FROM      dbo.singer_info INNER JOIN dbo.singer_type ON dbo.singer_info.singertype_id = dbo.singer_type.singertype_id where 1=1");
            string strSingerName = txtSingerName.Text.Trim();
            if (!strSingerName.Equals(""))
            {
                sql += " and singer_name like '%" + strSingerName + "%'";
            }
            string strCboSingerType = cboSingerType.Text.Trim();
            if (!cboSingerType.SelectedValue.ToString().Equals("-1"))
            {
                sql += " and singer_type.singertype_id ='" + cboSingerType.SelectedValue.ToString() + "'";
            }
            dgvSingerList.DataSource = DBHelper.GetDataSet(sql, "ShowSinger");
        }
    }
}
