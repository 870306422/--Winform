using librarysystemMODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarysystemDAL
{
  public  class librarysystem_help
    {
        public static string sqlstr = "Data Source=LAPTOP-N8NG5EIL\\SQLEXPRESS;Initial Catalog=librarysystem;Persist Security Info=True;User ID=sa;Password=123456";
        public static SqlConnection sqlcon = new SqlConnection(sqlstr);
        /// <summary>
        /// 获取连接
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetSqlConnection()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            else if (sqlcon.State == ConnectionState.Broken)
            {
                sqlcon.Close();
                sqlcon.Open();
            }
            return sqlcon;
        }
        public static DataTable GetTable(string sqlcmd)
        {
            //GetSqlConnection(); SqlDataAdapter自己打开数据库
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd, sqlcon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            sqlcon.Close();
        }
        public static int getExecuteNonQuery(string sqlstr)
        {
            GetSqlConnection();
            SqlCommand command = new SqlCommand(sqlstr, sqlcon);
            int result = command.ExecuteNonQuery();
            return result;
            sqlcon.Close();
        }
       

    }
}
