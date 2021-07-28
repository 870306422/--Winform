using BokkUI;
using librarysystem_UI;
using librarysystemUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using librarysystem_MODER;
using librarysystem_BLL;

namespace BoolUI
{
    public partial class WinOneUI : Form
    {
        public WinOneUI()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = librarysystem_BLL.librarysystem_bll.TextGetTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           librarysystem_moder a = new librarysystem_moder();
           a.StuID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["读者学号"].Value.ToString());
            if (librarysystem_bll.deleat(a)>0)
            {
                MessageBox.Show("还书成功！！！");
               
            }
            else
            {
                MessageBox.Show("还书失败！！！");
            } 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

        private void WinOneUI_Load(object sender, EventArgs e)
        {
            //设置整行选中
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //禁止多行被选 
            this.dataGridView1.MultiSelect = false;
            dataGridView1.DataSource= librarysystem_BLL.librarysystem_bll.TextGetTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           textBox2.Text = dataGridView1.SelectedRows[0].Cells["读者学号"].Value.ToString();
           textBox1.Text = dataGridView1.SelectedRows[0].Cells["读者姓名"].Value.ToString();
           numericUpDown1.Text = dataGridView1.SelectedRows[0].Cells["押金"].Value.ToString();
        }
    }
}
