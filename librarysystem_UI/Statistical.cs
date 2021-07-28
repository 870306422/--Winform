using BokkUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace librarysystem_UI
{
    public partial class Statistical : Form
    {
        public Statistical()
        {
            InitializeComponent();
        }

        private void Statistical_Load(object sender, EventArgs e)
        {
            Series series = chart2.Series[0];

            chart2.Series[0].Points.AddXY("小说", 95);
            chart2.Series[0].Points.AddXY("哲学类", 30);
            chart2.Series[0].Points.AddXY("社会科学", 20);
            chart2.Series[0].Points.AddXY("传记类", 23);
            chart2.Series[0].Points.AddXY("文学", 60);
            chart2.Series[0].Points.AddXY("经济", 87);
            chart2.Series[0].Points.AddXY("管理", 75);
            chart2.Series[0].Points.AddXY("史记", 88);

            // Series[1]就是上面设计器中的Series2
            chart2.Series[1].Points.AddXY("小说", 160);
            chart2.Series[1].Points.AddXY("哲学类", 130);
            chart2.Series[1].Points.AddXY("社会科学", 116);
            chart2.Series[1].Points.AddXY("传记类", 150);
            chart2.Series[1].Points.AddXY("文学", 170);
            chart2.Series[1].Points.AddXY("经济", 150);
            chart2.Series[1].Points.AddXY("管理", 132);
            chart2.Series[1].Points.AddXY("史记", 124);
            // 隐藏Legend[0]
            chart2.Legends[0].Enabled = false;
            // 设置显示范围
            ChartArea chartArea = chart2.ChartAreas[0];
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = 9;
            chartArea.AxisY.Minimum = 0d;
            chartArea.AxisY.Maximum = 200d;

            chart3.Series[0].Points.AddXY("小说", 95);
            chart3.Series[0].Points.AddXY("哲学类", 30);
            chart3.Series[0].Points.AddXY("社会科学", 20);
            chart3.Series[0].Points.AddXY("传记类", 23);
            chart3.Series[0].Points.AddXY("文学", 60);
            chart3.Series[0].Points.AddXY("经济", 87);
            chart3.Series[0].Points.AddXY("管理", 75);
            chart3.Series[0].Points.AddXY("史记", 88);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage homepage = new Homepage();
            homepage.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrowingAndReturning_UI borrowing = new BorrowingAndReturning_UI();
            borrowing.Show();
        }
    }
}
