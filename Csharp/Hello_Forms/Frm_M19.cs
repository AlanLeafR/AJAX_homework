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
    public partial class Frm_M19 : Form
    {
        public Frm_M19()
        {
            InitializeComponent();
        }

        string Result = "產品列表：\n\n";
        int ProductCount = 0;
        int ProductTotal = 0;

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Products pro;
            pro.ProductName = txt_ProductName.Text;
            //pro.ProductPrice = decimal.Parse(txt_ProductPrice.Text);

            //Result += "產品名稱－" + pro.ProductName + "，產品價格：" + pro.ProductPrice + "\n";

            bool num;
            num = decimal.TryParse(txt_ProductPrice.Text, out pro.ProductPrice);

            if (num)
            {
                Result += "產品名稱－" + pro.ProductName + "，產品價格：" + pro.ProductPrice + "\n";
                ProductCount++;
                ProductTotal += (int)pro.ProductPrice;
            }
            else
            {
                MessageBox.Show("請輸入數字!!", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ProductPrice.Clear();
                txt_ProductPrice.Focus();
            }

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            lab_List.Text = Result;
            lab_ProductDetail.Text = "產品總量－共" + ProductCount+"項，產品總價－"+ProductTotal+"元";
        }
    }
}
