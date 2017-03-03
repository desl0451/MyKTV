using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace MyKTV
{
    public partial class FrmEditSinger : Form
    {
        public FrmEditSinger()
        {
            InitializeComponent();
        }
        //关闭
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditSinger_Load(object sender, EventArgs e)
        {
            //第四套代码
            try
            {
                string sql = string.Format("select * from singer_type");
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, DBHelper.connection);
                da.Fill(ds, "singerType");

                DataRow row = ds.Tables["singerType"].NewRow();
                row["Singertype_id"]=-1;
                row["singertype_name"] = "全部";
                ds.Tables["singerType"].Rows.InsertAt(row, 0);

                cboType.DataSource = ds.Tables["singerType"];
                cboType.DisplayMember = "singertype_name";//显示的内容
                cboType.ValueMember = "singertype_id";//返回的值
            }
            catch (Exception)
            {
                MessageBox.Show("歌手类型加载错误!","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        //添加
        private void btnOK_Click(object sender, EventArgs e)
        {
            string singerType_id = cboType.SelectedValue.ToString();
            if (singerType_id .Equals("-1"))
            {
                MessageBox.Show("请选择歌手类型!");
                return;
            }
        }
        //浏览选择图片
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
            string singerName = txtName.Text.Trim();
            if (singerName.Equals(""))
            {
                MessageBox.Show("请先输入歌手姓名!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = ofdSingerPhoto.ShowDialog();
            //提取文件名
            string fullpath = ofdSingerPhoto.FileName;
            //截取文件名
            string filename = fullpath.Substring(fullpath.LastIndexOf("\\")+1);
            //获得扩展名
            string exterName = fullpath.Substring(fullpath.LastIndexOf("."));
            //复制
            File.Copy(fullpath, KTVUtil.singerPhotoPath + "\\" + singerName + exterName);
            if (dr == DialogResult.OK)
            {
                this.picPhoto.Image = Image.FromFile(KTVUtil.singerPhotoPath + "\\"
                    + singerName + exterName);
            }
        }
    }
}
