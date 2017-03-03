using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MyKTV
{
    public partial class FrmPhotoPath : Form
    {
        public FrmPhotoPath()
        {
            InitializeComponent();
        }
        //关闭
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //浏览
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            DialogResult dr = fbdialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.txtNewPath.Text = fbdialog.SelectedPath;
                this.txtNewPath.Enabled = true;
            }
        }
        //加载默认路径
        private void FrmPhotoPath_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select resource_path from resource_path where resource_id=1");
            try
            {
                DBHelper.connection.Open();
                SqlCommand cmd = new SqlCommand(sql, DBHelper.connection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.txtOldPath.Text = dr["resource_path"].ToString();
                }
                dr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("路径加载异常!");
            }
            finally
            {
                DBHelper.connection.Close();
            }
        }
        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            string strNewPath = txtNewPath.Text;
            if (strNewPath.Equals(""))
            {
                MessageBox.Show("请选择新路径!","错误", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            string UpdateSql = string.Format("UPDATE [dbo].[resource_path] SET [resource_path] = '{0}' WHERE [resource_id]='{1}'", strNewPath,1);
            try
            {
                DBHelper.connection.Open();
                SqlCommand cmd = new SqlCommand(UpdateSql, DBHelper.connection);
                int i = (int)cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("更新成功!");
                    this.txtOldPath.Text=this.txtNewPath.Text;
                    this.txtNewPath.Text = "";
                }
                else
                {
                    MessageBox.Show("更新失败!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("路径加载异常!");
            }
            finally
            {
                DBHelper.connection.Close();
            }
        }
    }
}
