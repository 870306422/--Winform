using librarysystem_DAL;
using librarysystem_MODER;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarysystem_BLL
{
    public class librarysystem_bll
    {
        public static DataTable GetData()
        {
            return librarysystem_DAL.librarysystem_Domer.dataTable();
        }
        public static void selecta()
        {
            librarysystem_DAL.librarysystem_Domer.selecta();
        }
        public static DataTable GetTable(librarysystem_moder mnane)
        {
            return librarysystem_DAL.librarysystem_Domer.bo(mnane);
        }
        public static DataTable GetTable()
        {
            return librarysystem_DAL.librarysystem_Domer.GetTable();
        }
        public static librarysystem_moder GetTable1(librarysystem_moder a)
        {
            return librarysystem_DAL.librarysystem_Domer.GetTable1(a);
        }

        public static int GetDelect(librarysystem_moder a)
        {
            return librarysystem_DAL.librarysystem_Domer.GetDelect(a);
        }
        public static int GetUpdate(librarysystem_moder a)
        {
            return librarysystem_DAL.librarysystem_Domer.GetUpdate(a);
        }
        //实现刷新界面
        public static DataTable DataTable()
        {
            return librarysystem_Domer.DataTable();
        }
        //实现增加功能
        public static int GetInset(librarysystem_moder moder)
        {
            return librarysystem_Domer.GetInset(moder);
        }
        //实现修改功能
        public static int Getupdete(librarysystem_moder moder)
        {
            return librarysystem_Domer.Getupdete(moder);
        }
        //实现删除功能
        public static int GetDelete(librarysystem_moder moder)
        {
            return librarysystem_Domer.GetDelete(moder);

        }
        //点击获取Card对象
        public static librarysystem_moder GetGameCard(librarysystem_moder moder)
        {
            return librarysystem_Domer.GetGameCard(moder);
        }
        //获取数据表
        public static DataTable TextGetTable()
        {
            return librarysystem_DAL.librarysystem_Domer.TextGetTable();
        }
        //获取新增后影响行数
        public static int Getxz(librarysystem_moder bookmodel)
        {
            return librarysystem_DAL.librarysystem_Domer.GetZj(bookmodel);
        }
        //获取删除后影响行数
        public static int Getdelete(librarysystem_moder bookmodel)
        {
            return librarysystem_DAL.librarysystem_Domer.Getdelete(bookmodel);
        }
        public static librarysystem_moder bookmodel(int bookmodel)
        {
            return librarysystem_DAL.librarysystem_Domer.bookmodel(bookmodel);
        }
        //修改
        public static int Getxxg(librarysystem_moder bookmodel)
        {
            return librarysystem_DAL.librarysystem_Domer.GetXG(bookmodel);
        }
        public static DataTable GetTableQQ()
        {
            return librarysystem_DAL.librarysystem_Domer.GetTableQ();
        }
        public static librarysystem_moder GetTable1QQ(librarysystem_moder a)
        {
            return librarysystem_DAL.librarysystem_Domer.GetTable10(a);
        }

        public static int GetDelectQQ(librarysystem_moder a)
        {
            return librarysystem_DAL.librarysystem_Domer.GetDelectQ(a);
        }
        public static int GetUpdateQQ(librarysystem_moder a)
        {
            return librarysystem_DAL.librarysystem_Domer.GetUpdateQ(a);
        }
       public static int deleat(librarysystem_moder a)
        {
            return librarysystem_Domer.deleat(a);
        }
    }
}
