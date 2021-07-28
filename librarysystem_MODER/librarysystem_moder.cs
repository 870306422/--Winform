using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarysystem_MODER
{
    public class librarysystem_moder
    {
        private int bookId;//书籍编号
        private int lendingBook;//借出数量
        private double lateFees;//逾期费用
        private string bookTitle;//书籍标题
        private string author;//作者
        private string lendingTime;//借出时间
        private string dueDate;//应还时间
        private string @abstract;//摘要
        private string iSBN;//国际标准书号isbn
        private string category;//类别
        private string press;//出版社
        private string number;//数量
        private string publicationTime;//出版时间
        private string storageTime;//入库时间
        private string collectionLocation;//馆藏位置
        private string picturePath;//图片路径
        private string land;
        private string pwd;
        private string mname; //模糊
        private int stuid;
        private string stuname;
        private string stusex;
        private int stuage;

        //读者学号
        public int StuID { get; set; }
        //读者专业
        public string Stumajor { get; set; }
        //读者年级
        public string Stuclass { get; set; }
        //联系方式
        public int Tel { get; set; }
        //读者性别
        public string StuSex { get; set; }
        //读者姓名
        public string StuName { get; set; }
        //所在学院
        public string Stuschool { get; set; }
        //押金
        public string Deposit { get; set; }
        public int ppaid { get; set; }
        public int Stuid { get => stuid; set => stuid = value; }
        public string Stuname { get => stuname; set => stuname = value; }
        public string Stusex { get => stusex; set => stusex = value; }
        public int Stuage { get => stuage; set => stuage = value; }
        public int BookId1 { get => BookId; set => BookId = value; }
        public string DueDate1 { get => DueDate; set => DueDate = value; }
        public string Land { get => land; set => land = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public int BookId { get => bookId; set => bookId = value; }
        public int LendingBook { get => lendingBook; set => lendingBook = value; }
        public double LateFees { get => lateFees; set => lateFees = value; }
        public string BookTitle { get => bookTitle; set => bookTitle = value; }
        public string Author { get => author; set => author = value; }
        public string LendingTime { get => lendingTime; set => lendingTime = value; }
        public string DueDate { get => dueDate; set => dueDate = value; }
        public string Abstract { get => @abstract; set => @abstract = value; }
        public string ISBN { get => iSBN; set => iSBN = value; }
        public string Category { get => category; set => category = value; }
        public string Press { get => press; set => press = value; }
        public string Number { get => number; set => number = value; }
        public string PublicationTime { get => publicationTime; set => publicationTime = value; }
        public string StorageTime { get => storageTime; set => storageTime = value; }
        public string CollectionLocation { get => collectionLocation; set => collectionLocation = value; }
        public string PicturePath { get => picturePath; set => picturePath = value; }
        public string Mname { get => mname; set => mname = value; }
    }
}
