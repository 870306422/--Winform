using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BokkUI;
using BoolUI;
using librarysystem_MODER;
using librarysystemUI;

namespace librarysystem_UI
{
    public partial class BorrowingAndReturning_UI : Form
    {
        public BorrowingAndReturning_UI()
        {
            InitializeComponent();
        }

        private void BorrowingAndReturning_UI_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = librarysystem_BLL.librarysystem_bll.GetData();
            lbl_time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            librarysystem_moder Moder = new librarysystem_moder();
            Moder.Mname = lal_keyWord.Text.Trim();
            librarysystem_BLL.librarysystem_bll.GetTable(Moder);
            this.dataGridView1.DataSource = librarysystem_BLL.librarysystem_bll.GetTable(Moder);
            //if ()
            //{

            //}
        }

        private void lbl_results_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_time_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 0.025)
            {
                this.Opacity -= 0.025;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Start();
            this.Close();
            Form1 form = new Form1();
            form.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.Close();
            WinOneUI winOneUI = new WinOneUI();
            winOneUI.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.Close();
            librarysystem_ul uI = new librarysystem_ul();
            uI.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage homepage = new Homepage();
            homepage.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistical statistical = new Statistical();
            statistical.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            add addd = new add();
            addd.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
