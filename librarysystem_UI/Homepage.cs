using librarysystem_UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BokkUI
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

      

       

        private void 数形统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Statistical statistical = new Statistical();
            //statistical.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            this.Hide();
            Statistical statistical = new Statistical();
            timer1.Start();
            statistical.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 0.025)
            {
                this.Opacity -= 0.025;
            }
        }
    }

      
    
}
