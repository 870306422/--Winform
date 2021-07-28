using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using librarysystemMODEL;

namespace librarysystemDAL
{
   public class librarysystem_Domer
    {
        public static DataTable GetTable()
        {
            string sqlcmd = "select BookId '书籍编号',BookTitle '书记标题',Author '作者',LendingBook '借出数量',LendingTime '借出时间',DueDate '应还时间',LateFees '逾期费用' from Book";
            return librarysystem_help.GetTable(sqlcmd);
        }

        public static librarysystem_moder GetTable1 (librarysystem_moder a )
        {
            string sqlcmd = "select stuname,stusex,stuage  from studen where stuid=" + a.Stuid+"";
            DataTable b = librarysystem_help.GetTable(sqlcmd);
            for (int i = 0; i < b.Rows.Count; i++)
            {
                a.Stuname = b.Rows[i]["stuname"].ToString();
                a.Stusex = b.Rows[i]["stusex"].ToString();
                a.Stuage= Convert.ToInt32( b.Rows[i]["stuage"].ToString());

            }
            return a;
        }
        public static int GetDelect(librarysystem_moder a)
        {
            string sqlstr = "delete Book where BookId="+a.BookId1+"";
            string sqlstr1 = "delete studen where stuid=" + a.BookId1 + "";
            return librarysystem_help.getExecuteNonQuery(sqlstr1) + librarysystem_help.getExecuteNonQuery(sqlstr);
        }
        public static int GetUpdate(librarysystem_moder a)
        {
            string sqlcmd = "update Book set DueDate ='" + a.DueDate1 + "' where BookId = "+a.BookId1+"";
            return librarysystem_help.getExecuteNonQuery(sqlcmd);
        }

    }
}
