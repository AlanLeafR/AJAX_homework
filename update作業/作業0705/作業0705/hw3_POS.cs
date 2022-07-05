using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作業0705
{
    public partial class hw3_POS : Form
    {
        public hw3_POS()
        {
            InitializeComponent();
        }

        int totalPrice=0; //總價
        int juiceTotal, friesTotal, colaTotal, chickenTotal; //商品個別總價
        int juicePrice = 50, friesPrice = 30, colaPrice = 25, chickenPrice = 40; //商品價格
        int juiceCount, friesCount, colaCount, chickenCount; //商品數量
        double credit;
        string juiceStr, friesStr, colaStr, chickenStr; //商品字串

        private void button3_Click(object sender, EventArgs e)
        {
            totalPrice = 0; juiceTotal = 0; friesTotal = 0; colaTotal = 0; chickenTotal = 0;
            credit = 0; juiceCount = 0; friesCount = 0; colaCount = 0; chickenCount = 0;
            juiceStr = ""; friesStr = ""; colaStr = ""; chickenStr = "";
            label2.Text = "尚未點餐";
            textBox1.Text = "金額NT$0元";

        }


   

        void ALL_total()
        {
            totalPrice = juiceTotal + friesTotal + colaTotal + chickenTotal;
            textBox1.Text = "NT$" + totalPrice.ToString() + "元";
            label2.Text = juiceStr + friesStr + colaStr + chickenStr;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            juiceCount++;
            juiceTotal = juiceCount * juicePrice;
            juiceStr = "果汁x " + juiceCount + "共NT$" + juiceTotal + "元\n";
            ALL_total();         

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            friesCount++;
            friesTotal = friesCount * friesPrice;            
            friesStr = "薯條x " + friesCount + "共NT$" + friesTotal + "元\n";
            ALL_total();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            colaCount++;
            colaTotal = colaCount * colaPrice;
            colaStr = "可樂x " + colaCount + "共NT$" + colaTotal + "元\n";
            ALL_total();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            chickenCount++;
            chickenTotal = chickenCount * chickenPrice;
            chickenStr = "炸雞x " + chickenCount + "共NT$" + chickenTotal + "元\n";
            ALL_total();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (totalPrice == 0)
            {
                MessageBox.Show("尚未點餐！", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("總金額：NT$" + totalPrice, "確認付款", MessageBoxButtons.YesNo);
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (totalPrice == 0)
            {
                MessageBox.Show("尚未點餐！", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                credit = Math.Round(totalPrice * 0.9);
                MessageBox.Show("總金額：NT$" + totalPrice + "\n" +
                    "折扣後金額：NT$" + credit
                    , "確認付款", MessageBoxButtons.YesNo);
            }

        }
    }
}
