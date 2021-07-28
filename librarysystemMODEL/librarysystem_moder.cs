using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarysystemMODEL
{
    public class librarysystem_moder
    {
        int stuid;
        string stuname;
        string stusex;
        int stuage;

        public int Stuid { get => stuid; set => stuid = value; }
        public string Stuname { get => stuname; set => stuname = value; }
        public string Stusex { get => stusex; set => stusex = value; }
        public int Stuage { get => stuage; set => stuage = value; }
        public int BookId1 { get => BookId; set => BookId = value; }
        public string DueDate1 { get => DueDate; set => DueDate = value; }

        int BookId;
        string DueDate;
    }
}
