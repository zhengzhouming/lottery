using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Reflection;

namespace lottery
{
    /// <summary>
    /// 数据操作的公共类
    /// </summary>


    class SqlHelper
    {     

        public static readonly string connStr = "Data Source=192.168.105.224; Initial Catalog=WR_Employee;User ID=sa;Password=xiaoming;Connect Timeout=180";   



        #region  执行操作，返回表对象 + static DataTable ExcuteTable(string sql)
        /// <summary>
        /// 执行操作，返回表对象
        /// </summary>
        /// <param name="sql"></param>   
        /// <returns></returns>
        public static DataTable ExcuteTable(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandTimeout = 180;
                    cmd.CommandText = sql;
                    DataSet dataset = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataset);
                    return dataset.Tables[0];
                    // return i;
                }
            }
        }
        #endregion
    }
}
