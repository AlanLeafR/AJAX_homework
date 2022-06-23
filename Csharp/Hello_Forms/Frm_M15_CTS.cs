using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_Forms
{
    public partial class Frm_M15_CTS : Form
    {
        public Frm_M15_CTS()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            long A = 100;

            MessageBox.Show("A："+A.ToString());
            
            long B = 200;

            MessageBox.Show("A：" + A.ToString() + " , B：" + B.ToString());

            B = 300;

            MessageBox.Show("A：" + A.ToString() + " , B：" + B.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TextBox tb = txt_Reference;
            tb.Text = "Reference";
            tb.BackColor = Color.Khaki;
            tb.ForeColor = Color.Chocolate;
            tb.Location = new Point(150, 100);
            // tb.Font = new Font() 找物件瀏覽器填入參數
        }




        ProductS pro = new ProductS();
        

        private void btn_Stu_Click(object sender, EventArgs e)
        {

            
            pro.proCount++;
            pro.proName = textBox1.Text;
            pro.proPrice = int.Parse(textBox2.Text);
            label1.Text = "名稱：" + pro.proName + "，數量：" + pro.proCount + "，價格：" + pro.proPrice* pro.proCount;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pro.reset();
            label1.Text = "名稱：" + pro.proName + "，數量：" + pro.proCount + "，價格：" + pro.proPrice;
        }
    }
}
