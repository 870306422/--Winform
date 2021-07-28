using BokkUI;
using librarysystem_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarysystem_UI
{
    public partial class Land : Form
    {
        public Land()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            librarysystem_BLL.librarysystem_bll.selecta();
            string selectt = string.Format("select * from userinfor where Land = '{0}' and pwd = '{1}' ",this.txt_account.Text,this.txt_pwd.Text);
            DataTable datatable = librarysystem_help.GetTable(selectt);
            if (datatable.Rows.Count > 0  )
            {
                MessageBox.Show(this.txt_account.Text + "登录成功" );
                this.Hide();
                Homepage homepage = new Homepage();
                homepage.Show();
            }
            else
            {
                MessageBox.Show(this.txt_account.Text + "登录失败" + "请重试");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >=0.025)
            {
                this.Opacity -= 0.025;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_account_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                button2.Enabled = true;
            }
        }
    }
}
