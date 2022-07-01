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
    public partial class hw7_Simple_Calculator : Form
    {
        public hw7_Simple_Calculator()
        {
            InitializeComponent();
        }

        double check_double = 0;
        bool Check1,Check2;


        private void btn_plus_Click(object sender, EventArgs e)
        {
            
            Check1 = double.TryParse(txt_Num1.Text, out check_double);
            Check2 = double.TryParse(txt_Num2.Text, out check_double);
            if (Check1 && Check2)
            {
                double result_plus = double.Parse(txt_Num1.Text) + double.Parse(txt_Num2.Text);
                double END_plus = Math.Round(result_plus, 4, MidpointRounding.AwayFromZero);
                txt_Ans.Text = END_plus.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值。");
            }

        }

        private void btn_minus_Click(object sender, EventArgs e)
        {

            Check1 = double.TryParse(txt_Num1.Text, out check_double);
            Check2 = double.TryParse(txt_Num2.Text, out check_double);
            if (Check1 && Check2)
            {
                double result_plus = double.Parse(txt_Num1.Text) - double.Parse(txt_Num2.Text);
                double END_minus = Math.Round(result_plus, 4, MidpointRounding.AwayFromZero);
                txt_Ans.Text = END_minus.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值。");
            }

        }

        private void btn_multiplite_Click(object sender, EventArgs e)
        {
            Check1 = double.TryParse(txt_Num1.Text, out check_double);
            Check2 = double.TryParse(txt_Num2.Text, out check_double);
            if (Check1 && Check2)
            {
                double result_plus = double.Parse(txt_Num1.Text) * double.Parse(txt_Num2.Text);
                double END_multi = Math.Round(result_plus, 4, MidpointRounding.AwayFromZero);
                txt_Ans.Text = END_multi.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值。");
            }

        }



        private void btn_divide_Click(object sender, EventArgs e)
        {
            Check1 = double.TryParse(txt_Num1.Text, out check_double);
            Check2 = double.TryParse(txt_Num2.Text, out check_double);
            if (Check1 && Check2)
            {
                double result_plus = double.Parse(txt_Num1.Text) / double.Parse(txt_Num2.Text);
                double END_divide = Math.Round(result_plus, 4, MidpointRounding.AwayFromZero);
                txt_Ans.Text = END_divide.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值。");
            }


        }
    }
}
