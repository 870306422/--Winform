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
using librarysystem_UI;

namespace BokkUI
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }
        //显示数据表
        private void Fine_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = librarysystem_BLL.librarysystem_bll.TextGetTable();
        }

        //刷新
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = librarysystem_BLL.librarysystem_bll.TextGetTable();
        }
        //跳转修改页面
        private void btn_modify_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAuthor add = new AddAuthor();
            add.Show();
            add.btn_certain.Hide();
            add.label1.Text = "修改读者信息";
            add.btn_certain.Text = "确定修改";
            add.button1.Hide();
            add.button2.Hide();
            librarysystem_moder bookmodel = new librarysystem_moder();
            bookmodel.ppaid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["读者学号"].Value.ToString());
            librarysystem_moder b = librarysystem_BLL.librarysystem_bll.bookmodel(bookmodel.ppaid);
            add.txt_Name.Text = b.StuName;
            add.txt_StuID.Text = b.StuID.ToString() ;
            add.txt_Class.Text = b.Stuclass;
            add.txt_Tel.Text = b.Tel.ToString();
            add.cox_leeibie.Text = b.Category;
            add.cox_Sex.Text = b.StuSex;
            add.cox_zhuanye.Text = b.Stumajor;
            add.numericUpDown1.Text = b.Deposit.ToString();
            add.cox_xueyuan.Text = b.Stuschool;
            add.date_Rng.Text = b.LendingTime;

        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_lb.Text = dataGridView1.SelectedRows[0].Cells["类别"].Value.ToString();
            txt_name.Text = dataGridView1.SelectedRows[0].Cells["读者姓名"].Value.ToString();
        }

        private void 添加读者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            librarysystem_moder bookmodel = new librarysystem_moder();
            bookmodel.StuName = this.dataGridView1.SelectedRows[0].Cells["读者姓名"].Value.ToString();
            int sc = librarysystem_BLL.librarysystem_bll.Getdelete(bookmodel);
            if (sc > 0)
            {
                MessageBox.Show("删除成功");
                dataGridView1.DataSource = librarysystem_BLL.librarysystem_bll.TextGetTable();

            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAuthor addAuthor = new AddAuthor();
            addAuthor.Show();
            addAuthor.btn_certain2.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            BorrowingAndReturning_UI andReturning_UI = new BorrowingAndReturning_UI();
            andReturning_UI.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
