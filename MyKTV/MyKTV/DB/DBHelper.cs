using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace MyKTV
{
    public class DBHelper
    {
        private static string connString = "Data Source=.;Initial Catalog=MyKTV;User ID=sa;pwd=123";
        public static SqlConnection connection = new SqlConnection(connString);
        #region 1.返回单个值
        public static string ExecuteScalar(string sql)
        {
            string result = "";
            try
            {
                DBHelper.connection.Open();
                string ExeSql = string.Format(sql);
                SqlCommand cmd = new SqlCommand(ExeSql, DBHelper.connection);
                result = cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("数据库异常!");
            }
            finally
            {
                DBHelper.connection.Close();
            }
            return result;
        }
        #endregion


        #region 绑定数据
        public static DataTable GetDataSet(string sql, string tableName)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, DBHelper.connection);
            da.Fill(ds, tableName);
            return ds.Tables[tableName];
        }
        public static DataTable GetDataSet(string sql, string tableName,bool bl,string displayMember,string valueMember)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, DBHelper.connection);
            da.Fill(ds, tableName);
            if (bl == true)
            {

                DataRow row = ds.Tables[tableName].NewRow();
                row[valueMember]=-1;
                row[displayMember] = "全部";
                ds.Tables[tableName].Rows.InsertAt(row, 0);
            }
            return ds.Tables[tableName];
        }
        #endregion
    }
}
