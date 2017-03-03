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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        //取消
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string message = "";
                //调用方法，判断用户是否存在
                bool userExist = ValidateUser(this.txtUserName.Text.Trim(), this.txtPwd.Text.Trim(), ref message);
                if (userExist)
                {
                    FrmAdmin adminForm = new FrmAdmin();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //判断用户输入
        private bool ValidateInput()
        {
            bool result = false;//是否通过验证
            if (this.txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtUserName.Focus();
            }
            else if (this.txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPwd.Focus();
            }
            else
            {
                return true;
            }
            return result;
        }
        //判断用户是否存在
        private bool ValidateUser(string name, string pwd, ref string message)
        {
            bool bl = false;
            string sql = "select count(*) from admin_info where admin_name='" + name+"'";
            string result = DBHelper.ExecuteScalar(sql);
            if (int.Parse(result) > 0)
            {
                sql = string.Format("select count(*) from admin_info where admin_name='{0}' and admin_pwd='{1}'", name, pwd);
                result = DBHelper.ExecuteScalar(sql);
                if (int.Parse(result) > 0)
                {
                    bl = true;
                }
                else
                {
                    message = "用户密码错误!";
                }
            }
            else
            {
                message = "用户名不存在!";
            }
            return bl;
        }
        //窗体加载
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Initial();
        }
        private void Initial()
        {
            pictureBox1.Image = Image.FromFile(@"plugins\pic\logo.jpg");
            //加载歌曲路径
            KTVUtil.songPath = GetByPath("3");

            //加载歌手路径
            KTVUtil.singerPhotoPath = GetByPath("1");

        }
        private string GetByPath(string resId)
        {
            string path = "";
            string sql = string.Format("select resource_path from resource_path where resource_id={0}", resId);
            path = DBHelper.ExecuteScalar(sql);
            return path;
        }
    }
}
