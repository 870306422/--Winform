using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using librarysystem_MODER;
namespace librarysystem_DAL
{
    public class librarysystem_Domer
    {
        public static DataTable dataTable()
        {
            string sqlstr = "select BookId '书籍ID',BookTitle '书籍标题',Author '作者',ISBN '国际标准书号',Abstract '摘要',Category '类别',Press '出版社',Number '数量',PublicationTime '出版时间',StorageTime '入库时间',CollectionLocation '馆藏位置',PicturePath '图片路径' from BookTwo";
            return librarysystem_help.GetTable(sqlstr);
        }
        public static void selecta()
        {
            librarysystem_help.GetSqlConnection();
        }
        public static DataTable bo(librarysystem_moder mnaer)
        {
            string sqlstr = "select distinct * from BookTwo where BookTitle like '%"+mnaer.Mname+"%' ";
            return librarysystem_help.GetTable(sqlstr);
        }
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
            return librarysystem_help.GetExecuteNonQuery(sqlstr1) + librarysystem_help.GetExecuteNonQuery(sqlstr);
        }
        public static int GetUpdate(librarysystem_moder a)
        {
            string sqlcmd = "update Book set DueDate ='" + a.DueDate1 + "' where BookId = "+a.BookId1+"";
            return librarysystem_help.GetExecuteNonQuery(sqlcmd);
        }
        public static DataTable DataTable()
        {
            string sqlcmd = "select BookTitle '书籍标题',Author '作者',Press '出版社',ISBN 'ISBN',Category '类别',PublicationTime '出版时间',StorageTime '入库时间',Number '数量',CollectionLocation '馆藏位置',Abstract '摘要' from BookTwo";
            return librarysystem_help.GetTable(sqlcmd);
        }
        //实现增加功能
        public static int GetInset(librarysystem_moder moder)
        {
            string sqlcmd = "insert into BookTwo values (N'" + moder.BookTitle + "', N'" + moder.Author + "', N'" + moder.ISBN + " ', N'" + moder.Abstract + "', N'" + moder.Category + "', N'" + moder.Press + "', " + moder.Number + ", '" + moder.PublicationTime + "', '" + moder.StorageTime + "', N'" + moder.CollectionLocation + "', N' ')";
            return librarysystem_help.GetExecuteNonQuery(sqlcmd);
        }
        //实现修改功能
        public static int Getupdete(librarysystem_moder moder)
        {
            // update BookTwo set BookTitle = 'C语言程序设计3', Author = '谭浩强', ISBN = 'ISBN', Abstract = '摘要', Category = '类别', Press = '出版社', Number = 9, PublicationTime = CAST(0x00009F8E00000000 AS DateTime), StorageTime = CAST(0x0000A95700000000 AS DateTime), CollectionLocation = '馆藏位置' where BookTitle = N'C语言程序设计2'
            //update BookTwo set BookTitle = '看11', Author = '谭浩强2', ISBN = 'ISBN', Abstract = '摘要', Category = '类别', Press = '出版社', Number = 9, PublicationTime = CAST(0x00009F8E00000000 AS DateTime), StorageTime = CAST(0x0000A95700000000 AS DateTime), CollectionLocation = '馆藏位置' where BookTitle = N'看11'
            string sqlcmd = "update BookTwo set BookTitle = '" + moder.BookTitle + "',Author='" + moder.Author + "',ISBN= '" + moder.ISBN + "',Abstract= '" + moder.Abstract + "',Category= '" + moder.Category + "' ,Press= '" + moder.Press + "',Number= '" + moder.Number + "',PublicationTime=" + moder.PublicationTime + " ,StorageTime= " + moder.StorageTime + ",CollectionLocation= '" + moder.CollectionLocation + "' where BookTitle = N'" + moder.BookTitle + "'";
            string sqlcmd2 = "update BookTwo set BookTitle = '" + moder.BookTitle + "',Author='" + moder.Author + "',ISBN= '" + moder.ISBN + "',Abstract= '" + moder.Abstract + "',Category= '" + moder.Category + "',Press= '" + moder.Press + "',Number= '" + moder.Number + "',PublicationTime='" + moder.PublicationTime + "' ,StorageTime= '" + moder.StorageTime + "',CollectionLocation= '" + moder.CollectionLocation + "' where BookTitle = '" + moder.BookTitle + "'";

            //update BookTwo set BookTitle = '', Author = '作者', Press = '出版社', ISBN = 'ISBN', Category = '类别', PublicationTime = CAST(0x00009F8E00000000 AS DateTime), StorageTime = CAST(0x0000A95700000000 AS DateTime), Number = 9, CollectionLocation = '馆藏位置', Abstract = '摘要' where BookTitle = 'Java语言编程基础教程'
            // string sqlcmd = "update BookTwo set BookTitle = '"+ moder.BookTitle + "',Author='" + moder.Author + "',Press= '" + moder.Press + "',ISBN= '" + moder.ISBN + "',Category= '" + moder.Category + "',PublicationTime='" + moder.PublicationTime + "' ,StorageTime= '" + moder.StorageTime + "',Number=  " + moder.Number + ",CollectionLocation= '" + moder.CollectionLocation + "',Abstract= '" + moder.Abstract + "' where BookTitle = '" + moder.BookTitle + "'";
            return librarysystem_help.GetExecuteNonQuery(sqlcmd2);
        }
        //实现删除功能
        public static int GetDelete(librarysystem_moder moder)
        {
            string sqlcmd = "delete BookTwo where BookTitle = '" + moder.BookTitle + "'";
            return librarysystem_help.GetExecuteNonQuery(sqlcmd);
        }
        //实现点击获取card对象的所有值
        public static librarysystem_moder GetGameCard(librarysystem_moder moder)
        {
            string sqlcmd = "select * from BookTwo where BookTitle = '" + moder.BookTitle + "'";
            DataTable dt = librarysystem_help.GetTable(sqlcmd);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                moder.ISBN = dt.Rows[i]["ISBN"].ToString();
                moder.BookTitle = dt.Rows[i]["BookTitle"].ToString();
                moder.Author = dt.Rows[i]["Author"].ToString();
                moder.Press = dt.Rows[i]["Press"].ToString();
                moder.Category = dt.Rows[i]["Category"].ToString();
                moder.PublicationTime = dt.Rows[i]["PublicationTime"].ToString();
                moder.StorageTime = dt.Rows[i]["StorageTime"].ToString();
                moder.Number = dt.Rows[i]["Number"].ToString();
                moder.CollectionLocation = dt.Rows[i]["CollectionLocation"].ToString();
                moder.Abstract = dt.Rows[i]["Abstract"].ToString();

            }
            return moder;
        }
        public static DataTable TextGetTable()
        {
            string sqlcmd = "select Category as '类别',StuID as '读者学号',Stumajor as '读者专业',Stuclass as '读者年级',Tel as '联系方式',StuSex as '读者性别',StuName as '读者姓名',Stuschool as '所在学院',LendingTime as '借出时间',Deposit as '押金' from Bookthere  order by StuID asc ";
            return librarysystem_help.TextGetTable(sqlcmd);
        }
        public static int GetZj(librarysystem_moder bookmodel)
        {
            string sqlcmd = "insert into Bookthere values ('" + bookmodel.Category + "'," + bookmodel.StuID + ",'" + bookmodel.Stumajor + "','" + bookmodel.Stuclass + "'," + bookmodel.Tel + ",'" + bookmodel.StuSex + "','" + bookmodel.StuName + "','" + bookmodel.Stuschool + "','" + bookmodel.LendingTime + "'," + bookmodel.Deposit + ")";
            return librarysystem_help.GetExecuteNonQuery(sqlcmd);
        }
        //实现删除功能
        public static int Getdelete(librarysystem_moder bookmodel)
        {
            string sqlcmd = "delete from Bookthere where StuName='" + bookmodel.StuName + "'";
            return librarysystem_help.GetExecuteNonQuery(sqlcmd);
        }
        //实现修改查询
        public static librarysystem_moder bookmodel(int b)
        {
            librarysystem_moder a = new librarysystem_moder();
            string sqlcmd = "select * from Bookthere where StuID = " + b + " ";
            SqlDataReader sqlData = librarysystem_help.SqlCommand(sqlcmd).ExecuteReader();
            while (sqlData.Read())
            {
                a.Category = sqlData["Category"].ToString();
                a.StuID = Convert.ToInt32(sqlData["StuID"].ToString());
                a.Stumajor = sqlData["Stumajor"].ToString();
                a.Stuclass = sqlData["Stuclass"].ToString();
                a.Tel = Convert.ToInt32(sqlData["Tel"].ToString());
                a.StuSex = sqlData["StuSex"].ToString();
                a.StuName = sqlData["StuName"].ToString();
                a.Stuschool = sqlData["Stuschool"].ToString();
                a.LendingTime = sqlData["LendingTime"].ToString();
                a.Deposit = sqlData["Deposit"].ToString();
            }
            return a;
        }
        //执行确认修改
        public static int GetXG(librarysystem_moder bookmodel)
        {
            string sqlcmd = "update Bookthere set Category = '" + bookmodel.Category + "',Stumajor = '" + bookmodel.Stumajor + "',Stuclass = '" + bookmodel.Stuclass + "',Tel = " + bookmodel.Tel + ",StuName = '" + bookmodel.StuName + "',Stuschool = '" + bookmodel.Stuschool + "',LendingTime = '" + bookmodel.LendingTime + "',Deposit = '" + bookmodel.Deposit + "' where StuID=" + bookmodel.StuID + "";
            return librarysystem_help.GetExecuteNonQuery(sqlcmd);
        }
        public static DataTable GetTableQ()
        {
            string sqlcmd = "select BookId '书籍编号',BookTitle '书记标题',Author '作者',LendingBook '借出数量',LendingTime '借出时间',DueDate '应还时间',LateFees '逾期费用' from Book";
            return librarysystem_help.GetTable(sqlcmd);
        }

        public static librarysystem_moder GetTable10(librarysystem_moder a)
        {
            string sqlcmd = "select stuname,stusex,stuage  from studen where stuid=" + a.Stuid + "";
            DataTable b = librarysystem_help.GetTable(sqlcmd);
            for (int i = 0; i < b.Rows.Count; i++)
            {
                a.Stuname = b.Rows[i]["stuname"].ToString();
                a.Stusex = b.Rows[i]["stusex"].ToString();
                a.Stuage = Convert.ToInt32(b.Rows[i]["stuage"].ToString());

            }
            return a;
        }
        public static int GetDelectQ(librarysystem_moder a)
        {
            string sqlstr = "delete Book where BookId=" + a.BookId1 + "";
            string sqlstr1 = "delete studen where stuid=" + a.BookId1 + "";
            return librarysystem_help.GetExecuteNonQuery(sqlstr1) + librarysystem_help.GetExecuteNonQuery(sqlstr);
        }
        public static int GetUpdateQ(librarysystem_moder a)
        {
            string sqlcmd = "update Book set DueDate ='" + a.DueDate1 + "' where BookId = " + a.BookId1 + "";
            return librarysystem_help.GetExecuteNonQuery(sqlcmd);
        }

        public static int deleat(librarysystem_moder a)
        {
            string sqlcmd = "delete Bookthere  where StuID  =" + a.StuID+" ";
            return librarysystem_help.GetExecuteNonQuery(sqlcmd);
        }
    }
}
