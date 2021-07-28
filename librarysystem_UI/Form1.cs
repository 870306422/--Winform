using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BokkUI;
using BoolUI;
using librarysystem_MODER;
using librarysystem_UI;

namespace librarysystemUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            librarysystem_moder a = new librarysystem_moder();
            a.Stuid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["书籍编号"].Value);
            textBox1.Text = dataGridView1.SelectedRows[0].Cells["应还时间"].Value.ToString();
            a = librarysystem_BLL.librarysystem_bll.GetTable1(a);
            //textBox1.Text =a.DueDate1.ToString();
            listbox1.Items.Add("姓名:" + a.Stuname);
            listbox1.Items.Add("性别:" + a.Stusex);
            listbox1.Items.Add("年龄:" + a.Stuage);
            if (listbox1.Items.Count > 3)
            {
                listbox1.Items.Clear();
                listbox1.Items.Add("姓名:" + a.Stuname);
                listbox1.Items.Add("性别:" + a.Stusex);
                listbox1.Items.Add("年龄:" + a.Stuage);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = librarysystem_BLL.librarysystem_bll.GetTable();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells["BookId"].Value);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            librarysystem_moder a = new librarysystem_moder();
            a.BookId1 = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["书籍编号"].Value.ToString());
            int result = librarysystem_BLL.librarysystem_bll.GetDelect(a);
            if (result > 0)
            {
                MessageBox.Show("注销成功");
                this.dataGridView1.DataSource = librarysystem_BLL.librarysystem_bll.GetTable();

            }
            else
            {
                MessageBox.Show("注销失败");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            librarysystem_moder a = new librarysystem_moder();
            a.BookId1 = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["书籍编号"].Value.ToString());
            a.DueDate1 = textBox1.Text;
            int result = librarysystem_BLL.librarysystem_bll.GetUpdate(a);
            if (result > 0)
            {
                MessageBox.Show("续借成功");
                this.dataGridView1.DataSource = librarysystem_BLL.librarysystem_bll.GetTable();
            }
            else
            {
                MessageBox.Show("续借失败");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Homepage homepage = new Homepage();
            homepage.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            WinOneUI win = new WinOneUI();
            win.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            librarysystem_ul librarysystem = new librarysystem_ul();
            librarysystem.Show();
        }
    }
}
