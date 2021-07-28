using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace librarysystem_DAL
{
    public class librarysystem_help
    {
        public static SqlConnection sqlcon = new SqlConnection("server=.;user = sa;pwd=123456;database=librarysystem");
       //获取链接
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
        //执行增删改操作 获取受影响行数
        public static int GetExecuteNonQuery(string sqlcmd)
        {
            GetSqlConnection();
            SqlCommand command = new SqlCommand(sqlcmd, sqlcon);
            int result = command.ExecuteNonQuery();
            return result;
            sqlcon.Close();
        }
        //返回数据表
        public static DataTable GetTable(string sqlcmd)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd, sqlcon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            sqlcon.Close();

        }
        public static SqlCommand SqlCommand(string sqlcmd)
        {
            GetSqlConnection();
            SqlCommand command = new SqlCommand(sqlcmd, sqlcon);
            return command;
            // sqlcon.Close();
        }
        public static DataTable TextGetTable(string sqlcmd)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd, sqlcon);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

    }
}
