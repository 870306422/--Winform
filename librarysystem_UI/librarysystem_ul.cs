using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using librarysystem_MODER;
using librarysystem_BLL;
using BokkUI;

namespace librarysystem_UI
{
    public partial class librarysystem_ul : Form
    {
        public librarysystem_ul()
        {
            InitializeComponent();
        }

        private void librarysystem_ul_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = librarysystem_BLL.librarysystem_bll.DataTable();
            Font font = new Font("UTF-8", 10);//UTF-8是字体的编码格式，2是字体大小
            dataGridView1.Font = font;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            librarysystem_moder moder = new librarysystem_moder();
            moder.BookTitle = this.dataGridView1.SelectedRows[0].Cells["书籍标题"].Value.ToString();
            int result = librarysystem_bll.GetDelete(moder);
            if (result > 0)
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = librarysystem_BLL.librarysystem_bll.DataTable();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
            librarysystem_moder moder = new librarysystem_moder();
            moder.BookTitle = this.dataGridView1.SelectedRows[0].Cells["书籍标题"].Value.ToString();
            moder = librarysystem_bll.GetGameCard(moder);
            txt_BookTitle.Text = moder.BookTitle.ToString();
            txt_Abstract.Text = moder.Abstract.ToString();
            txt_Author.Text = moder.Author.ToString();
            txt_Category.Text = moder.Category.ToString();
            txt_CollectionLocation.Text = moder.CollectionLocation.ToString();
            txt_ISBN.Text = moder.ISBN.ToString();
            txt_Press.Text = moder.Press.ToString();
            txt_PublicationTime.Text = moder.PublicationTime.ToString();
            txt_StorageTime.Text = moder.StorageTime.ToString();
            txt_Number.Text =moder.Number.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            librarysystem_moder moder = new librarysystem_moder();
            moder.BookTitle = txt_BookTitle.Text;
            moder.Abstract = txt_Abstract.Text;
            moder.Author = txt_Author.Text;
            moder.Category = txt_Category.Text;
            moder.CollectionLocation = txt_CollectionLocation.Text;
            moder.ISBN = txt_ISBN.Text;
            moder.Press = txt_Press.Text;
            moder.PublicationTime = txt_PublicationTime.Text;
            moder.StorageTime = txt_StorageTime.Text;
            moder.Number = txt_Number.Text;
            int result = librarysystem_bll.GetInset(moder);
            if (result > 0)
            {
                MessageBox.Show("增加成功");
            }
            else
            {
                MessageBox.Show("增加失败");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            librarysystem_moder moder = new librarysystem_moder();
            moder.BookTitle = this.dataGridView1.SelectedRows[0].Cells["书籍标题"].Value.ToString();
            moder.BookTitle = txt_BookTitle.Text;
            moder.Abstract = txt_Abstract.Text;
            moder.Author = txt_Author.Text;
            moder.Category = txt_Category.Text;
            moder.CollectionLocation = txt_CollectionLocation.Text;
            moder.ISBN = txt_ISBN.Text;
            moder.Press = txt_Press.Text;
            moder.PublicationTime = txt_PublicationTime.Text;
            moder.StorageTime = txt_StorageTime.Text;
            moder.Number = txt_Number.Text;
            int result = librarysystem_bll.Getupdete(moder);
            if (result > 0)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity>=0.025)
            {
                this.Opacity -= 0.025;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Homepage homepage = new Homepage();
            homepage.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
