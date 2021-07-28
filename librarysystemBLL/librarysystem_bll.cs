using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using librarysystemMODEL;

namespace librarysystemBLL
{
   public class librarysystem_bll
    {
        public static DataTable GetTable()
        {
            return librarysystemDAL.librarysystem_Domer.GetTable();
        }
        public static librarysystem_moder GetTable1(librarysystem_moder a)
        {
            return librarysystemDAL.librarysystem_Domer.GetTable1(a);
        }
       
        public static int GetDelect(librarysystem_moder a)
        {
            return librarysystemDAL.librarysystem_Domer.GetDelect(a);
        }
        public static int GetUpdate(librarysystem_moder a)
        {
            return librarysystemDAL.librarysystem_Domer.GetUpdate(a);
        }
    }
}
