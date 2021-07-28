using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using librarysystem_MODER;
using librarysystem_UI;

namespace BokkUI
{
    public partial class AddAuthor : Form
    {
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void btn_certain_Click(object sender, EventArgs e)
        {
            
            string a = date_Rng.Text;
            string c = "";
            char b = a[0];
            for (int i = 0; i < a.Length - 1; i++)
            {
                b = a[i];
                if (b == '年')
                {
                    b = '-';
                }
                else if (b == '月')
                {
                    b = '-';
                }
                c += b;
            }
            librarysystem_moder abookmodel1 = new librarysystem_moder();
            abookmodel1.LendingTime = c;
            abookmodel1.Category = cox_leeibie.Text;
            abookmodel1.StuID = Convert.ToInt32(txt_StuID.Text);
            abookmodel1.Stumajor = cox_zhuanye.Text;
            abookmodel1.Stuclass = txt_Class.Text;
            abookmodel1.Tel = Convert.ToInt32(txt_Tel.Text);
            abookmodel1.StuSex = cox_Sex.Text;
            abookmodel1.StuName = txt_Name.Text;
            abookmodel1.Stuschool = cox_xueyuan.Text;
            abookmodel1.Deposit = numericUpDown1.Text;
            int sc = librarysystem_BLL.librarysystem_bll.Getxz(abookmodel1);
            if (sc > 0)
            {
                MessageBox.Show("添加成功");
                this.Hide();
                add add = new add();
                add.Show();
               
            }

            else
            {
                MessageBox.Show("添加失败");
            }
        }
        private void btn_certain2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            string a = date_Rng.Text;
            string c = "";
            char b = a[0];
            for (int i = 0; i < a.Length - 1; i++)
            {
                b = a[i];
                if (b == '年')
                {
                    b = '-';
                }
                else if (b == '月')
                {
                    b = '-';
                }
                c += b;
            }
            librarysystem_moder abookmodel1 = new librarysystem_moder();
            abookmodel1.LendingTime = c;
            abookmodel1.Category = cox_leeibie.Text;
            abookmodel1.StuID = Convert.ToInt32(txt_StuID.Text);
            abookmodel1.Stumajor = cox_zhuanye.Text;
            abookmodel1.Stuclass = txt_Class.Text;
            abookmodel1.Tel = Convert.ToInt32(txt_Tel.Text);
            abookmodel1.StuSex = cox_Sex.Text;
            abookmodel1.StuName = txt_Name.Text;
            abookmodel1.Stuschool = cox_xueyuan.Text;
            abookmodel1.Deposit = numericUpDown1.Text;
            int count = librarysystem_BLL.librarysystem_bll.Getxxg(abookmodel1);
            if (count > 0)
            {
                MessageBox.Show("修改成功");
                this.Hide();
                add add = new add();
                add.Show();
                              
            }
            else
            {
                MessageBox.Show("修改失败");
            }


        }

        private void 读者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            add add = new add();
            add.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity>=0.025)
            {
                this.Opacity -= 0.025;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            add add = new add();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            BorrowingAndReturning_UI andReturning_UI = new BorrowingAndReturning_UI();
            andReturning_UI.Show();
        }

        private void AddAuthor_Load(object sender, EventArgs e)
        {

        }
    }
}
